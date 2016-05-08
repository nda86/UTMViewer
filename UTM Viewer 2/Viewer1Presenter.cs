using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UTM_Viewer_2
{
   public class Viewer1Presenter
    {
        private readonly IFormViewer1 _view;
        private readonly IModelViewer1 _parser;
        public Viewer1Presenter(IFormViewer1 view, IModelViewer1 parser)
        {
            _view = view;
            _parser = parser;
            _view.getAllTTN += _view_getAllTTN;
            _view.clickCell += _view_clickCell;
        }



        private void _view_clickCell(object sender, string ip)
        {
            XmlWindow form = new XmlWindow();
            string outXML = prettyXML(_parser.getXML(ip));
            form.outXml = "<?xml version='1.0' encoding='utf - 8'?>\n" + outXML;
            form.Show();
        }

        private void _view_getAllTTN(object sender, EventArgs e)
        {
            _view.outTTN = _parser.getAllUTM(_view.ipUTM);
        }

        private string prettyXML(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception)
            {

                return xml;
            }

        }
    }
}
