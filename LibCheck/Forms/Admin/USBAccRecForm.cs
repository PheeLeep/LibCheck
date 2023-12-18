using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibCheck.Forms.Admin {
    public partial class USBAccRecForm : Form {
        public USBAccRecForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (new RegisterDriveDialog().ShowDialog(this) == DialogResult.OK) {
                Modules.Security.USBAccRec.Unload();
                Modules.Security.USBAccRec.Load();
            }
        }
    }
}
