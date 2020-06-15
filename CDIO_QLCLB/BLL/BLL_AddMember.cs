using System;
using System.Data;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_AddMember
    {
        GUI.frm_AddMember frmaddmember;
        DAL.DAL_Addmember daladdmember = new DAL.DAL_Addmember();
        string linkFile = "", idDiaChi = "";
        objInProject.MemberList mblist = new objInProject.MemberList();
        public BLL_AddMember(GUI.frm_AddMember frmMember)
        {
            frmaddmember = frmMember;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void loadTinh()
        {
            try
            {
                string sqlQuery = "select IDTinh, (Kieu + ' ' + TenTinh) as tenTinh from Tinh";
                DataTable dt = daladdmember.getTable(sqlQuery);
                frmaddmember.cbb_TenTinh.DataSource = dt.Copy();
                frmaddmember.cbb_TenTinh.DisplayMember = "tenTinh";
                frmaddmember.cbb_TenTinh.ValueMember = "IDTinh";
            }
            catch { }
        }

        public void exportComfirMember()
        {
            Export.ToExcel export = new Export.ToExcel();
            export.exportComfirmationMember(caseData.DataTam.DuLieu.idTemp);
        }

        public void loadHuyen(string iDTinh)
        {
            try
            {
                string sqlQuery = "select IDHuyen, (Kieu + ' ' + TenHuyen) as tenHuyen from Huyen where IDTinh = " + iDTinh;
                DataTable dt = daladdmember.getTable(sqlQuery);
                frmaddmember.cbb_TenHuyen.DataSource = dt.Copy();
                frmaddmember.cbb_TenHuyen.DisplayMember = "tenHuyen";
                frmaddmember.cbb_TenHuyen.ValueMember = "IDHuyen";
            }
            catch { }
        }

        public void loadXa(string iDHuyen)
        {
            try
            {
                string sqlQuery = "select IDXa, (Kieu + ' ' + TenXa) as tenXa from Xa where IDHuyen = " + iDHuyen;
                DataTable dt = daladdmember.getTable(sqlQuery);
                frmaddmember.cbb_TenXa.DataSource = dt.Copy();
                frmaddmember.cbb_TenXa.DisplayMember = "tenXa";
                frmaddmember.cbb_TenXa.ValueMember = "IDXa";
            }
            catch { }
        }

        public void loadAnh()
        {
            try
            {
                caseData.MoFile fopen = new caseData.MoFile();
                linkFile = fopen.moFileAnh();
                XuLyAnh.CatAvatar avartarcut = new XuLyAnh.CatAvatar();
                frmaddmember.pic_Avartar.Image = avartarcut.catAnh(linkFile);
            }
            catch { }
        }

        private bool checkNull()
        {
            if (frmaddmember.tb_Ho.Text == "" || frmaddmember.tb_Ho.Text.Length > 30)
            {
                if (frmaddmember.tb_Ho.Text.Length > 30)
                {
                    MessageBox.Show("Họ sinh viên không được quá 30 ký tự");
                    frmaddmember.tb_Ho.Focus();
                    return false;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập họ thành viên !");
                    frmaddmember.tb_Ho.Focus();
                    return false;
                }

            }

            if (frmaddmember.tb_Ten.Text == "" || frmaddmember.tb_Ten.Text.Length > 10)
            {
                if (frmaddmember.tb_Ten.Text.Length > 10)
                {
                    MessageBox.Show("Tên sinh viên không được quá 10 ký tự");
                    frmaddmember.tb_Ho.Focus();
                    return false;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên thành viên!");
                    frmaddmember.tb_Ten.Focus();
                    return false;
                }
            }

            if (frmaddmember.tb_MSSV.Text == "" || frmaddmember.tb_MSSV.Text.Length > 15)
            {
                if (frmaddmember.tb_MSSV.Text.Length > 15)
                {
                    MessageBox.Show("MSSV không được quá 15 ký tự");
                    frmaddmember.tb_Ho.Focus();
                    return false;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập MSSV !");
                    frmaddmember.tb_MSSV.Focus();
                    return false;
                }
            }

            if (frmaddmember.tb_Lop.Text == "" || frmaddmember.tb_Lop.Text.Length > 20)
            {
                if (frmaddmember.tb_Lop.Text.Length > 20)
                {
                    MessageBox.Show("Lớp không được quá 20 ký tự");
                    frmaddmember.tb_Ho.Focus();
                    return false;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lớp!");
                    frmaddmember.tb_Lop.Focus();
                    return false;
                }
            }

            if (!frmaddmember.rdb_Nam.Checked && !frmaddmember.rdb_Nu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return false;
            }

            if (frmaddmember.cb_Khoa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khoa !");
                return false;
            }

            DateTime ngayHT = DateTime.Now;
            if ((ngayHT.Year - frmaddmember.dtp_NgaySinh.Value.Year) < 16 || (ngayHT.Year - frmaddmember.dtp_NgaySinh.Value.Year) > 80)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                frmaddmember.dtp_NgaySinh.Focus();
                return false;
            }

            if (frmaddmember.cbb_TenXa.ValueMember == "")
            {
                MessageBox.Show("Vui lòng chọn quê quán !");
                return false;
            }

            if (frmaddmember.tb_SDT.Text == "" || frmaddmember.tb_SDT.Text.Length > 15)
            {
                if (frmaddmember.tb_SDT.Text.Length > 15)
                {
                    MessageBox.Show("SĐT không được quá 15 ký tự");
                    frmaddmember.tb_Ho.Focus();
                    return false;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại !");
                    frmaddmember.tb_SDT.Focus();
                    return false;
                }
            }

            if (frmaddmember.tb_Facebook.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số facebook !");
                frmaddmember.tb_Facebook.Focus();
                return false;
            }

            return true;
        }

        private bool checkMSSV()
        {
            string sqlquery = "select * from ThanhVien where MSSV = '" + frmaddmember.tb_MSSV.Text + "'";
            if (daladdmember.getTable(sqlquery).Rows.Count > 0)
                return true;
            return false;
        }

        private string getidDiaChi()
        {
            string sqlquery = "insert into DiaChi(IDTinh,IDHuyen,IDXa,DiaChiCuThe) values(" + frmaddmember.cbb_TenTinh.SelectedValue + "," +
                frmaddmember.cbb_TenHuyen.SelectedValue + "," + frmaddmember.cbb_TenXa.SelectedValue + ",N'" + frmaddmember.tb_DiaChiCuThe.Text + "')";
            daladdmember.addMember(sqlquery);
            sqlquery = "select MAX(IDDiaChi) from DiaChi";
            return daladdmember.getNewID(sqlquery);
        }

        private void addMember()
        {
            try
            {
                XuLyAnh.MaHoaHinhAnh mha = new XuLyAnh.MaHoaHinhAnh();
                SECURITY.RandomClass rdm = new SECURITY.RandomClass();
                int chucVu;
                int gioiTinh;
                if (frmaddmember.rdb_CTV.Checked) chucVu = 8; else chucVu = 7;
                if (frmaddmember.rdb_Nam.Checked) gioiTinh = 1; else gioiTinh = 0;
                string imageName = rdm.RandomText(20) + ".jpg";
                frmaddmember.pic_Avartar.Image.Save(imageName);
                string chuoiAnh = mha.byteToString(mha.AnhSangChuoi(imageName));
                string sqlquery = "insert into ThanhVien(HoThanhVien,TenThanhVien,GioiTinh,NgaySinh,IDDiaChi,SDT,MSSV,Khoa,Lop,LinkFB,"
                    + "IDChucVu,NgayGiaNhap,AnhDaiDien) values(N'" + frmaddmember.tb_Ho.Text + "',N'" + frmaddmember.tb_Ten.Text
                    + "'," + gioiTinh + ",'" + string.Format("{0:u}", frmaddmember.dtp_NgaySinh.Value).Substring(0, 10) + "'," + getidDiaChi() + ",'"
                    + frmaddmember.tb_SDT.Text + "','" + frmaddmember.tb_MSSV.Text + "',N'" + frmaddmember.cb_Khoa.Text + "',N'"
                    + frmaddmember.tb_Lop.Text + "',N'" + frmaddmember.tb_Facebook.Text + "'," + chucVu + ",getdate(),'" + chuoiAnh + "')";
                daladdmember.addMember(sqlquery);
                sqlquery = "select max(IDThanhVien) from ThanhVien";
                string idThanhVien = daladdmember.getNewID(sqlquery);
                sqlquery = "insert into DuyetThanhVien(IDThanhVien,NgayDuyet,NguoiDuyet) values(" + idThanhVien
                    + ",getdate()," + caseData.DataTam.DuLieu.ID + ")";
                if (daladdmember.addMember(sqlquery) > 0)
                {
                    string message = "Chúc mừng bạn: <HoTen>, MSSV: < MSSV > đã chính thức trở thành CTV của CLB Tình nguyện Sinh viên Duy Tân.Mời bạn truy cập link: https://www.facebook.com/groups/CLBTinhNguyenSinhVienDuyTan để vào group của CLB nhằm theo dõi các thông báo mới nhất. CLB Tình nguyện Sinh viên Duy Tân xin cám ơn bạn vì đã tham gia cùng chúng tôi";
                    logical.APIeSMS eSMS = new logical.APIeSMS();
                    XuLyChuoi.checkKyTu chkstr = new XuLyChuoi.checkKyTu();
                    eSMS.SendSMS(frmaddmember.tb_SDT.Text, chkstr.DetectChar(message, idThanhVien));
                    MessageBox.Show("Thêm thành công");
                }
                sqlquery = "select AnhDaiDien from ThanhVien where IDThanhVien = '" + idThanhVien + "'";
                frmaddmember.pic_Avartar.Image = mha.ChuoiSangAnh(daladdmember.getNewID(sqlquery));
                caseData.MoFile fopen = new caseData.MoFile();
                fopen.deleteFile(imageName);
                linkFile = imageName;
                caseData.DataTam.DuLieu.client.Send(Serialize("volunteeraddmember:" + idThanhVien));
                mblist.addNewMember(idThanhVien, caseData.DataTam.DuLieu.mbList);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
        }

        public void saveMember()
        {
            if (checkNull())
            {
                Thread thrsave = new Thread(() => {
                    if (caseData.DataTam.DuLieu.idTemp == "")
                    {
                        if (!checkMSSV())
                        {
                            addMember();
                        }
                        else
                        {
                            MessageBox.Show("Mã sinh viên đã tồn tại");
                            frmaddmember.tb_MSSV.Focus();
                        }
                    }
                    else
                    {
                        updateMember();
                    }
                });
                thrsave.Start();
            }
        }

        private void updateMember()
        {
            XuLyAnh.MaHoaHinhAnh mha = new XuLyAnh.MaHoaHinhAnh();
            SECURITY.RandomClass rdm = new SECURITY.RandomClass();
            string chucVu;
            int gioiTinh;
            chucVu = frmaddmember.cbb_ChucVu.SelectedValue.ToString();
            if (frmaddmember.rdb_Nam.Checked) gioiTinh = 1; else gioiTinh = 0;
            string sqlquery;
            if (linkFile != "")
            {
                string imageName = rdm.RandomText(20) + ".jpg";
                frmaddmember.pic_Avartar.Image.Save(imageName);

                string chuoiAnh = mha.byteToString(mha.AnhSangChuoi(imageName));
                sqlquery = "update ThanhVien set HoThanhVien = N'" + frmaddmember.tb_Ho.Text + "',TenThanhVien = N'" + frmaddmember.tb_Ten.Text
                    + "',GioiTinh = " + gioiTinh + ",NgaySinh = '" + string.Format("{0:u}", frmaddmember.dtp_NgaySinh.Value).Substring(0, 10)
                    + "',SDT = '" + frmaddmember.tb_SDT.Text + "',MSSV = '" + frmaddmember.tb_MSSV.Text + "',Khoa = N'" + frmaddmember.cb_Khoa.Text + "',Lop = N'"
                    + frmaddmember.tb_Lop.Text + "',LinkFB = N'" + frmaddmember.tb_Facebook.Text + "',IDChucVu = " + chucVu + ",AnhDaiDien = '" + chuoiAnh + "' where IDThanhVien = " + caseData.DataTam.DuLieu.idTemp;

                caseData.MoFile fopen = new caseData.MoFile();
                fopen.deleteFile(imageName);
            }
            else
            {
                sqlquery = "update ThanhVien set HoThanhVien = N'" + frmaddmember.tb_Ho.Text + "',TenThanhVien = N'" + frmaddmember.tb_Ten.Text
                    + "',GioiTinh = " + gioiTinh + ",NgaySinh = '" + string.Format("{0:u}", frmaddmember.dtp_NgaySinh.Value).Substring(0, 10)
                    + "',SDT = '" + frmaddmember.tb_SDT.Text + "',MSSV = '" + frmaddmember.tb_MSSV.Text + "',Khoa = N'" + frmaddmember.cb_Khoa.Text + "',Lop = N'"
                    + frmaddmember.tb_Lop.Text + "',LinkFB = N'" + frmaddmember.tb_Facebook.Text + "',IDChucVu = " + chucVu + " where IDThanhVien = " + caseData.DataTam.DuLieu.idTemp;
            }
            if (daladdmember.addMember(sqlquery) > 0)
            {
                sqlquery = "select IDDiaChi from ThanhVien where IDThanhVien = " + caseData.DataTam.DuLieu.idTemp;
                updateAddress(daladdmember.getNewID(sqlquery));
                MessageBox.Show("Thay đổi thông tin của bạn thành công");
            }
            sqlquery = "select AnhDaiDien from ThanhVien where IDThanhVien = '" + caseData.DataTam.DuLieu.idTemp + "'";
            frmaddmember.pic_Avartar.Image = mha.ChuoiSangAnh(daladdmember.getNewID(sqlquery));
        }

        private void updateAddress(string idaddress)
        {
            string sqlquery = "update DiaChi set IDTinh = " + frmaddmember.cbb_TenTinh.SelectedValue + ", IDHuyen = " +
                frmaddmember.cbb_TenHuyen.SelectedValue + " , IDXa = " + frmaddmember.cbb_TenXa.SelectedValue + ", DiaChiCuThe = N'" +
                frmaddmember.tb_DiaChiCuThe.Text + "' where IDDiaChi = " + idDiaChi;
            daladdmember.addMember(sqlquery);
        }

        private void loadChucVu()
        {
            string sqlquery = "select * from ChucVu order by IDChucVu";
            DataTable dt = daladdmember.getTable(sqlquery);
            frmaddmember.cbb_ChucVu.DataSource = dt.Copy();
            frmaddmember.cbb_ChucVu.DisplayMember = "TenChucVu";
            frmaddmember.cbb_ChucVu.ValueMember = "IDChucVu";
            sqlquery = "select IDChucVu from ThanhVien where IDThanhVien = " + caseData.DataTam.DuLieu.ID;
            if (int.Parse(daladdmember.getNewID(sqlquery)) < 3)
            {
                frmaddmember.cbb_ChucVu.Enabled = true;
            }
            else
            {
                frmaddmember.cbb_ChucVu.Enabled = false;
            }
        }

        private void loadMember()
        {
            try
            {
                string sqlquery = "select * from ThanhVien left join ChucVu on ThanhVien.IDChucVu = ChucVu.IDChucVu left join DiaChi on ThanhVien.IDDiaChi = DiaChi.IDDiaChi left join Tinh on Tinh.IDTinh = DiaChi.IDTinh left join Huyen on DiaChi.IDHuyen = Huyen.IDHuyen left join Xa on DiaChi.IDXa = Xa.IDXa where ThanhVien.IDThanhVien =" + caseData.DataTam.DuLieu.idTemp;
                DataTable dt = daladdmember.getTable(sqlquery);

                if (dt.Rows[0]["IDChucVu"].ToString() != "5")
                    frmaddmember.rdb_TVCT.Checked = true;
                else
                    frmaddmember.rdb_CTV.Checked = true;
                frmaddmember.tb_Ho.Text = dt.Rows[0]["HoThanhVien"].ToString();
                frmaddmember.tb_Ten.Text = dt.Rows[0]["TenThanhVien"].ToString();
                if (dt.Rows[0]["GioiTinh"].ToString() == "True")
                    frmaddmember.rdb_Nam.Checked = true;
                else
                    frmaddmember.rdb_Nu.Checked = true;
                frmaddmember.dtp_NgaySinh.Value = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
                frmaddmember.tb_MSSV.Text = dt.Rows[0]["MSSV"].ToString();
                frmaddmember.cb_Khoa.SelectedItem = dt.Rows[0]["Khoa"].ToString();
                try
                {
                    frmaddmember.cbb_TenTinh.SelectedIndex = int.Parse(dt.Rows[0]["STTTinh"].ToString()) - 1;
                    frmaddmember.cbb_TenHuyen.SelectedIndex = int.Parse(dt.Rows[0]["STTHuyen"].ToString());
                    frmaddmember.cbb_TenXa.SelectedIndex = int.Parse(dt.Rows[0]["STTXa"].ToString());
                }
                catch { }
                frmaddmember.tb_DiaChiCuThe.Text = dt.Rows[0]["DiaChiCuThe"].ToString();
                frmaddmember.tb_SDT.Text = dt.Rows[0]["SDT"].ToString();
                frmaddmember.tb_Facebook.Text = dt.Rows[0]["LinkFB"].ToString();
                frmaddmember.tb_Lop.Text = dt.Rows[0]["Lop"].ToString();
                XuLyAnh.MaHoaHinhAnh mhimage = new XuLyAnh.MaHoaHinhAnh();
                idDiaChi = dt.Rows[0]["IDDiaChi"].ToString();
                frmaddmember.pic_Avartar.Image = mhimage.ChuoiSangAnh(dt.Rows[0]["AnhDaiDien"].ToString());
                if (int.Parse(dt.Rows[0]["IDChucVu"].ToString()) < 3)
                {
                    frmaddmember.cbb_ChucVu.Enabled = true;
                }
                frmaddmember.cbb_ChucVu.SelectedIndex = int.Parse(dt.Rows[0]["IDChucVu"].ToString()) - 1;

                frmaddmember.Text = "Thông tin thành viên";
                frmaddmember.lb_TieuDe.Text = "THÔNG TIN THÀNH VIÊN";

                frmaddmember.lb_Export.Visible = true;
            }
            catch { }
        }

        public void loadAddmember()
        {
            loadChucVu();

            if (caseData.DataTam.DuLieu.idTemp != "" || caseData.DataTam.DuLieu.idTemp != null)
            {
                loadMember();

            }
        }

        public void loadRePassWD()
        {
            if (int.Parse(caseData.DataTam.DuLieu.dt.Rows[0]["IDChucVu"].ToString()) > 2 || caseData.DataTam.DuLieu.idTemp == null || caseData.DataTam.DuLieu.idTemp == "")
            {
                frmaddmember.bt_Xoa.Hide();
                frmaddmember.gb_rePassWD.Hide();
                frmaddmember.bt_Xoa.Hide();
                frmaddmember.bt_DoiPass.Hide();
            }
            else
            {
                string sqlquery = "select count(IDThanhVien) from TaiKhoan where IDThanhVien = " + caseData.DataTam.DuLieu.idTemp;
                if (int.Parse(daladdmember.getNewID(sqlquery)) < 1)
                {
                    frmaddmember.bt_DoiPass.Hide();
                    frmaddmember.gb_rePassWD.Hide();
                }

                frmaddmember.bt_Xoa.Show();
                frmaddmember.bt_Xoa.Show();
            }
        }

        public void xoaThanhVien()
        {
            string sqlquery = "update ThanhVien set RoiCLB = getdate() where IDThanhVien = " + caseData.DataTam.DuLieu.idTemp;
            daladdmember.addMember(sqlquery);//bỏ thành viên khỏi danh sách thành viên
            sqlquery = "update ThanhVien_Nhom set NgungHD = getdate() where IDThanhVien = " + caseData.DataTam.DuLieu.idTemp;
            daladdmember.addMember(sqlquery);//bỏ thành viên khỏi danh sách tất cả các nhóm.
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(frmaddmember.MdiParent as frm_MainForm);
            Socket client = caseData.DataTam.DuLieu.client;
            client.Send(Serialize("volunteerdeletemember:" + caseData.DataTam.DuLieu.idTemp));
            mblist.deleteMember(caseData.DataTam.DuLieu.idTemp, caseData.DataTam.DuLieu.mbList);
            caseData.DataTam.DuLieu.idTemp = null;
            bllmain.loadmemberlist();
        }

        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        public void doipasswd()
        {
            if (frmaddmember.tb_NewPass.Text != "")
            {
                if (frmaddmember.tb_NewPass.Text == frmaddmember.tb_ReNewPass.Text)
                {
                    SECURITY.BamChuoi security = new SECURITY.BamChuoi();
                    SECURITY.RandomClass rad = new SECURITY.RandomClass();
                    string random = rad.RandomText(10);
                    string passwd = security.maHoaKyTu(frmaddmember.tb_NewPass.Text + random);
                    string sqlquery = "update TaiKhoan set PassWD = N'" + passwd + "', RandomString = N'" + random + "' where IDThanhVien = " + caseData.DataTam.DuLieu.idTemp;
                    if (daladdmember.addMember(sqlquery) > 0)
                        MessageBox.Show("Đổi mật khẩu thành công");
                    else
                        MessageBox.Show("Lỗi không mong muốn");
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không đúng");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được để trống!");
            }
        }
    }
}
