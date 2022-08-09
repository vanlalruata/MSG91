using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;
using System.Diagnostics;

namespace MSG91
{
    public partial class DashBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SendSMS sm = null;


        public DashBoard()
        {
            InitializeComponent();
        }

        private void skinRibbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Theme = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName.ToString();                
                Properties.Settings.Default.Save();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            try
            {
                UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.Theme.ToString());
                this.Location = Properties.Settings.Default.myLocation;
                this.Size = Properties.Settings.Default.mySize;

                //Load Check
                Login lg = new Login();
                lg.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void skinRibbonGalleryBarItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Theme = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName.ToString();
                Properties.Settings.Default.Save();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Theme = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName.ToString();
                Properties.Settings.Default.mySize = this.Size;
                Properties.Settings.Default.myLocation = this.Location;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private Form ShowOrActiveForm(Form form, Type t)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }
            return form;
        }

        private void send_SMS_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {                
                sm = ShowOrActiveForm(sm, typeof(SendSMS)) as SendSMS;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void about_button_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                AboutBox ab = new AboutBox();
                ab.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void help_button_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Process.Start("http://api.msg91.com/apidoc/textsms/error-code-text-sms.php");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}