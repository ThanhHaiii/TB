using System.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_BirthDay
    {
        GUI.frm_BirthDay frmbirth;
        DAL.DAL_BirthDay sql = new DAL.DAL_BirthDay();
        public BLL_BirthDay(GUI.frm_BirthDay frombtd)
        {
            frmbirth = frombtd;
        }

        public void loadThanhVien()
        {
            string sqlquery = "SELECT [IDThanhVien] as ID,[HoThanhVien] + ' ' + [TenThanhVien] as N'Họ và tên',[NgaySinh] as N'Ngày Sinh', [MSSV] FROM [ThanhVien] where DAY(NgaySinh) = DAY(getdate()) and MONTH(NgaySinh) = month(GETDATE())";
            DataTable dt = sql.listLoad(sqlquery);
            frmbirth.dgv_List.DataSource = dt;
        }

        public void sendSMS()
        {
            XuLyChuoi.LoaiBoDau boDau = new XuLyChuoi.LoaiBoDau();
            XuLyChuoi.checkKyTu checkKyTu = new XuLyChuoi.checkKyTu();
            logical.APIeSMS eSMS = new logical.APIeSMS();
            string chuoiTin = frmbirth.tb_LoiNhan.Text;
            string chuoira = "";
            int sotinDaGui = 0;
            foreach (DataGridViewRow r in frmbirth.dgv_List.Rows)
            {
                string sqlquery = "SELECT [IDThanhVien] as ID,[HoThanhVien] + ' ' + [TenThanhVien] as HoTen,[NgaySinh], [MSSV],Khoa,Lop,NgaySinh,SDT FROM [ThanhVien] where DAY(NgaySinh) = DAY(getdate()) and MONTH(NgaySinh) = month(GETDATE()) and IDThanhVien =" + r.Cells[0].Value.ToString(); ;
                DataTable dt = sql.listLoad(sqlquery);

                chuoiTin = checkKyTu.DetectChar(chuoiTin,dt.Rows[0]["IDThanhVien"].ToString());
                chuoira = boDau.ConvertToUnsign(chuoiTin);
                if (eSMS.SendSMS(dt.Rows[0]["SDT"].ToString(), chuoira))
                {
                    string sqlqueryLuu = "insert into ChucSinhNhat(IDNguoiNhan,NoiDungChuc,ThoiGianGui,NguoiGui) values(" + r.Cells[0].Value.ToString() + ",N'" + chuoiTin + "',getdate()," + caseData.DataTam.DuLieu.ID + ")";
                    if (sql.themTinNhan(sqlqueryLuu) > 0)
                        sotinDaGui++;
                }
            }
            MessageBox.Show("Đã gửi: " + sotinDaGui + " tin nhắn chúc sinh nhật");
        }
    }
}
