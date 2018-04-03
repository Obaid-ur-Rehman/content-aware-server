using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Content_Aware_Server
{
    public partial class server_view : Form
    {
        data_operator dataOperator = null;
        public server_view()
        {
            InitializeComponent();
            dataOperator = new data_operator();
        }

        private void server_view_Load(object sender, EventArgs e)
        {
            showAllServers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgServers.Rows.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showAllServers();
        }

        private void showAllServers()
        {
            dgServers.Rows.Clear();
            LinkedList<server> serversList = new LinkedList<server>();
            serversList = dataOperator.getAllServers();

            if (serversList != null)
            {
                foreach (server s in serversList)
                {
                    dgServers.Rows.Add(s.getMAC(), s.getName(), s.getDescription());
                }
            }
            else
            {
                Form1.showErrorMessage("No server found in database");
            }
        }
    }
}
