using static LibCheck.Modules.WinNatives;

namespace LibCheck.Modules {
    internal static class SecureDesktop {

        private static readonly object _lock = new object();

        /// <summary>
        /// Invoke the supplied method to the secure desktop.
        /// </summary>
        /// <param name="action">The supplied method to be invoked in the secure desktop.</param>
        /// <exception cref="ArgumentNullException"></exception>
        internal static void EnterSecureMode(Action action) {
            lock (_lock) {
                if (action == null)
                    throw new ArgumentNullException(nameof(action));

                IntPtr oldDesktop = IntPtr.Zero;
                IntPtr secureDesktop = IntPtr.Zero;
                Form? dimForm = null;

                // Pansy besto waifu!!

                try {
                    dimForm = new Forms.DimForm(Screenshot());

                    // Get the current thread desktop, and create a new desktop.
                    oldDesktop = GetThreadDesktop(GetCurrentThreadId());
                    secureDesktop = CreateDesktop("LibCheckSecureDesktop", IntPtr.Zero, IntPtr.Zero, 0, GENERIC_ALL, IntPtr.Zero);

                    if (secureDesktop == IntPtr.Zero)
                        throw new Exception("Failed to create secure desktop.");

                    if (!SwitchDesktop(secureDesktop))
                        throw new Exception("Failed to switch to secure desktop.");

                    // Set the secure desktop's thread.
                    SetThreadDesktop(secureDesktop);

                    // Create a separate task.
                    Task.Factory.StartNew(() => {
                        SetThreadDesktop(secureDesktop);
                        dimForm.Show();
                        action();
                    }).Wait();

                } catch {
                    throw; 
                } finally {
                    dimForm?.Dispose();
                    SwitchDesktop(oldDesktop);
                    SetThreadDesktop(oldDesktop);
                    if (secureDesktop != IntPtr.Zero)
                        CloseDesktop(secureDesktop);
                }
            }
        }

        private static Bitmap Screenshot() {
            Rectangle r = (Screen.PrimaryScreen?.Bounds) ?? throw new InvalidOperationException("No screen available!");
            Bitmap bmp = new Bitmap(r.Width, r.Height);
            using (Graphics g = Graphics.FromImage(bmp)) {
                g.CopyFromScreen(0, 0, 0, 0, r.Size, CopyPixelOperation.SourceCopy);
                g.Flush();
                Color c = Color.FromArgb((int)(255 * 0.5f), Color.Black);
                g.FillRectangle(new SolidBrush(c), 0, 0, r.Width, r.Height);
                g.Flush();
            }
            return bmp;
        }
    }
}
