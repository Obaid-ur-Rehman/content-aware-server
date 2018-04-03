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
    public partial class notification_view : Form
    {
        data_operator dataOperator;
        public notification_view()
        {
            InitializeComponent();
            dataOperator = new data_operator();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showAllNotifications();
        } 

        private void showAllNotifications()
        {
            dgNotifications.Rows.Clear();
            LinkedList<notification> notificationList = new LinkedList<notification>();
            notificationList = dataOperator.getAllNotifications();

            if (notificationList != null)
            {
                foreach (notification n in notificationList)
                {
                    dgNotifications.Rows.Add(n.getID(), n.getServerID(), n.getDescription(), n.getTime());
                }
            }
            else
            {
                Form1.showErrorMessage("No notification found in database");
            }
        }

        private void notification_view_Load(object sender, EventArgs e)
        {
            showAllNotifications();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgNotifications.Rows.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
