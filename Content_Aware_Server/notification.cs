using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Aware_Server
{
    class notification
    {
        int id; String serverID, description, time;

        public void setServerDetails(Int32 i, String serverid, String desc, String t)
        {
            id = i;
            serverID = serverid;
            description = desc;
            time = t;
        }

        public int getID()
        {
            return id;
        }

        public String getServerID()
        {
            return serverID;
        }

        public String getDescription()
        {
            return description;
        }

        public String getTime()
        {
            return time;
        }

    }
}
