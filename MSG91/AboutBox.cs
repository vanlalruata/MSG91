using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MSG91
{
    public partial class AboutBox : DevExpress.XtraEditors.XtraForm
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            try
            {
                this.textBox1.BackColor = this.BackColor;
                this.textBox1.ForeColor = this.ForeColor;
                this.label1.BackColor = this.BackColor;
                this.label2.BackColor = this.BackColor;
                this.label3.BackColor = this.BackColor;
                pictureEdit1.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}