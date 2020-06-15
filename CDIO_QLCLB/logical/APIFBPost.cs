using Mmosoft.Facebook.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.logical.APIFBPost
{
    class APIFBPost
    {
        public void postGroup(string username, string passWD,string noidung)
        {
            var fb = new FacebookClient(username, passWD);
            fb.PostToGroup(noidung, "233645317255191");
        }
    }
}
