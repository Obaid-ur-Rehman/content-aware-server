using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Aware_Server
{
    public class client
    {
        private String ip, serverMAC;
        
        public client(String ipAddress, String MACAddress)
        {
            ip = ipAddress;
            serverMAC = MACAddress;
        }

        public String getIP()
        {
            return ip;
        }

        public String getServer()
        {
            return serverMAC;
        }
    }
}
