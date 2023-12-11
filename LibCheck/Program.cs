using LibCheck.Forms;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using System.Diagnostics;

namespace LibCheck
{
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

                Logger.Initialize();
                Credentials.Initialize();
                Credentials.LoginAsLibrarian();

                if (Credentials.LoggedIn) {
                    if (Modules.Database.Connection == null)
                        throw new InvalidOperationException("Database is not connected.");
                    Application.Run(new MainForm());
                }
                
                Modules.Database.Unload();
                Credentials.Unload();
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
            }
        }
    }
}