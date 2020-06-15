using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Net.Sockets;
using CDIO_QLCLB.objInProject;

namespace CDIO_QLCLB.caseData
{
    class DataTam
    {
        public class DuLieu
        {
            static public string ID;
            static public string idTemp;
            static public string diaPhuong;
            static public bool memberlist = false;
            static public DataTable dt;
            static public int ChieuNgangFormChinh;
            static public int ChieuDocFormChinh;
            static public string linkFileGoc;
            static public string kinhdo, vido, toado;
            static public string passWDSQL = "01682319448Osin", userSQL = "cdioQLCLB";
            static public Socket client;
            static public List<Member> mbList;
        }

        public class fileType
        {
            static public string excel = "Microsoft Excel Worksheet";
            static public string word = "Microsoft Word Document";
            static public string rar = "WinRAR ZIP archive";
            static public string photo = "image";
            static public string phtoshop = "Adobe Photoshop Image.19";
            static public string pdf = "PDF File";
            static public string application = "Application";
            static public string flashVieo = "Flash Video File";
            static public string wmvFile = "WMV File";
            static public string mp4Vieo = "MP4 File";
            static public string mp3Audio = "MP3 File";
            static public string text = "Text Document";
            static public string avi = "AVI File";
            static public string powerPoint = "Microsoft PowerPoint Presentation";
        }
    }
}
