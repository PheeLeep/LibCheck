using LibCheck.Modules;
using System.Diagnostics;

namespace LibCheck {
    internal static class Program {
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

            try {
                Application.Run(Modules.AppContext.Current);
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
            }
        }
    }
}