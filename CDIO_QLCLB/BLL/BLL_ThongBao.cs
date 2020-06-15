using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_ThongBao
    {
        GUI.frm_ThongBao frmThongBao;
        DAL.DAL_ThongBao daltt = new DAL.DAL_ThongBao();

        public BLL_ThongBao(GUI.frm_ThongBao frmtt)
        {
            frmThongBao = frmtt;

        }

        public void loadnguoidang()
        {
            try
            {
                string sqlQuery = "select IDThanhVien, (HoThanhVien + ' ' + TenThanhVien + ' - ' + TenChucVu) as HoTen,ThanhVien.IDChucVu from ThanhVien,ChucVu where RoiCLB is null and ThanhVien.IDChucVu = ChucVu.IDChucVu order by ThanhVien.IDChucVu";
                DataTable dt = daltt.getTable(sqlQuery);
                frmThongBao.ccb_NguoiDang.DataSource = dt.Copy();
                frmThongBao.ccb_NguoiDang.DisplayMember = "HoTen";
                frmThongBao.ccb_NguoiDang.ValueMember = "IDThanhVien";
            }
            catch { }
        }
        private bool checkData()
        {
            if (frmThongBao.tb_TieuDe.Text == "")
            {
                MessageBox.Show("Tiêu đề cuộc họp không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (frmThongBao.tb_NoiDung.Text == "")
            {
                MessageBox.Show("Nội dung cuộc họp không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (frmThongBao.ccb_NguoiDang.SelectedValue == null)
            {
                MessageBox.Show("Phải có người đăng thông báo", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DateTime ngayht = DateTime.Now;
            if (frmThongBao.dtp_NgayDang.Value < ngayht)
            {
                MessageBox.Show("Bạn không thể đăng thông báo có ngày nhỏ hơn ngày hiện tại");
                return false;
            }
            return true;
        }
        public void saveThongBao()
        {
            if (checkData())
            {
               
                    DateTime ngay = frmThongBao.dtp_NgayDang.Value;
                    string datestr = string.Format("{0:u}", ngay).Substring(0, 10);
                    string sqlInsert = "insert into ThongBao(TieuDe,NoiDung,NgayDang,NguoiDang) values(N'" +
                        frmThongBao.tb_TieuDe.Text + "',N'" + frmThongBao.tb_NoiDung.Text + "','" + datestr + "',"
                        + frmThongBao.ccb_NguoiDang.SelectedValue +")";
                    if (daltt.them(sqlInsert) > 0)
                    {
                        sqlInsert = "insert into ThongBao(TieuDe,NoiDung,NgayDang,NguoiDang) values(N'" + frmThongBao.tb_TieuDe.Text + "',N'"
                            + frmThongBao.tb_NoiDung.Text + "',getdate()," + caseData.DataTam.DuLieu.ID + ")";
                        daltt.them(sqlInsert);
                        MessageBox.Show("Thêm thông báo thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông báo thất bại");
                    }
                
            }
        }
        public void sendThongBao()
        {
            if (checkData())
            {
                string noiDung = "Xin chào bạn: <HoTen>, MSSV: <MSSV>. BCN CLB Tinh nguyen Sinh vien Duy Tan THÔNG BÁO: " + frmThongBao.tb_TieuDe.Text
                + " Nội dung: " + frmThongBao.tb_NoiDung.Text;
                XuLyChuoi.LoaiBoDau lbd = new XuLyChuoi.LoaiBoDau();
                XuLyChuoi.checkKyTu chkKT = new XuLyChuoi.checkKyTu();
                logical.APIeSMS eSMS = new logical.APIeSMS();
                string sqlquery = "SELECT [IDThanhVien] as ID,[HoThanhVien] + ' ' + [TenThanhVien] as HoTen,[NgaySinh],SDT FROM [ThanhVien]";
                DataTable dt = daltt.getTable(sqlquery);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    noiDung = chkKT.DetectChar(noiDung, dt.Rows[i]["IDThanhVien"].ToString());
                    string bodau = lbd.ConvertToUnsign(noiDung);
                    eSMS.SendSMS(dt.Rows[i]["SDT"].ToString(), bodau);
                }
            }
        }
        public void XoaTT()
        {
            string sql = "delete ThongBao where IDThongBao = " + caseData.DataTam.DuLieu.idTemp;
            daltt.xoa(sql);
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(frmThongBao.MdiParent as frm_MainForm);
            Socket client = caseData.DataTam.DuLieu.client;
            client.Send(Serialize("volunteerdeletemember:" + caseData.DataTam.DuLieu.idTemp));
            caseData.DataTam.DuLieu.idTemp = null;
            bllmain.loadTT();
        }

        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        public void loadForm()
        {
            loadnguoidang();
        }

    }
}
