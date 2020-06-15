using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CDIO_QLCLB.XuLyAnh
{
    class MaHoaHinhAnh
    {
        public byte[] AnhSangChuoi(string duongDanFile)//Chú ý
        {
            FileStream fs;
            fs = new FileStream(duongDanFile, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        public Image ChuoiSangAnh(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms);
            return image;
        }

        public string byteToString(byte[] DuLieuVao)
        {
            return Convert.ToBase64String(DuLieuVao);
        }

        public bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            bool check = (base64String.Length % 4 == 0) && Regex.IsMatch(base64String, @"^[a-zA-Z0-9\+/]*={0,2}$", RegexOptions.None);
            if (string.IsNullOrEmpty(base64String) || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n") || !check)
                return false;
            return true;

        }
    }
}
