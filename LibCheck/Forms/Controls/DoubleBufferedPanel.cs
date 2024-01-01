namespace LibCheck.Forms.Controls {

    // Code Cited to: https://stackoverflow.com/a/21873877
    public partial class DoubleBufferedPanel : Panel {
        public DoubleBufferedPanel() : base() {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
