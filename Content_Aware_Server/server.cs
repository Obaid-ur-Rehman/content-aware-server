using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Aware_Server
{
    class server
    {
        private String MAC, name, description;

        public void setServerDetails(String mac, String n, String desc)
        {
            MAC = mac;
            name = n;
            description = desc;
        }

        public String getMAC()
        {
            return MAC;
        }

        public String getName()
        {
            return name;
        }

        public String getDescription()
        {
            return description;
        }
    }
}
