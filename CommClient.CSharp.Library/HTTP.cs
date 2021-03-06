﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows;

namespace CommClient.CSharp.Library
{
    public class HTTP
    {
        private static HttpWebRequest req;
        public static CookieContainer cookie = new CookieContainer();
        private static Uri url;
        private string UA = "E/0.0.0";
        public bool Login(string username, string password)
        {
            Information cl = new Information();   
            try
            {
                var ba = "";
                if (cl.XMLUse == true)
                {
                    ba = XML.ParseXML(username, password);
                }
                else
                {
                    ba = XML.ParseXML(username, password);
                }


                Send(ba);
               
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show( "error - " + e.Message);
                return false;
            }

        }
        public string getStyle()
        {
            return Send("<data>GetServerStyle</data>");

        }
        public string Send(string data)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                req = (HttpWebRequest)WebRequest.Create(url);
                req.UserAgent = UA;
                req.Method = "POST";
                req.ContentType = "text/plain";
                req.CookieContainer = cookie;
                req.UseDefaultCredentials = true;
                req.KeepAlive = false;
                data = data + "<EOF>";
                Stream stream = req.GetRequestStream();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byte1 = encoding.GetBytes(data);
                stream.Write(byte1, 0, byte1.Length);
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string tmp = reader.ReadToEnd();
                return tmp;
            }
            catch (Exception e)
            {
                return e.Message;

            }
        }
        public bool setURL(string URL, bool secure)
        {
            if (URL == "")
            {
                return false;
            }
            else if (secure == false)
            {
                url = new Uri("http://"+URL);
                return true;
            }
            else if (secure == true)
            {
                url = new Uri("https://" + URL);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
