using LibCheck.Modules;
using System.Management;

namespace LibCheck.Forms.Admin {
    public partial class RegisterDriveDialog : Form {

        private Dictionary<DriveInfo, string> drives = new Dictionary<DriveInfo, string>();
        private Thread t;

        private bool isRunning = false;
        public RegisterDriveDialog() {
            InitializeComponent();

        }

        private void RegisterDriveDialog_Load(object sender, EventArgs e) {
            LoadDrive();
            t = new Thread(CheckDrivesThread);
            t.Start();
        }

        private void RegisterDriveDialog_FormClosing(object sender, FormClosingEventArgs e) {
            isRunning = false;
        }

        private void CheckDrivesThread() {
            isRunning = true;
            while (isRunning) {
                CheckDrives();
                Thread.Sleep(1000);
            }
        }

        private void CheckDrives() {
            DriveInfo[] listdrives = DriveInfo.GetDrives().Where(d => d.IsReady && d.DriveType == DriveType.Removable).ToArray();
            if (listdrives.Length == 0) return;
            for (int i = 0; i < listdrives.Length; i++) {
                if (drives.ContainsKey(listdrives[i])) {
                    listdrives[i].VolumeInfo
                    continue;
                }
            }
        }
    }
}
