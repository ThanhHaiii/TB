using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_CreateAccount
    {
        GUI.frm_CreateAccount frmcreateaccount;
        DAL.DAL_CreateAccount dalcreateaccount = new DAL.DAL_CreateAccount();
        public BLL_CreateAccount(GUI.frm_CreateAccount frmcreate)
        {
            frmcreateaccount = frmcreate;
        }

        public void loadMemberList()
        {
            string sqlquery = "select ThanhVien.IDThanhVien,HoThanhVien,TenThanhVien,MSSV,TenChucVu as ChucVu from ThanhVien,ChucVu,TaiKhoan where RoiCLB is null and ThanhVien.IDThanhVien != TaiKhoan.IDThanhVien and ThanhVien.IDChucVu = ChucVu.IDChucVu";
            frmcreateaccount.dgv_DSTV.DataSource = dalcreateaccount.getDataBase(sqlquery).Copy();
        }

        public void createaccount()
        {
            string sqlquery = "select ThanhVien.IDThanhVien,HoThanhVien,TenThanhVien,MSSV,TenChucVu as ChucVu,NgaySinh from ThanhVien,ChucVu,TaiKhoan where RoiCLB is null and ThanhVien.IDThanhVien != TaiKhoan.IDThanhVien and ThanhVien.IDChucVu = ChucVu.IDChucVu and ThanhVien.IDThanhVien = 394";
            DataTable dt = dalcreateaccount.getDataBase(sqlquery);
            XuLyChuoi.LoaiBoDau boDau = new XuLyChuoi.LoaiBoDau();
            SECURITY.BamChuoi bc = new SECURITY.BamChuoi();
            SECURITY.RandomClass rd = new SECURITY.RandomClass();

            string userName = (dt.Rows[0]["TenThanhVien"].ToString() +
                        layKyTuCuaHo(dt.Rows[0]["HoThanhVien"].ToString()) +
                        dt.Rows[0]["MSSV"].ToString().Substring(dt.Rows[0]["MSSV"].ToString().Length - 4, 4));
            userName = boDau.ConvertToUnsign(userName).ToLower();
            MessageBox.Show(userName);
            userName = bc.maHoaKyTu(userName);
            string randomstr = rd.RandomText(10);
            string pass = dt.Rows[0]["MSSV"].ToString();
            MessageBox.Show(pass);
            pass = bc.maHoaKyTu(pass + randomstr);
            sqlquery = "insert into TaiKhoan(IDThanhVien,UserName,PassWD,RandomString,DangNhap,KhoaTaiKhoan) values(394,N'" + userName + "',N'" + pass + "',N'" + randomstr
                + "',0,0)";
            dalcreateaccount.createaccount(sqlquery);
        }

        private string layKyTuCuaHo(string ho)
        {
            string[] tachkyTu = ho.Split(' ');
            string kytu = "";
            for(int i = 0; i < tachkyTu.Length; i++)
            {
                kytu += tachkyTu[i].Substring(0, 1);
            }
            return kytu;
        }
    }
}
