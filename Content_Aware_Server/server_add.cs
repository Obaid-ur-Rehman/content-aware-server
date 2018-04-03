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
    public partial class server_add : Form
    {
        data_operator dataOperator;
        public server_add()
        {
            InitializeComponent();
            dataOperator = new data_operator();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            if(txtMACAddress.Text.Length > 0)
            {
                if (dataOperator.addServer(txtMACAddress.Text, txtServerName.Text, txtServerDesc.Text))
                    MessageBox.Show("Department has been added");
                else
                    MessageBox.Show("Could not add server","Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please enter the MAC Address of the router", "MAC address needed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void server_add_Load(object sender, EventArgs e)
        {

        }
    }
}
