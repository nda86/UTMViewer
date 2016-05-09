using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;
using System.IO;


namespace UTM_Viewer_2
{

    public interface IModelResend
    {
        string getFormBRegInfo(string ip);
        string resendTTN(string IP, string fsrar_id, string[] listOfTTN);
    }
    class Resend : IModelResend
    {

        private string resendQuery = "<?xml version='1.0' encoding='UTF-8'?>"
 + "<ns:Documents xmlns:ns='http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01' xmlns:qp='http://fsrar.ru/WEGAIS/QueryParameters' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' Version='1.0'>"
 + "<ns:Owner>"
 +     "<ns:FSRAR_ID>000000000000</ns:FSRAR_ID>"
 +  "</ns:Owner>"
 + "<ns:Document>"
 +    "<ns:QueryResendDoc>"
 +        "<qp:Parameters>"
 +           "<qp:Parameter>"
 +              "<qp:Name>WBREGID</qp:Name>"
 +              "<qp:Value>TTN-0000000000</qp:Value>"
 +           "</qp:Parameter>"
 +        "</qp:Parameters>"
 +     "</ns:QueryResendDoc>"
 +  "</ns:Document>"
 + "</ns:Documents>";


        public string getFormBRegInfo(string ip)
        {
            try
            {
                XmlDocument tmpXml = new XmlDocument();
                XmlDocument xml = new XmlDocument();
                xml.Load("http://" + ip + "/opt/out");
                XmlNodeList list = xml.SelectNodes("//url");
                List<OutTicket> outTicket = new List<OutTicket>();
                XmlNamespaceManager manager = new XmlNamespaceManager(xml.NameTable);
                manager.AddNamespace("tc", "http://fsrar.ru/WEGAIS/Ticket");
                manager.AddNamespace("ns", "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01");
                manager.AddNamespace("wbr", "http://fsrar.ru/WEGAIS/TTNInformBReg");

                string result = null;

                foreach (XmlNode url in list)
                {
                    tmpXml.Load(url.InnerText);
                    if (tmpXml.SelectSingleNode("//ns:TTNInformBReg", manager) != null)
                    {

                        result = result + tmpXml.SelectSingleNode("//wbr:WBRegId", manager).InnerText + "\n";
                    }

                }

                return result;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }

        }

        public string resendTTN(string IP, string fsrar_id, string[] listOfTTN)
        {
            XmlDocument res = new XmlDocument();
            for (int i = 0; i < listOfTTN.Length; i++)
            {
                res.LoadXml(resendQuery);
                XmlNamespaceManager manager = new XmlNamespaceManager(res.NameTable);
                manager.AddNamespace("ns", "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01");
                manager.AddNamespace("qp", "http://fsrar.ru/WEGAIS/QueryParameters");

                res.SelectSingleNode("//ns:FSRAR_ID", manager).InnerText = fsrar_id;
                res.SelectSingleNode("//qp:Value", manager).InnerText = listOfTTN[i];
                res.Save("QueryResendDoc.xml");
                string pathXml = Path.Combine(Directory.GetCurrentDirectory(), "QueryResendDoc.xml");


                string batText = "curl.exe -F 'xml_file=@\"" + pathXml + "\"' http://" + IP + "/opt/in/QueryResendDoc";
                StreamWriter batFile = new StreamWriter("QueryResendDoc.bat");
                batFile.WriteLine(batText);
                batFile.WriteLine("pause");

                batFile.Close();
                string pathBat = Path.Combine(Directory.GetCurrentDirectory(), "QueryResendDoc.bat");
                Process.Start(pathBat);

               
                //File.Delete("QueryResendDoc.xml");
                //File.Delete("QueryResendDoc.bat");
            }


            return res.OuterXml;
        }
    }
}
