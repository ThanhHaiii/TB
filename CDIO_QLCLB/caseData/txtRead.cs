using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.caseData
{
    class txtRead
    {
        public string[] readfile(int readLine)
        {
            string filePath = caseData.DataTam.DuLieu.linkFileGoc + "googleID.txt";

            string[] lines;
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                return lines[readLine].Split(':');
            }
            return null;
        }
    }
}
