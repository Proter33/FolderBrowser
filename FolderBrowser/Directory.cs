using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderBrowser {
    public partial class Directories : Form {

        private FolderBrowser mainform = null;

        public Directories(FolderBrowser m) {
            InitializeComponent();
            mainform = m;
        }

        private void button1_Click(object sender, EventArgs e) {
            String tmp = textBox1.Text;
            if (mainform.mkdir(tmp))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Abort;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                String tmp = textBox1.Text;
                if (mainform.mkdir(tmp))
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
