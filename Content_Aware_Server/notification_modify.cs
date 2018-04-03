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
    public partial class notification_modify : Form
    {
        private data_operator dataOperator;
        public notification_modify()
        {
            InitializeComponent();
            dataOperator = new data_operator();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            notification n = dataOperator.getNotification(Int32.Parse(tbNotiID.Text));
            if(n != null)
            {
                tbNotiDesc.Text = n.getDescription();
            }
            else
            {
                Form1.showErrorMessage("No notification");
            }
        }

        private void btnDeleteNoti_Click(object sender, EventArgs e)
        {
            if (dataOperator.deleteNotification(int.Parse(tbNotiID.Text)))
                Form1.showOkMessage("Notification has been deleted");
            else
                Form1.showErrorMessage("Failed to delete notification");
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            if (dataOperator.updateNotification(int.Parse(tbNotiID.Text), tbNotiDesc.Text))
            {
                Form1.showOkMessage("Notification has been updated");
            }
            else
            {
                Form1.showErrorMessage("Failed to update notification");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
