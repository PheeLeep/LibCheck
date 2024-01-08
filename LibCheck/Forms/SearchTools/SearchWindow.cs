namespace LibCheck.Forms.SearchTools {
    public partial class SearchWindow : Form {
        internal delegate void SearchWhereConditionDelegate(string whereCond);

        internal event SearchWhereConditionDelegate? SearchWhereCondition;

        public SearchWindow() {
            InitializeComponent();
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

        internal void PassOffWhereCond(string whereCond) {
            SearchWhereCondition?.Invoke(whereCond);
        }
    }
}
