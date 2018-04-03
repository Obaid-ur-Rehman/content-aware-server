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
    public partial class notification_add : Form
    {
        data_operator dataOperator = null;
        public notification_add()
        {
            InitializeComponent();
            dataOperator = new data_operator();
        }

        private void notification_add_Load(object sender, EventArgs e)
        {
            LinkedList<server> serverList = new LinkedList<server>();
            serverList = dataOperator.getAllServers();
            foreach(server s in serverList)
            {
                cbServers.Items.Add(s.getName() + " " + s.getMAC());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            String MAC = getSelectedMAC();
            if(dataOperator.addNotification(MAC, tbDesc.Text))
            {
                Form1.showOkMessage("New notification has been added");
            }
            else
            {
                Form1.showErrorMessage("Failed to add new notification in database");
            }
        }

        private String getSelectedMAC()
        {
            String raw = cbServers.SelectedItem.ToString();
            String[] rawArray = raw.Split(' ');
            return rawArray[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
