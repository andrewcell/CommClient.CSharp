using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace CommClient.CSharp.Library
{
    public class HTTP
    {
      

        private static HttpWebRequest req;
        public static CookieContainer cookie = new CookieContainer();
        private static Uri url;
        private static string ServerURL;
        public bool Login(string username, string password)
        {
            try
            {
                req = (HttpWebRequest)WebRequest.Create(url);
                req.UserAgent = Information.UA;
                req.Method = "POST";
                req.ContentType = "text/plain";
                req.CookieContainer = cookie;
                Stream stream = req.GetRequestStream();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byte1 = encoding.GetBytes(username);
                stream.Write(byte1, 0, byte1.Length);
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string tmp = reader.ReadToEnd();
                var a = XML.ParseXML(username, password);
                return true;
            }
            catch (Exception e)
            {
                //return "error - " + e.Message;
                return false;
            }

        }
        public bool setURL(string URL)
        {
            if (URL != "")
            {
                return false;
            }
            else
            {
                url = new Uri(URL);
                ServerURL = URL;
                return true;
            }
        }
    }
}
