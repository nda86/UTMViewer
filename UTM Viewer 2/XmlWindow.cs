using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM_Viewer_2
{
    public partial class XmlWindow : Form
    {
        public string outXml {
            set
            {
                txtXmlWindow.Text = value;
            }
        }
        public XmlWindow()
        {
            InitializeComponent();
        }

        private void txtXmlWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                MenuItem cut = new MenuItem("Cut");
                cut.Click += new EventHandler(CutAction);
                menu.MenuItems.Add(cut);

                MenuItem copy = new MenuItem("Copy");
                copy.Click += new EventHandler(CopyAction);
                menu.MenuItems.Add(copy);

                MenuItem paste = new MenuItem("Paste");
                paste.Click += new EventHandler(PasteAction);
                menu.MenuItems.Add(paste);

               // txtXmlWindow.ContextMenu = menu;
            }
        }

         void CutAction(object sender, EventArgs e)
        {
            txtXmlWindow.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetText(txtXmlWindow.SelectedText);
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtXmlWindow.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }
    }
}
