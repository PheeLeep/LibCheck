namespace LibCheck.Forms {

    /// <summary>
    /// A class to show a <see cref="PleaseWaitDialog"/> while the process is ongoing in the background.
    /// </summary>
    internal static class PleaseWait {

        private static PleaseWaitDialog? pwd;
        /// <summary>
        /// Checks whether the process of is ongoing.
        /// </summary>
        internal static bool IsRunning { get; private set; } = false;

        /// <summary>
        /// Show the <see cref="PleaseWaitDialog"/> while the provided method is ongoing.
        /// </summary>
        /// <param name="motherForm">A mother form to use for invocation.</param>
        /// <param name="a">A provided method.</param>
        internal static void RunInPleaseWait(Form motherForm, Action a) {
            if (IsRunning) return;
            IsRunning = true;

            // This is a bunch of Tasks. lol
            Task.Factory.StartNew(() => {

                // This task separates to prevent 'hang'-like response.
                Task.Factory.StartNew(() => {
                    motherForm.Invoke(new Action(() => {
                        pwd ??= new PleaseWaitDialog();
                        pwd.CreateControl();
                        pwd.ShowDialog(motherForm);
                        pwd = null;
                    }));
                });

                Task.Delay(100).Wait(); // Wait until the dialog setup.
                // Invoke a method on the second
                try {
                    a();
                } catch (Exception ex) {
                    motherForm.Invoke(new Action(() => {
                        MessageBox.Show(motherForm, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }));
                }

                // Close the dialog.
                motherForm.Invoke(new Action(() => {
                    if (pwd != null) {
                        pwd.IsProgressCompleted = true;
                        pwd.Close();
                    }
                    IsRunning = false;
                }));
            });
        }

        /// <summary>
        /// Sets the <see cref="PleaseWaitDialog"/>'s text.
        /// </summary>
        /// <param name="text">The text to display.</param>
        internal static void SetPWDText(string text) {
            if (pwd == null || !pwd.IsHandleCreated) return;
            pwd.Invoke(new Action(() => pwd.SetFormText(text)));
        }
    }
}
