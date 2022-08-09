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
using System.Web;
using System.Net;
using System.IO;

namespace MSG91
{
    public partial class SendSMS : DevExpress.XtraEditors.XtraForm
    {
        private bool schedule = false;

        public SendSMS()
        {
            InitializeComponent();
        }

        private void msg_textbox_TextChanged(object sender, EventArgs e)
        {
            int i = msg_textbox.Text.Length;
            if(i < 161)
            {
                word_count.Text = i.ToString() + " / 1";
            }
            else if (i < 307)
            {
                word_count.Text = i.ToString() + " / 2";
            }
            else if (i < 461)
            {
                word_count.Text = i.ToString() + " / 3";
            }
            else if (i < 613)
            {
                word_count.Text = i.ToString() + " / 4";
            }
            else
            {
                word_count.Text = i.ToString() + " / MMS";
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ClearAll()
        {
            to_textbox.ResetText();
            //msg_textbox.ResetText();
            schedule_date.Enabled = false;
            schedule_time.Enabled = false;

        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Do you want to schedule SMS delivery?", "Wait", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    schedule_date.Enabled = true;
                    schedule_time.Enabled = true;
                    schedule = true;
                }
                else
                {
                    schedule_date.Enabled = false;
                    schedule_time.Enabled = false;
                    schedule = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {
                //Encode Message
                string message = HttpUtility.UrlEncode(msg_textbox.Text);

                string schedule_timer = "2015-12-12 06:00:00";

                //Prepare post parameters
                StringBuilder sbPostData = new StringBuilder();
                sbPostData.AppendFormat("authkey={0}", Encryption.Encrypt.DecryptString(Properties.Settings.Default.APIKey, "msg91Program"));
                sbPostData.AppendFormat("&mobiles={0}", to_textbox.Text);
                sbPostData.AppendFormat("&message={0}", message);
                sbPostData.AppendFormat("&sender={0}", sender_id.Text);
                sbPostData.AppendFormat("&route={0}", route.Text);

                if (schedule == true)
                {
                    //Schedule is True
                    if(schedule_time.EditValue != null || schedule_date.EditValue != null)
                    {
                        schedule_timer = string.Format("{0} {1}", schedule_date.Text, schedule_time.Text);
                        //MessageBox.Show(schedule_timer);
                        sbPostData.AppendFormat("&schtime={0}", schedule_timer);
                    }                    
                }


                //Call Send SMS API
                string sendSMSUri = "http://api.msg91.com/sendhttp.php";
                //Create HTTPWebrequest
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(sendSMSUri);
                //Prepare and Add URL Encoded data
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = encoding.GetBytes(sbPostData.ToString());
                //Specify post method
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                //Get the response
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseString = reader.ReadToEnd();

                if(MessageBox.Show(string.Format("Successfully Sent! \nTransaction ID : {0} \n Do you want to copy the transaction id on you clipboard?", responseString), "Copy it?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clipboard.SetText(responseString, TextDataFormat.Text);
                }

                ClearAll();

                //Close the response
                reader.Close();
                response.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SendSMS_Load(object sender, EventArgs e)
        {

        }
    }
}