using LibCheck.Forms;
using static LibCheck.Modules.WinNatives;

namespace LibCheck.Modules.Security {
    internal static class SecureDesktop {

        private static readonly object _lock = new object();
        private static nint oldDesktop = nint.Zero;
        private static nint secureDesktop = nint.Zero;
        private static DimForm? dimForm = null;
        private static DimForm? blackScreen = null;

        /// <summary>
        /// Determines whether the program is in secure desktop mode.
        /// </summary>
        internal static bool IsInSecureMode { get => secureDesktop != nint.Zero; }

        /// <summary>
        /// Forces to close a secure desktop in case of program crash.
        /// </summary>
        internal static void ForceCloseSecureMode() {
            if (CrashControl.IsSCRAMed) CloseSecureMode();
        }

        /// <summary>
        /// Invoke the supplied method to the secure desktop.
        /// </summary>
        /// <param name="action">The supplied method to be invoked in the secure desktop.</param>
        /// <exception cref="ArgumentNullException"></exception>
        internal static void EnterSecureMode(Action action) {
            lock (_lock) {
                if (action == null)
                    throw new ArgumentNullException(nameof(action));

                try {

                    StartSecureMode();

                    // Pansy besto waifu!!

                    Task.Factory.StartNew(() => {
                        SetThreadDesktop(secureDesktop);
                        dimForm?.Show();
                        action();
                    }).Wait();

                } finally {
                    CloseSecureMode();
                }
            }
        }

        /// <summary>
        /// Initiates to create a secure desktop.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        private static void StartSecureMode() {
            try {
                if (secureDesktop != nint.Zero) return;

                dimForm = new DimForm(Screenshot());
                blackScreen = new DimForm();
                blackScreen.TopMost = true;
                blackScreen.Show();
                // Get the current thread desktop, and create a new desktop.
                oldDesktop = GetThreadDesktop(GetCurrentThreadId());
                secureDesktop = CreateDesktop("LibCheckSecureDesktop", nint.Zero, nint.Zero, 0, GENERIC_ALL, nint.Zero);

                if (secureDesktop == nint.Zero)
                    throw new InvalidOperationException("Failed to create secure desktop.");

                if (!SwitchDesktop(secureDesktop))
                    throw new InvalidOperationException("Failed to switch to secure desktop.");
                // Set the secure desktop's thread.
                SetThreadDesktop(secureDesktop);
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
            }
        }

        /// <summary>
        /// Closes the secure desktop.
        /// </summary>
        private static void CloseSecureMode() {
            dimForm?.Dispose();
            dimForm = null;

            SwitchDesktop(oldDesktop);
            SetThreadDesktop(oldDesktop);
            if (secureDesktop != nint.Zero) {
                CloseDesktop(secureDesktop);
                secureDesktop = nint.Zero;
            }

            blackScreen?.Dispose();
            blackScreen = null;
        }

        /// <summary>
        /// Invokes to screenshot and dim. (Windows 7 like UAC)
        /// </summary>
        /// <returns>Returns a dimmed screenshot.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        private static Bitmap Screenshot() {
            Rectangle r = (Screen.PrimaryScreen?.Bounds) ?? throw new InvalidOperationException("No screen available!");
            Bitmap bmp = new Bitmap(r.Width, r.Height);
            using (Graphics g = Graphics.FromImage(bmp)) {
                try {
                    g.CopyFromScreen(0, 0, 0, 0, r.Size, CopyPixelOperation.SourceCopy);
                    g.Flush();
                    Color c = Color.FromArgb((int)(255 * 0.5f), Color.Black);
                    g.FillRectangle(new SolidBrush(c), 0, 0, r.Width, r.Height);
                    g.Flush();
                } catch {
                    Color c = Color.FromArgb((int)(255 * 1f), Color.Black);
                    g.FillRectangle(new SolidBrush(c), 0, 0, r.Width, r.Height);
                    g.Flush();
                }
            }
            return bmp;
        }
    }
}
