using System;
using System.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_AddMeetings
    {
        GUI.frm_AddMeetings frmaddMeeting;
        DAL.DAL_AddMeeting daladdmeeting = new DAL.DAL_AddMeeting();

        public BLL_AddMeetings(GUI.frm_AddMeetings frmadd)
        {
            frmaddMeeting = frmadd;
        }

        public void loadTinh()
        {
            try
            {
                string sqlQuery = "select IDTinh, (Kieu + ' ' + TenTinh) as tenTinh from Tinh";
                DataTable dt = daladdmeeting.getTable(sqlQuery);
                frmaddMeeting.cbb_TenTinh.DataSource = dt.Copy();
                frmaddMeeting.cbb_TenTinh.DisplayMember = "tenTinh";
                frmaddMeeting.cbb_TenTinh.ValueMember = "IDTinh";
            }
            catch { }
        }

        public void loadNguoiChuTri()
        {
            try
            {
                string sqlQuery = "select IDThanhVien, (HoThanhVien + ' ' + TenThanhVien + ' - ' + TenChucVu) as HoTen,ThanhVien.IDChucVu from ThanhVien,ChucVu where RoiCLB is null and ThanhVien.IDChucVu = ChucVu.IDChucVu order by ThanhVien.IDChucVu";
                DataTable dt = daladdmeeting.getTable(sqlQuery);
                frmaddMeeting.ccb_NguoiChuTri.DataSource = dt.Copy();
                frmaddMeeting.ccb_NguoiChuTri.DisplayMember = "HoTen";
                frmaddMeeting.ccb_NguoiChuTri.ValueMember = "IDThanhVien";
            }
            catch { }
        }

        public void loadHuyen(string iDTinh)
        {
            try
            {
                string sqlQuery = "select IDHuyen, (Kieu + ' ' + TenHuyen) as tenHuyen from Huyen where IDTinh = " + iDTinh;
                DataTable dt = daladdmeeting.getTable(sqlQuery);
                frmaddMeeting.cbb_TenHuyen.DataSource = dt.Copy();
                frmaddMeeting.cbb_TenHuyen.DisplayMember = "tenHuyen";
                frmaddMeeting.cbb_TenHuyen.ValueMember = "IDHuyen";
            }
            catch { }
        }

        public void openfile()
        {
            caseData.MoFile fopen = new caseData.MoFile();
            OpenFileDialog openfile = fopen.openAllFile();
            try
            {
                frmaddMeeting.tb_linkToTrinh.Text = openfile.FileName;
            }
            catch { }
        }

        private bool checkData()
        {
            if(frmaddMeeting.tb_TieuDe.Text == "")
            {
                MessageBox.Show("Tiêu đề cuộc họp không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(frmaddMeeting.tb_NoiDung.Text == "")
            {
                MessageBox.Show("Nội dung cuộc họp không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (frmaddMeeting.ccb_NguoiChuTri.SelectedValue == null)
            {
                MessageBox.Show("Phải có người chủ trì cuộc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (frmaddMeeting.cbb_TenXa.SelectedValue == null)
            {
                MessageBox.Show("Địa điểm họp không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DateTime ngayht = DateTime.Now;
            if (frmaddMeeting.dtp_NgayHop.Value < ngayht)
            {
                MessageBox.Show("Bạn không thể tạo 1 cuộc họp có ngày nhỏ hơn ngày hiện tại");
                return false;
            }
            return true;
        }

        private string insertDiaChi()
        {
            string sqlInsert = "Insert into DiaChi(IDTinh,IDHuyen,IDXa,DiaChiCuThe) values(" + frmaddMeeting.cbb_TenTinh.SelectedValue
                + "," + frmaddMeeting.cbb_TenHuyen.SelectedValue + "," + frmaddMeeting.cbb_TenXa.SelectedValue + ",N'" + frmaddMeeting.tb_DiaChiCuThe.Text + "')";
            string sqlGetID = "select MAX(IDDiaChi) from DiaChi";
            if (daladdmeeting.them(sqlInsert) > 0)
            {
                return daladdmeeting.getIDVuaThem(sqlGetID);
            }
            else
            {
                return null;
            }
        }

        private logical.dataRqUpload uploadFile()
        {
            caseData.txtRead txtread = new caseData.txtRead();
            logical.GgDriveAPI ggDrive = new logical.GgDriveAPI();
            logical.dataRqUpload dtup = new logical.dataRqUpload();
            caseData.getTypeFile gettype = new caseData.getTypeFile();
            string filename = System.IO.Path.GetFileName(frmaddMeeting.tb_linkToTrinh.Text);
            string duoiFile = filename.Split('.')[1];
            string typefile = gettype.getType(duoiFile);
            string idFolder = txtread.readfile(2)[1];
            try
            {
                dtup = ggDrive.uploadFileDriveGoogle(idFolder, filename, frmaddMeeting.tb_linkToTrinh.Text, (typefile + "/" + duoiFile));
                return dtup;
            }
            catch
            {
                return null;
            }
        }

        public void saveMeeting()
        {
            if (checkData())
            {
                string idDiaChi = insertDiaChi();
                if (idDiaChi != null)
                {
                    logical.dataRqUpload dtup = uploadFile();
                    DateTime ngay = frmaddMeeting.dtp_NgayHop.Value;
                    DateTime gio = frmaddMeeting.dtp_GioHop.Value;
                    string datestr = string.Format("{0:u}", ngay).Substring(0,10);
                    string timesrt = string.Format("{0:T}", gio);
                    string datetime = datestr + " " + timesrt.Substring(0,timesrt.Length-3);
                    string sqlInsert = "insert into CuocHop(TieuDe,NoiDung,ThoiGian,IDDiaChi,ChuTri,ToTrinh,NguoiThem,NgayThem) values(N'" +
                        frmaddMeeting.tb_TieuDe.Text + "',N'" + frmaddMeeting.tb_NoiDung.Text + "','" + datetime + "'," + idDiaChi + ",'"
                        + frmaddMeeting.ccb_NguoiChuTri.SelectedValue + "',N'" + dtup.WebContentLink + "'," + caseData.DataTam.DuLieu.ID + ",getdate())";
                    if (daladdmeeting.them(sqlInsert) > 0)
                    {
                        sqlInsert = "insert into ThongBao(TieuDe,NoiDung,NgayDang,NguoiDang) values(N'" + frmaddMeeting.tb_TieuDe.Text + "',N'"
                            + frmaddMeeting.tb_NoiDung.Text + "',getdate()," + caseData.DataTam.DuLieu.ID + ")";
                        daladdmeeting.them(sqlInsert);
                        MessageBox.Show("Thêm cuộc họp thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm cuộc họp thất bại");
                    }
                }
            }
        }

        public void sendSMS()
        {
            if (checkData())
            {
                string noiDung = "Xin chào bạn: <HoTen>, MSSV: <MSSV>. BCN CLB Tinh nguyen Sinh vien Duy Tan THÔNG BÁO: " + frmaddMeeting.tb_TieuDe.Text
                + " Nội dung: " + frmaddMeeting.tb_NoiDung.Text + " Thời gian: " + frmaddMeeting.dtp_NgayHop.Text
                + " - " + frmaddMeeting.dtp_GioHop.Text + ". Địa điểm: " + frmaddMeeting.tb_DiaChiCuThe.Text + " - " + frmaddMeeting.cbb_TenXa.Text
                + " - " + frmaddMeeting.cbb_TenHuyen.Text + " - " + frmaddMeeting.cbb_TenTinh.Text;
                XuLyChuoi.LoaiBoDau lbd = new XuLyChuoi.LoaiBoDau();
                XuLyChuoi.checkKyTu chkKT = new XuLyChuoi.checkKyTu();
                logical.APIeSMS eSMS = new logical.APIeSMS();
                string sqlquery = "SELECT [IDThanhVien] as ID,[HoThanhVien] + ' ' + [TenThanhVien] as HoTen,[NgaySinh], [MSSV],Khoa,Lop,NgaySinh,SDT FROM [ThanhVien]";
                DataTable dt = daladdmeeting.getTable(sqlquery);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    noiDung = chkKT.DetectChar(noiDung, dt.Rows[i]["IDThanhVien"].ToString());
                    string bodau = lbd.ConvertToUnsign(noiDung);
                    eSMS.SendSMS(dt.Rows[i]["SDT"].ToString(), bodau);
                }
            }
        }

        public void facebookPosster()
        {
            DateTime ngay = frmaddMeeting.dtp_NgayHop.Value;
            DateTime gio = frmaddMeeting.dtp_GioHop.Value;
            string datestr = string.Format("{0:u}", ngay).Substring(0, 10);
            string timesrt = string.Format("{0:T}", gio);
            string datetime = datestr + " " + timesrt.Substring(0, timesrt.Length - 3);
            logical.APIFBPost.APIFBPost fbPosst = new logical.APIFBPost.APIFBPost();
            string noidung = "THÔNG BÁO HỌP: " + frmaddMeeting.tb_TieuDe.Text + "\nNội dung: " + frmaddMeeting.tb_NoiDung.Text + "\nThời gian: " + datetime + "\nĐịa điểm: " +
                frmaddMeeting.tb_DiaChiCuThe.Text + " - " + frmaddMeeting.cbb_TenXa.Text + " - " + frmaddMeeting.cbb_TenHuyen.Text + " - " + frmaddMeeting.cbb_TenTinh.Text;
            fbPosst.postGroup("phangochuong74@gmail.com", "01682319448CDlCM76210119NEkplGM@@!!", noidung);
        }

        public void loadXa(string iDHuyen)
        {
            try
            {
                string sqlQuery = "select IDXa, (Kieu + ' ' + TenXa) as tenXa from Xa where IDHuyen = " + iDHuyen;
                DataTable dt = daladdmeeting.getTable(sqlQuery);
                frmaddMeeting.cbb_TenXa.DataSource = dt.Copy();
                frmaddMeeting.cbb_TenXa.DisplayMember = "tenXa";
                frmaddMeeting.cbb_TenXa.ValueMember = "IDXa";
            }
            catch { }
        }

        public void loadForm()
        {
            loadTinh();
            loadNguoiChuTri();
        }
    }
}
