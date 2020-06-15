using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.caseData
{
    class MoFile
    {
        public string moFileAnh()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile.FileName;
            }
            else
            {
                return null;
            }
        }

        public OpenFileDialog openAllFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile;
            }
            else
            {
                return null;
            }
        }

        public OpenFileDialog moNhieuFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All file | *.*;";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg;
            }
            return null;
        }

        public bool deleteFile(string linkfile)
        {
            try
            {
                File.Delete(linkfile);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
