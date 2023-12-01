using LibCheck.Modules;

namespace LibCheck {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try {
                Database.Load();
                if (!Database.IsConnected)
                    throw new InvalidOperationException("Database aren't connected.");

                Credentials.Initialize();
                if (!Credentials.LoginAsLibrarian())
                    return;

            } catch (Exception ex) {
                Console.WriteLine($"Crashed! ({ex.Message})");
                MessageBox.Show(null, "This software is experiencing fatal error and it needs to close. We're sorry for inconvenience." +
                                $"\n\nCause: {ex.Message}", "Crashed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            // Uncomment when a new Form was created.
            // Application.Run(new );
        }
    }
}