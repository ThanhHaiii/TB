using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.logical
{
    class ThongBaoDKMoi
    {
        logical.GgSheetAPI rgg = new logical.GgSheetAPI();
        DAL.SQLClass dtb = new DAL.SQLClass();

        private bool checkMSSV(string masv)
        {
            string sqlquery = "select MSSV from ThanhVien where MSSV = '" + masv + "'";
            if(dtb.getDataBase(sqlquery).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private string iDDiaChi(string diachi)
        {
            try
            {
                string sqlquery = "select IDHuyen,IDTinh from Huyen where TenHuyen like N'" + diachi.Trim() + "';";
                DataTable dt = dtb.getDataBase(sqlquery);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0] + "-" + dt.Rows[0][1];
                }else return "null";
            }
            catch
            {
                return "null";
            }
        }

        private string timMaxDC()
        {
            return dtb.layMotCell("select max(IDDiaChi) from QLCLB.dbo.DiaChi").ToString();
        }

        private string chuyenNgay(string ngay)
        {
            try
            {
                DateTime ngayChuyen = DateTime.ParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                return string.Format("{0:s}", ngayChuyen).Substring(0, 10);
            }
            catch
            {
                return null;
            }
        }

       public void ThongBaoCoDKMoi(IList<IList<Object>> values) {
            try
            {
                string thongBao = "CÓ ĐĂNG KÝ MỚI CHƯA XEM";
                for (int i = values.Count - 1; i > -1; i--)
                {
                    if (values[i].Count < 13)
                    {
                        thongBao += "\nThời gian đăng ký: " + values[i][0].ToString() + "\nMSSV: " + values[i][1].ToString() + "\nHọ và tên: "
                            + values[i][2] + " " + values[i][3] + "\n---------------------------------";
                    }
                    else
                    {
                        MessageBox.Show(thongBao);
                        break;
                    }
                }
            }
            catch
            {

            }
       }
    }
}
