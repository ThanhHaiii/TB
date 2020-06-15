using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.caseData
{
    class dataThoiTiet
    {
        DateTime ngayGio;
        int doAmKK, luongMay;
        string bieuTuong, huongGio;
        double tocDoGio, minNhietDo, maxNhietDo, nhietDo, nhietDoCamNhan, apSuat;

        public DateTime NgayGio
        {
            get { return ngayGio; }
            set { ngayGio = value; }
        }

        public string HuongGio
        {
            get { return huongGio; }
            set { huongGio = value; }
        }

        public string BieuTuong
        {
            get { return bieuTuong; }
            set { bieuTuong = value; }
        }

        public double ApSuat
        {
            get { return apSuat; }
            set { apSuat = value; }
        }

        public double NhietDoCamNhan
        {
            get { return nhietDoCamNhan; }
            set { nhietDoCamNhan = value; }
        }

        public double NhietDo
        {
            get { return nhietDo; }
            set { nhietDo = value; }
        }

        public double MaxNhietDo
        {
            get { return maxNhietDo; }
            set { maxNhietDo = value; }
        }

        public double MinNhietDo
        {
            get { return minNhietDo; }
            set { minNhietDo = value; }
        }

        public double TocDoGio
        {
            get { return tocDoGio; }
            set { tocDoGio = value; }
        }

        public int LuongMay
        {
            get { return luongMay; }
            set { luongMay = value; }
        }

        public int DoAmKK
        {
            get { return doAmKK; }
            set { doAmKK = value; }
        }
    }
}
