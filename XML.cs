using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Jessica
{
    class XML
    {
        public static XmlDocument doc = new XmlDocument();
        public static string XmlDoc;
        public static string WritePostResponseStr = "";
        public static string ResFileInfoStr = "";
        public static void WritePostXML(string mid, string content, string title, bool comment_status, string status)
        {
            XmlDoc = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<methodCall>\n<params>\n<_filter><![CDATA[insert]]></_filter>\n<error_return_url><![CDATA[/index.php?mid=moz&act=dispBoardWrite]]></error_return_url>\n<act><![CDATA[procBoardInsertDocument]]></act>\n<mid><![CDATA[" + mid + "]]></mid>\n<content><![CDATA[" + content + "<br><br><br><br>이 글은 Jefferson_Alpha 0.0.1 로 등록되었습니다. - " + System.Environment.OSVersion + "]]></content>\n<title><![CDATA[" + title + "]]></title>\n<_saved_doc_message><![CDATA[자동 저장된 글이 있습니다. 복구하시겠습니까? 글을 다 쓰신 후 저장하면 자동 저장 본은 사라집니다.]]></_saved_doc_message>\n<comment_status><![CDATA[ALLOW]]></comment_status>\n<status><![CDATA[PUBLIC]]></status>\n<module><![CDATA[board]]></module>\n</params>\n</methodCall>";
        }
        public static void ResFileInfo(string mid, string file_list_area_id, int editor_sequence)

        {
            ResFileInfoStr = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<methodCall>\n<params>\n<mid><![CDATA[" + mid + "]]></mid>\n<file_list_area_id><![CDATA[" + file_list_area_id + "]]></file_list_area_id>\n<editor_sequence><![CDATA[" + editor_sequence.ToString() + "]]></editor_sequence>\n<upload_target_srl><![CDATA[]]></upload_target_srl>\n<module><![CDATA[file]]></module>\n<act><![CDATA[getFileList]]></act>\n</params>\n</methodCall>";
        }
        public static void ReadWritePostResponse(string xmldata)
        {
            /*XmlDocument xmlDoc = new XmlDocument();
            Web.PostArticleResponseStr.Replace("\n", "");
            xmlDoc.Load(Web.PostArticleResponseStr);
            XmlNodeList xnl = xmlDoc.GetElementsByTagName("response");
            string b;
            foreach (XmlNode xl in xnl)
            {
                WritePostResponseStr = WritePostResponseStr + "/"+xl;
            }*/
        }
        public static string ParseXML(string username, string password)
        {
            XmlDocument xmldocs = new XmlDocument();
            XmlNode rootNode = xmldocs.CreateElement("login");
            xmldocs.AppendChild(rootNode);
            XmlNode Username = xmldocs.CreateElement("username");
            Username.InnerText = username;
            rootNode.AppendChild(Username);
            Username = xmldocs.CreateElement("password");
            Username.InnerText = password;
            rootNode.AppendChild(Username);
            return xmldocs.ToString();


        }   
           


    }
}
