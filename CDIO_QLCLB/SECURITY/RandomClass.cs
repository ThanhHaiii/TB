using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.SECURITY
{
    class RandomClass
    {
        public string RandomText(int SoLuongKyTu)
        {
            string strString = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789";
            Random random = new Random();
            int randomCharIndex = 0;
            char randomChar;
            string actcode = "";
            for (int i = 0; i < SoLuongKyTu; i++)
            {
                randomCharIndex = random.Next(0, strString.Length);
                randomChar = strString[randomCharIndex];
                actcode += Convert.ToString(randomChar);
            }
            return actcode;
        }

        public int randomNumber(int BatDau, int KetThuc){
            Random rd = new Random();
            return rd.Next(BatDau, KetThuc);
        }
    }
}
