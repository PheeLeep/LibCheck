using LibCheck.Forms;
using LibCheck.Modules.Security;
using System.Reflection;
using System.Text;

namespace LibCheck.Modules {

    /// <summary>
    /// A class that is use to crash a program when there is a fatal error occurred.
    /// </summary>
    internal static class CrashControl {

        /// <summary>
        /// Indicates whether the program is crashed.
        /// </summary>
        internal static bool IsSCRAMed { get; private set; } = false;

        /// <summary>
        /// Initiate a crash to the program.
        /// </summary>
        /// <param name="ex">A fatal <see cref="Exception"/> value.</param>
        /// <remarks>
        /// It is recommended to use this method if there is a code that can cause a fatal error
        /// during a runtime. Other scenarios like password mismatch should show a message and
        /// run as normal.
        /// </remarks>
        internal static void SCRAM(Exception ex) {
            if (ex == null || IsSCRAMed) return;
            IsSCRAMed = true;

            // Force all program to close.
            foreach (Form form in Application.OpenForms) {
                try {
                    if (form is DimForm) continue;
                    form.Dispose();
                } catch {
                    // Ignore
                }
            }
            if (SecureDesktop.IsInSecureMode)
                SecureDesktop.ForceCloseSecureMode();

            StringBuilder sb = new StringBuilder();

            CreateStackTrace(sb, ex);
            Logger.Log(Logger.LogEnums.Fatal, $"CRASHED!!! {ex.Message}");
            Logger.Unload();
            new ErrorDialog(ex, sb, SaveFile(sb)).ShowDialog();

            Environment.Exit(ex.HResult);

            while (true)
                Thread.Sleep(1000); // Permanent hang.

        }

        /// <summary>
        /// Writes the stack trace to the <see cref="StringBuilder"/>.
        /// </summary>
        /// <param name="sb">A current <see cref="StringBuilder"/> value.</param>
        /// <param name="ex">A fatal <see cref="Exception"/> value.</param>
        private static void CreateStackTrace(StringBuilder sb, Exception ex) {
            sb.AppendLine(new string('=', 20));
            sb.AppendLine("     Crash Occurred!");
            sb.AppendLine($"     Date Occurred: {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}");
            sb.AppendLine();
            sb.AppendLine($"     OS Version: {Environment.OSVersion.Version}");
            sb.AppendLine();
            sb.AppendLine($"     LibCheck Version: {Assembly.GetExecutingAssembly().GetName().Version}");
            sb.AppendLine($"     CLR Version: {Environment.Version}");
            sb.AppendLine(new string('=', 20));
            sb.AppendLine();
            sb.AppendLine($"Error: ({ex.GetType().Name}) {ex.Message}");
            sb.AppendLine();

            if (!string.IsNullOrEmpty(ex.StackTrace)) {
                sb.AppendLine("--- Begin Stack Tracing:\n");
                sb.AppendLine($"Main Stack Trace:\n{ex.StackTrace}");

                Exception? exInner = ex.InnerException;
                while (exInner != null) {
                    sb.AppendLine($"Stack Trace:\n{exInner.StackTrace}");
                    exInner = exInner.InnerException;
                }
                sb.AppendLine("\n--- End of Stack Tracing.");
            } else {
                sb.AppendLine("WARNING! Unable to get stack trace." +
                              " The error possibly occurred outside the scope. (Example: An error occurred inside the thread.)");
            }

            sb.AppendLine($"Date Generated {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}");
        }

        /// <summary>
        /// Saves the crash info to the file.
        /// </summary>
        /// <param name="sb">A current <see cref="StringBuilder"/> value.</param>
        /// <returns>Returns true if the save file succeed; Otherwise, false.</returns>
        private static bool SaveFile(StringBuilder sb) {
            try {
                if (!EnvVars.CrashDirectory.Exists)
                    EnvVars.CrashDirectory.Create();
                string pathCrash = Path.Combine(EnvVars.CrashDirectory.FullName, $"crash_{DateTime.Now:ddMMyyyy-hhmmss}.txt");

                using (StreamWriter writer = new StreamWriter(pathCrash)) {
                    writer.Write(sb.ToString());
                    writer.Flush();
                }
                return true;
            } catch {
                return false;
            }
        }
    }
}
