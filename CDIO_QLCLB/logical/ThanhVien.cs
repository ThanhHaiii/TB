using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.logical
{
    class ThanhVien
    {
        string hoTV, tenTV, sdt, mssv, khoa, lop, linkfb;
        DateTime ngaySinh, ngayGiaNhap;
        bool gioiTinh;
        int diaChi, chucVu;

        public string HoTV { get => hoTV; set => hoTV = value; }
        public string TenTV { get => tenTV; set => tenTV = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Linkfb { get => linkfb; set => linkfb = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayGiaNhap { get => ngayGiaNhap; set => ngayGiaNhap = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int DiaChi { get => diaChi; set => diaChi = value; }
        public int ChucVu { get => chucVu; set => chucVu = value; }
    }
}
