using AForge.Video.DirectShow;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using ZXing;
using ZXing.Windows.Compatibility;

#pragma warning disable S1215
namespace LibCheck.Forms.SearchTools {
    public partial class SearchDialog : Form {

        public enum SearchType {
            All,
            Student,
            Book
        }

        private const int MAX_UPDATE_TIME_MS = 70;
        private DateTime _lastUpdateTimeStamp = DateTime.Now;
        private FilterInfoCollection? devs;
        private VideoCaptureDevice? videoSource;
        private Bitmap? blackBmp;
        private readonly BarcodeReader reader = new BarcodeReader();
        private readonly bool inModular;
        private bool isQRDetectionOngoing = false;
        private bool inSuspension = false;


        internal SearchType Search { get; private set; }

        internal SearchType ResultSearchType { get; private set; }
        internal string Value { get; private set; } = string.Empty;

        public SearchDialog(SearchType t, bool inModular) {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Search = t;
            this.inModular = inModular;

            if (inModular) {
                ControlBox = false;
                TopLevel = false;
                Dock = DockStyle.Fill;
            }
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        internal void SuspendOp(bool directlyClose) {
            if (!inModular) throw new InvalidOperationException("Unable to invoke a method when a search is not modular.");
            if (inSuspension) return;
            TerminateCamera();

            if (directlyClose) {
                Close();
                return;
            }
            inSuspension = true;
        }

        internal void ResumeOp() {
            if (!inModular) throw new InvalidOperationException("Unable to invoke a method when a search is not modular.");
            if (!inSuspension) return;
            camComboBox_SelectedIndexChanged(this, EventArgs.Empty);
            inSuspension = false;
        }

        private void SearchDialog_Load(object sender, EventArgs e) {
            while (!IsHandleCreated)
                Thread.Sleep(100);

            InitializeCameraComboBox();
            InitializeSearchTypeUI();

            camComboBox.SelectedIndex = 0;
        }

        private void InitializeCameraComboBox() {
            devs = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in devs)
                camComboBox.Items.Add(info.Name);
        }

        private void InitializeSearchTypeUI() {
            if (Search != SearchType.All) {
                SearchBookRButton.Enabled = false;
                SearchStudentRButton.Enabled = false;
                SearchBookRButton.Checked = Search == SearchType.Book;
                SearchStudentRButton.Checked = Search == SearchType.Student;
            }

            label2.Text = Search switch {
                SearchType.Student => "Scan the Student ID to check their status or make a transaction.",
                SearchType.Book => "Scan the book ID.",
                _ => $"Welcome to {Credentials.Librarian?.SchoolName} library!"
            };
        }

        private void QRCamModule_QRDetected(SearchType typ, string val) {
            if (Search != SearchType.All && Search != typ) return;
            try {
                Value = val;
                ResultSearchType = typ;

                Invoke(new Action(() => {
                    if (!inModular) Close();
                }));
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Warn, $"Failed to invoke. ({ex.Message})");
            }
        }

        private void camComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            string? val = camComboBox.Items[camComboBox.SelectedIndex].ToString();
            if (string.IsNullOrEmpty(val))
                return;
            Value = "";
            TerminateCamera();
            StartCamera(val);
        }

        private void StartCamera(string videoInput) {
            if (videoSource != null && videoSource.IsRunning)
                return;

            devs ??= new FilterInfoCollection(FilterCategory.VideoInputDevice);

            for (int i = 0; i < devs.Count; i++) {
                if (!devs[i].Name.Equals(videoInput))
                    continue;

                videoSource = new VideoCaptureDevice(devs[i].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
                return;
            }

            MessageBox.Show("No specific device has been found.");
        }

        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs) {
            if (!IsHandleCreated) return;
            if (DateTime.Now >= _lastUpdateTimeStamp.AddMilliseconds(MAX_UPDATE_TIME_MS)) {
                if (eventArgs.Frame == null) {
                    blackBmp ??= CreateBlankBmp();
                    using (Bitmap oldBmp = (Bitmap)pictureBox1.Image)
                        pictureBox1.Image = (Bitmap)blackBmp.Clone();
                    return;
                }
                using (Bitmap bmp = AForge.Imaging.Image.Clone(eventArgs.Frame)) {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();

                    try {
                        _lastUpdateTimeStamp = DateTime.Now;
                        pictureBox1.Image = null;
                        pictureBox1.Image = AForge.Imaging.Image.Clone(bmp);
                    } catch {
                        // Ignore
                    }

                    if (!isQRDetectionOngoing) {
                        isQRDetectionOngoing = true;

                        try {
                            Result r = reader.Decode(bmp);
                            if (r == null) return;

                            string[] arr = r.Text.Split('#', StringSplitOptions.RemoveEmptyEntries);
                            if (arr.Length != 4 || !arr[0].Equals("LC")|| !arr[1].Equals(Credentials.Librarian?.SchoolGUID) || 
                                !int.TryParse(arr[2], out int typ)) return;

                            switch (typ) {
                                case 0:
                                    QRCamModule_QRDetected(SearchType.Book, arr[3]);
                                    break;
                                case 1:
                                    QRCamModule_QRDetected(SearchType.Student, arr[3]);
                                    break;
                                default:
                                    return;
                            }
                        } catch (Exception ex) {
                            Logger.Log(Logger.LogEnums.Warn, $"An error occurred during QR detection. ({ex.Message})");
                        } finally {
                            isQRDetectionOngoing = false;
                        }
                    }
                }

            }
        }

        private void TerminateCamera() {
            if (videoSource == null || !videoSource.IsRunning)
                return;

            videoSource.SignalToStop();
            videoSource.NewFrame -= VideoSource_NewFrame;
            videoSource = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            blackBmp ??= CreateBlankBmp();
            using (Bitmap oldBmp = (Bitmap)pictureBox1.Image)
                pictureBox1.Image = (Bitmap)blackBmp.Clone();
        }

        private void ManualSearchButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text)) {
                MessageBox.Show(this, "Please provide a search text.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            QRCamModule_QRDetected(SearchStudentRButton.Checked ? SearchType.Student : SearchType.Book, SearchTextBox.Text);
        }

        private void BackButton_Click(object sender, EventArgs e) {
            CamPanel.BringToFront();
            camComboBox_SelectedIndexChanged(sender, EventArgs.Empty);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            TerminateCamera();
            AltPanel.BringToFront();
        }

        private static Bitmap CreateBlankBmp() {
            Bitmap tmpBlackBmp = new Bitmap(300, 300);

            using (Graphics g = Graphics.FromImage(tmpBlackBmp)) {
                SolidBrush b = new SolidBrush(Color.Black);
                g.FillRectangle(b, 0, 0, tmpBlackBmp.Width, tmpBlackBmp.Height);
                g.Flush();
            }

            return tmpBlackBmp;
        }

        private void SearchDialog_FormClosing(object sender, FormClosingEventArgs e) {
            if (!inModular) {
                TerminateCamera();
                return;
            }
            Value = "";

        }
    }
}
