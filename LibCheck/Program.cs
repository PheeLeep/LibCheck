using LibCheck.Modules;
using System.Diagnostics;

namespace LibCheck {

#pragma warning disable S1215
    internal static class Program {
        private static bool _stopProc = false;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            /// Make it a single executable instance.
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                return;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Thread t = new Thread(() => {
                while (!_stopProc) {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    Thread.Sleep(1000);
                }
            });

            if (Environment.OSVersion.Version.Major >= 6)
                WinNatives.SetProcessDPIAware();

            try {
                t.Start();
                Application.Run(Modules.AppContext.Current);
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
            }
            _stopProc = true;
        }
    }
}