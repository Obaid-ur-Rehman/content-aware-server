using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Content_Aware_Server
{
    public partial class Form1 : Form
    {

        Thread listenerThread = null;
        public TcpListener listener = null;
        int serverPort = 12345;
        public static LinkedList<client> clientsList = null;
        public static String noti = "";
        public Form1()
        {
            InitializeComponent();
            
            clientsList = new LinkedList<client>();
            listenerThread = new Thread(startServer);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }

        private void startServer()
        {
            listener = new TcpListener(IPAddress.Parse("0.0.0.0"), serverPort);
            listener.Start();
            while (true)
            {
                TcpClient s = listener.AcceptTcpClient();
                handleClient thisClient = new handleClient(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void showForm(Form f)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new notification_view());
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new notification_add());
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new notification_modify());
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showForm(new server_view());
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showForm(new server_add());
        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showForm(new server_modify());
        }


        public static void showErrorMessage(String msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showOkMessage(String msg)
        {
            MessageBox.Show(msg, "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }

    public class handleClient
    {
        bool added = false;
        client c = null;
        data_operator dataOperator;
        TcpClient cClient = null;
        String prevNoti = null;
        public handleClient(TcpClient clientSocket)
        {
            dataOperator = new data_operator();
            cClient = clientSocket;
            Thread clientThread = new Thread(listenToClient);
            clientThread.IsBackground = true;
            clientThread.Start();
        }

        private void listenToClient()
        {
            int size = 0;
            String packet = "";
            NetworkStream rcvData = cClient.GetStream();
            byte[] buffer = new byte[256];
            size = rcvData.Read(buffer, 0, buffer.Length);
            
            while(size > -1)
            {
                
                packet = ASCIIEncoding.ASCII.GetString(buffer, 0, size);
                String[] request = packet.Split(',');

                if(request[0] == "req") //req,mac
                {
                    String routerMAC = request[1];
                    if (dataOperator.getServer(routerMAC) != null)
                    {
                        if (!added)
                        {
                            String clientIP = (cClient.Client.RemoteEndPoint as IPEndPoint).Address.ToString();
                            
                            addClient(routerMAC, clientIP);
                            added = true;
                        }

                        LinkedList<notification> notiList = dataOperator.getServerNotifications(request[1]);
                        String serverName = dataOperator.getServer(request[1]).getName();
                        if(notiList != null)
                        foreach(notification n in notiList)
                        {
                            sendMessage("noti,"+ serverName + "," + n.getDescription() + "  " + n.getTime() + Environment.NewLine);
                        }
                    }
                }
                size = rcvData.Read(buffer, 0, buffer.Length);
            }
            //MessageBox.Show("Client disconnected");

            
            
        }

        public void addClient(String routerMAC, String IP)
        {
            client c = new client(IP, routerMAC);
            Form1.clientsList.AddFirst(c);
        }

        public bool isAuth(String uid)
        {
            return false;
            
        }

        private void sendMessage(String msg)
        {
            try
            {
                NetworkStream ns = cClient.GetStream();
                ns.Write(ASCIIEncoding.ASCII.GetBytes(msg), 0, msg.Length);
                
            }
            catch (Exception e) { }
        }

        public void respondClient(TcpClient cClient, String info)
        {
            
        }



        private bool isConnected(String uid)
        {
            return false;
        }
    }

}
