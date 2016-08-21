using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CommClient.CSharp.Library
{
    class XML
    {

        public static string ParseXML(string username, string password)
        {

            using (StringWriter builder = new StringWriter())
            {
                using (XmlTextWriter xml = new XmlTextWriter(builder))
                {
                    xml.WriteStartDocument();
                    xml.WriteStartElement("login");
                    xml.WriteWhitespace("\n");
                    
                    xml.WriteElementString("username",username);
                    
                    xml.WriteElementString("password",password);
                    xml.WriteEndElement();
                }
                return builder.ToString();

            }
            //   XmlWriter writer = XmlWriter.Create(builder);
            XmlDocument xmldocs = new XmlDocument();
            XmlNode rootNode = xmldocs.CreateElement("login");
            xmldocs.AppendChild(rootNode);
            XmlNode Username = xmldocs.CreateElement("username");
            Username.InnerText = username;
            rootNode.AppendChild(Username);
            Username = xmldocs.CreateElement("password");
            Username.InnerText = password;
            rootNode.AppendChild(Username);
           // xmldocs.WriteTo(writer);
            


        }   
           


    }
}
