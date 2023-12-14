using AForge.Video;
using AForge.Video.DirectShow;

namespace LibCheck.Modules {

    internal delegate void NewFrameDelegate(Bitmap bmp);

    internal static class QRCamModule {

        private static FilterInfoCollection? devs;
        private static VideoCaptureDevice? videoSource;
        private static Bitmap? blackBmp;

        internal static event NewFrameDelegate? NewFrame;

        internal static int Count { get => devs == null ? -1 : devs.Count; }

        internal static bool IsRunning { get => videoSource != null && videoSource.IsRunning; }

        internal static string[] ListInputDevices() {
            devs = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            List<string> devNames = new List<string>();
            for (int i = 0; i < devs.Count; i++)
                devNames.Add(devs[i].Name);

            return devNames.ToArray();
        }

        internal static void Start(string inputName) {
            if (videoSource != null && IsRunning) return;
            devs ??= new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < devs.Count; i++) {
                if (!devs[i].Name.Equals(inputName)) continue;
                videoSource = new VideoCaptureDevice(devs[i].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
                return;
            }
            throw new InvalidOperationException("No specific device has been found.");
        }

        internal static void Stop() {
            if (videoSource == null || !IsRunning) return;
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            blackBmp ??= CreateBlankBmp();
            NewFrame?.Invoke((Bitmap)blackBmp.Clone());
        }

        private static void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            if (eventArgs.Frame == null) {
                blackBmp ??= CreateBlankBmp();
                NewFrame?.Invoke((Bitmap)blackBmp.Clone());
                return;
            }
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            NewFrame?.Invoke(bmp);
            // QR Code goes here...
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
    }
}
