using System.Data;

namespace CDIO_QLCLB.BLL
{
    class BLL_UserConTrol
    {

        GUI.uc_userInfo guiuserinfo;
        DAL.DAL_UserInfo dalUserInfo = new DAL.DAL_UserInfo();
        XuLyAnh.MaHoaHinhAnh mhAnh = new XuLyAnh.MaHoaHinhAnh();

        public BLL_UserConTrol(GUI.uc_userInfo frm)
        {
            guiuserinfo = frm;
        }

        public void loadInfo()
        {
            try
            {
                string sqlLayThongTin = "select HoThanhVien,TenThanhVien,MSSV,TenChucVu,AnhDaiDien,ThanhVien.IDChucVu from [ThanhVien],ChucVu where IDThanhVien = " + caseData.DataTam.DuLieu.ID + " and ThanhVien.IDChucVu = ChucVu.IDChucVu";
                DataTable dt = dalUserInfo.layTTThanhVien(sqlLayThongTin);
                guiuserinfo.lb_HoTen.Text = dt.Rows[0]["HoThanhVien"] + " " + dt.Rows[0]["TenThanhVien"];
                guiuserinfo.lb_MSSV.Text = dt.Rows[0]["MSSV"].ToString();
                guiuserinfo.lb_ChucVu.Text = dt.Rows[0]["TenChucVu"].ToString();
                guiuserinfo.pic_Avatar.Image = mhAnh.ChuoiSangAnh(dt.Rows[0]["AnhDaiDien"].ToString());
                caseData.DataTam.DuLieu.dt = dt;
            }
            catch { }
        }
    }
}
