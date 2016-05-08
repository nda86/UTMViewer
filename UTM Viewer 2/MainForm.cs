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

    public interface IMainForm
    {
        event EventHandler getAllTTN;
        event EventHandler getFormBRegInfo;
        event EventHandler<string> clickCell;
        List<OutTicket> outTTN { set; }
        string outFormBRegInfo { set; }
        string ipUTM { get; } 
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            btnGetAllTTN.Click += BtnGetAllTTN_Click;
            tableTicket.CellDoubleClick += TableTicket_CellDoubleClick;
            btnGetFormBRegInfo.Click += BtnGetFormBRegInfo_Click;
            //tableTicket.CellDoubleClick += new EventHandler((s, e) => lnkSynEvent_Click(s, e, your_parameter))
        }

        private void BtnGetFormBRegInfo_Click(object sender, EventArgs e)
        {
            if (getFormBRegInfo != null) getFormBRegInfo(this, EventArgs.Empty);
        }

        private void TableTicket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string ip = tableTicket.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (clickCell != null) clickCell(this, ip);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void BtnGetAllTTN_Click(object sender, EventArgs e)
        {
            if (getAllTTN != null) getAllTTN(this, EventArgs.Empty);
        }

        public string ipUTM
        {
            get
            {
                return txtIPUTM.Text;
            }
        }

        public List<OutTicket> outTTN
        {
            set
            {
                if (value != null)
                {
                    foreach (OutTicket ticket in value)
                    {
                        tableTicket.Rows.Add(ticket.ip, ticket.numberPP, ticket.date, ticket.type, ticket.ttn, ticket.operationName, ticket.operationResult, ticket.comment);
                    }
                    tableTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //tableTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    colComment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }



            }
        }

        public string outFormBRegInfo
        {
            set
            {
                txtFormBRegInfo.Text = value;
            }
        }

        public event EventHandler getAllTTN;
        public event EventHandler<string> clickCell;
        public event EventHandler getFormBRegInfo;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            tableTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //tableTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            colComment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }

    public class MyEventArgs: EventArgs
    {
        public string _cell;
        public MyEventArgs(string cell)
        {
            _cell = cell;
        }
    }
}
