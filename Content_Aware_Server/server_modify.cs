using System;
using System.Windows.Forms;

namespace Content_Aware_Server
{
    public partial class server_modify : Form
    {
        data_operator dataOperator;
        public server_modify()
        {
            InitializeComponent();
            dataOperator = new data_operator();
        }

        private void server_modify_Load(object sender, EventArgs e)
        {
            gbServerDetails.Hide();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            server s = new server();
            s = dataOperator.getServer(tbServerMAC.Text);
            if (s != null)
            {
                gbServerDetails.Show();
                tbServerName.Text = s.getName();
                tbServerDesc.Text = s.getDescription();
            }
            else
                Form1.showErrorMessage("Server with the specified MAC Address does not found");
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            if(dataOperator.updateServer(tbServerMAC.Text, tbServerName.Text, tbServerDesc.Text))
            {
                Form1.showOkMessage("Server detail has been updated");
            }
            else
            {
                Form1.showErrorMessage("Failed to update server details");
            }
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            if(dataOperator.deleteServer(tbServerMAC.Text))
            {
                Form1.showOkMessage("Server has been deleted");
                tbServerDesc.Clear();
                tbServerMAC.Clear();
                tbServerName.Clear();
            }
            else
            {
                Form1.showErrorMessage("Could not remove the server");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
