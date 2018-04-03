using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Content_Aware_Server
{
    class data_operator
    {
        private String conStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =content_aware_database.mdb";
        public bool addServer(String MAC, String name, String desc)
        {
            if (!isServer(MAC))
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        OleDbCommand cmd = new OleDbCommand("INSERT INTO server VALUES('" + MAC + "','" + name + "','" + desc + "')", con);
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception ess)
                {
                    return false;
                }
            }
            else
                return false;

        }

        public bool addNotification(String server_MAC, String desc)
        {
            if (isServer(server_MAC))
            {
                //Form1.showOkMessage("Server found, now adding notification");
                try
                {
                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        OleDbCommand cmd = new OleDbCommand("INSERT INTO notification(serverID, description, [time]) VALUES('" + server_MAC + "','" + desc + "','" + DateTime.Now.ToString() + "')", con);
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception ess)
                {
                    return false;
                }
            }
            return false;
        }

        public bool deleteServer(String MAC)
        {
            if (isServer(MAC))
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        OleDbCommand cmd = new OleDbCommand("DELETE FROM server WHERE MAC = '" + MAC + "'", con);
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception ess)
                {
                    return false;
                }
            }
            else
                return false;
        }

        public bool deleteNotification(int id)
        {
            if (isNotification(id))
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        OleDbCommand cmd = new OleDbCommand("DELETE FROM notification WHERE ID = " + id, con);
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception ess)
                {
                    return false;
                }
            }
            else
                return false;
        }


        private bool isServer(String MAC)
        {
            try
            {
                //Form1.showOkMessage("Requesing notifications of " + MAC + " L:" + MAC.Length);
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM server WHERE MAC='" + MAC +"'", con);
                    con.Open();
                    OleDbDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                        //Form1.showOkMessage("Returning true");
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ess)
            {
                return false;
            }
        }

        private bool isNotification(int id)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT ID FROM notification WHERE ID = " + id, con);
                    con.Open();
                    OleDbDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ess)
            {
                return false;
            }
        }

        public server getServer(String MAC)
        {
            if (isServer(MAC))
            {
                server s = new server();

                try
                {
                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        OleDbCommand cmd = new OleDbCommand("SELECT * FROM server WHERE MAC = '" + MAC + "';", con);
                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                s.setServerDetails(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                            }
                            return s;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception ys)
                {
                    return null;
                }

            }
            else
                return null;
        }

        public notification getNotification(int id)
        {
            if (isNotification(id))
            {
                notification n = new notification();

                try
                {
                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        OleDbCommand cmd = new OleDbCommand("SELECT * FROM notification WHERE ID = " + id + ";", con);
                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                n.setServerDetails(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            }
                            return n;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception s)
                {
                    return null;
                }

            }
            else
                return null;
        }


        public LinkedList<server> getAllServers()
        {
            
            LinkedList<server> serverList = new LinkedList<server>();
            try
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM server", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            server s = new server();
                            s.setServerDetails(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                            serverList.AddFirst(s);
                        }
                        return serverList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ys)
            {
                return null;
            }

        }


        public LinkedList<notification> getAllNotifications()
        {
            
            LinkedList<notification> notificationList = new LinkedList<notification>();
            try
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT ID, serverID, description, time FROM notification", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            notification n = new notification();
                            n.setServerDetails(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            notificationList.AddFirst(n);
                        }
                        return notificationList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception s)
            {
                return null;
            }

        }


        public bool updateServer(String MAC, String serverName, String description)
        {
            if (isServer(MAC))
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE server SET serverName = '" + serverName + "', description = '" + description + "' WHERE MAC = '" + MAC + "'", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            else
                return false;
        }

        public bool updateNotification(int id, String description)
        {
            if (isNotification(id))
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE notification SET description = '" + description + "' WHERE ID = " + id, con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            else
                return false;
        }


        public LinkedList<notification> getServerNotifications(String MAC)
        {

            LinkedList<notification> notificationList = new LinkedList<notification>();
            try
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT ID, serverID, description, time FROM notification WHERE serverID = '" + MAC + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            notification n = new notification();
                            n.setServerDetails(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            notificationList.AddFirst(n);
                        }
                        return notificationList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception s)
            {
                return null;
            }

        }

    }

}