using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UTM_Viewer_2
{

    public interface IModelResend
    {
        string getFormBRegInfo(string ip);
    }
    class Resend : IModelResend
    {
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
    }
}
