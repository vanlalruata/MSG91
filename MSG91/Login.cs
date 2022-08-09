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
using System.Net;
using System.IO;

namespace MSG91
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void show_char_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (show_char.Checked == true)
                {
                    api_textbox.Properties.PasswordChar = '\0';
                }
                else
                { api_textbox.Properties.PasswordChar = '●'; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally
            {
                Properties.Settings.Default.ShowChar = show_char.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            try
            {
                api_textbox.ResetText();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest request = WebRequest.Create(string.Format("http://api.msg91.com/api/validate.php?authkey={0}", api_textbox.Text));
                WebResponse response = request.GetResponse();
                status_text.Text = ((HttpWebResponse)response).StatusDescription;
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                if(responseFromServer == "Valid")
                {
                    Save();
                    if (MessageBox.Show("Verification Completed and Sucessfully Access Allowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        //Login to Main Page....   
                        //this.Close
                        this.Close();
                    }
                }
                else
                { MessageBox.Show("Cannot verify the API Key! Kindly contact your SMS Gateway Provider!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                reader.Close();
                response.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Save()
        {
            Properties.Settings.Default.APIKey = Encryption.Encrypt.EncryptString(api_textbox.Text, "msg91Program");
            Properties.Settings.Default.ShowChar = show_char.Checked;
            Properties.Settings.Default.Save();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(Properties.Settings.Default.APIKey)) { return; }
                this.api_textbox.Text = Encryption.Encrypt.DecryptString(Properties.Settings.Default.APIKey, "msg91Program");
                show_char.Checked = Properties.Settings.Default.ShowChar;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Close_Button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void api_textbox_TextChanged(object sender, EventArgs e)
        {
            if (api_textbox.Text == "")
            { Close_Button.Visible = true; }
            else
            { Close_Button.Visible = false; }
        }
    }
}