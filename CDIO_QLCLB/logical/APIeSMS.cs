using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Routing;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using xNet;

namespace CDIO_QLCLB.logical
{
    class APIeSMS
    {
        const string APIKey = "1C9DA8CFE8D0483534CA0648410AFE";
        const string SecretKey = "E1D5D977AC0C5FEC629213A84CD636";

        public bool SendSMS(string phone, string message)
        {
            try
            {
                string URL = "http://rest.esms.vn/MainService.svc/json/SendMultipleMessage_V4_get?Phone=" + phone + "&Content=" + message + "&ApiKey=" + APIKey + "&SecretKey=" + SecretKey + "&SmsType=8";

                HttpRequest http = new HttpRequest();
                string html = http.Get(URL).ToString();
                return true;
            }
            catch(HttpException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public string checkMoney()
        {
            string url = "http://rest.esms.vn/MainService.svc/xml/GetBalance/" + APIKey + "/" + SecretKey;
            HttpRequest http = new HttpRequest();
            string html = http.Get(url).ToString();
            html = html.Replace("\r\n", " ");
            int startPosition = html.IndexOf("<Balance>");
            startPosition += 10;
            int EndPosition = startPosition;
            while ((char)html[EndPosition] != '<')
                EndPosition++;
            return html.Substring(startPosition - 1, (EndPosition - startPosition) + 1);
        }
    }
}
