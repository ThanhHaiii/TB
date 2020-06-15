using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.logical
{
    class checkConnectServer
    {
        public bool checkConnectGoogle()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
