using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.Script.Serialization;
using System.Data;

namespace MSG91
{
    class ContactList
    {
        string[,] contact = new string[10, 10];

        public string[,] ContactGroup()
        {

            StringBuilder sbPostData = new StringBuilder();
            sbPostData.AppendFormat("authkey={0}", Encryption.Encrypt.DecryptString(Properties.Settings.Default.APIKey, "msg91Program"));


            //Call Send SMS API
            string sendSMSUri = "http://api.msg91.com/api/list_group.php?";
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

            Split(responseString);

            //Close the response
            reader.Close();
            response.Close();

            return contact;

        }

        private void Split(string x)
        {
            try
            {
                DataSet cityds = new DataSet();

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                List<RootObject> ListAnswers = serializer.Deserialize<List<RootObject>>(x);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public class RootObject
        {
            public string id { get; set; }
            public string name { get; set; }
            public int count { get; set; }
        }
    }
}
