using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace UTM_Viewer_2
{
    public interface IModelViewer1
    {       
        List<OutTicket> getAllUTM(string ip);
        string getXML(string ip);
    }
    public class Viewer1 : IModelViewer1
    {

        public List<OutTicket> getAllUTM(string ip)
        {
            try
            {
                int i = 0;
                int y = 0;
                XmlDocument tmpXml = new XmlDocument();
                XmlDocument xml = new XmlDocument();
                xml.Load("http://" + ip + "/opt/out");
                XmlNodeList list = xml.SelectNodes("//url");
                List<OutTicket> outTicket = new List<OutTicket>();
                XmlNamespaceManager manager = new XmlNamespaceManager(xml.NameTable);
                manager.AddNamespace("tc", "http://fsrar.ru/WEGAIS/Ticket");
                manager.AddNamespace("ns", "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01");
                manager.AddNamespace("wbr", "http://fsrar.ru/WEGAIS/TTNInformBReg");


                foreach (XmlNode url in list)
                {
                    tmpXml.Load(url.InnerText);
                    if (tmpXml.SelectSingleNode("//ns:Ticket", manager) != null)
                    {
                        i++;
                        OutTicket tmpTicket = new OutTicket();
                        tmpTicket.numberPP = i;
                        tmpTicket.date = (tmpXml.SelectSingleNode("//tc:OperationDate", manager) != null) ? tmpXml.SelectSingleNode("//tc:OperationDate", manager).InnerText : "";
                        tmpTicket.type = (tmpXml.SelectSingleNode("//tc:DocType", manager) != null) ? tmpXml.SelectSingleNode("//tc:DocType", manager).InnerText : "";
                        tmpTicket.ttn = (tmpXml.SelectSingleNode("//tc:RegID", manager) != null) ? tmpXml.SelectSingleNode("//tc:RegID", manager).InnerText : "";
                        tmpTicket.operationName = (tmpXml.SelectSingleNode("//tc:OperationName", manager) != null) ? tmpXml.SelectSingleNode("//tc:OperationName", manager).InnerText : "";
                        tmpTicket.operationResult = (tmpXml.SelectSingleNode("//tc:OperationResult/tc:OperationResult", manager) != null) ? tmpXml.SelectSingleNode("//tc:OperationResult/tc:OperationResult", manager).InnerText : "";
                        tmpTicket.comment = (tmpXml.SelectSingleNode("//tc:OperationComment", manager) != null) ? tmpXml.SelectSingleNode("//tc:OperationComment", manager).InnerText : "";
                        tmpTicket.ip = url.InnerText;
                        outTicket.Add(tmpTicket);
                    }

                    if (tmpXml.SelectSingleNode("//ns:TTNInformBReg", manager) != null)
                    {
                        i++;

                        OutTicket tmpTicket = new OutTicket();
                        tmpTicket.numberPP = i;
                        tmpTicket.date = (tmpXml.SelectSingleNode("//wbr:WBRegId", manager) != null) ? tmpXml.SelectSingleNode("//wbr:WBRegId", manager).InnerText : "";
                        tmpTicket.date = (tmpXml.SelectSingleNode("//wbr:WBDate", manager) != null) ? tmpXml.SelectSingleNode("/wbr:WBDate", manager).InnerText : "";
                        tmpTicket.ttn = (tmpXml.SelectSingleNode("//tc:RegID", manager) != null) ? tmpXml.SelectSingleNode("//tc:RegID", manager).InnerText : "";
                        tmpTicket.operationName = (tmpXml.SelectSingleNode("//tc:OperationName", manager) != null) ? tmpXml.SelectSingleNode("//tc:OperationName", manager).InnerText : "";
                        tmpTicket.operationResult = (tmpXml.SelectSingleNode("//tc:OperationResult/tc:OperationResult", manager) != null) ? tmpXml.SelectSingleNode("//tc:OperationResult/tc:OperationResult", manager).InnerText : "";
                        tmpTicket.comment = (tmpXml.SelectSingleNode("//tc:OperationComment", manager) != null) ? tmpXml.SelectSingleNode("//tc:OperationComment", manager).InnerText : "";
                        tmpTicket.ip = url.InnerText;
                        outTicket.Add(tmpTicket);
                    }
                    //y++;
                    //if (y > 5)
                    //{
                    //    break;
                    //}
                }

                return outTicket;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }

        

        public string getXML(string ip)
        {
            XmlDocument xml = new XmlDocument();
            //string xmlOut = "";
            xml.Load(ip);
            //xml.Save(xmlOut);
            return xml.OuterXml;
        }
    }

    public class OutTicket
    {
        public int numberPP { get; set; }
        public string date { get; set; }
        public string type { get; set; }
        public string ttn { get; set; }
        public string operationName { get; set; }
        public string operationResult { get; set; }
        public string comment { get; set; }
        public string ip { get; set; }
    }
}
