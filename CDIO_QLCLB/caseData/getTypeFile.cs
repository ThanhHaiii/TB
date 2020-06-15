using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.caseData
{
    class getTypeFile
    {
        public string getType(string duoi)
        {
            string typeFile = "";
            switch (duoi)
            {
                case "xls":
                case "xlsx":
                case "xlsm":
                case "xlsb":
                case "xltx":
                case "xltm":
                case "xlt":
                case "xlam":
                case "xla":
                case "xlw":
                case "XLR":
                case "XLS":
                case "XLSX":
                case "XLSM":
                case "XLSB":
                case "XLST":
                case "XLTM":
                case "XLT":
                case "XLAM":
                case "XLA":
                case "XLWW": typeFile = caseData.DataTam.fileType.excel; break;
                case "doc":
                case "docm":
                case "docx":
                case "dot":
                case "dotx":
                case "DOC":
                case "DOCM":
                case "DOCX":
                case "DOT":
                case "DOTX": typeFile = caseData.DataTam.fileType.word; break;
                case "exe": typeFile = caseData.DataTam.fileType.application; break;
                case "mp3": typeFile = caseData.DataTam.fileType.mp3Audio; break;
                case "gif":
                case "png":
                case "tif":
                case "tiff":
                case "jpg":
                case "jpeg":
                case "GIT":
                case "PNG":
                case "TIF":
                case "TIFF":
                case "JPG":
                case "JPEG": typeFile = caseData.DataTam.fileType.photo; break;
                case "rar":
                case "zip": typeFile = caseData.DataTam.fileType.rar; break;
                case "txt": typeFile = caseData.DataTam.fileType.text; break;
                case "pdf":
                case "PDF": typeFile = caseData.DataTam.fileType.pdf; break;
                case "pot":
                case "potm":
                case "potx":
                case "ppam":
                case "pps":
                case "ppsm":
                case "ppsx":
                case "ppt":
                case "pptm":
                case "pptx":
                case "POT":
                case "POTM":
                case "POTX":
                case "PPAM":
                case "PPS":
                case "PPSM":
                case "PPSX":
                case "PPT":
                case "PPTM":
                case "PPTX": typeFile = caseData.DataTam.fileType.powerPoint; break;
                case "psd": typeFile = caseData.DataTam.fileType.phtoshop; break;
                case "mp4": typeFile = caseData.DataTam.fileType.mp4Vieo; break;
                case "wmv": typeFile = caseData.DataTam.fileType.wmvFile; break;
                case "flv": typeFile = caseData.DataTam.fileType.flashVieo; break;
            }
            return typeFile;
        }
    }
}
