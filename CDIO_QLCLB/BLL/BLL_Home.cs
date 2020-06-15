using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_Home
    {
        GUI.frm_Home frmhome;
        DAL.DAL_Home dalhome = new DAL.DAL_Home();
        //Nơi đây khai báo về kế hoạch
        Panel[] pn_Plan = new Panel[10000];
        Label[] lb_Title = new Label[10000];
        Label[] lb_DateTime = new Label[10000];
        Label[] lb_FullName = new Label[10000];

        //Đây là nơi Khai báo thông báo
        Panel[] pn_Notification = new Panel[10000];
        Label[] lb_NotfyTitle = new Label[10000];
        Label[] lb_NotifyDateTime = new Label[10000];
        Label[] lb_PostedFullName = new Label[10000];

        //Đây là nơi khai báo đăng ký mới
        Panel[] pn_SignUpMember = new Panel[100];
        Label[] lb_MSSV = new Label[100];
        Label[] lb_SignUpDateTime = new Label[100];
        Label[] lb_SignUpFullName = new Label[100];
        Label[] lb_Sex = new Label[100];
        public BLL_Home(GUI.frm_Home index)
        {
            frmhome = index;
        }

        public void loadIndex()
        {
            frmhome.Location = new Point(0, 0);
            frmhome.Size = new Size(caseData.DataTam.DuLieu.ChieuNgangFormChinh - 3, caseData.DataTam.DuLieu.ChieuDocFormChinh - 53);
            frmhome.pn_KHSapToi.Size = new Size((frmhome.Size.Width - (frmhome.pn_PhimTat.Location.X + frmhome.pn_PhimTat.Size.Width + 5)) / 2 - 8, (frmhome.Size.Height - frmhome.lb_KeHoach.Size.Height / 2 - frmhome.pn_KHSapToi.Location.Y) / 2 - 20);
            frmhome.lb_KeHoach.Size = new Size((frmhome.Size.Width - (frmhome.pn_PhimTat.Location.X + frmhome.pn_PhimTat.Size.Width + 5)) / 2 - 8, frmhome.lb_KeHoach.Size.Height);
            frmhome.lb_Sigup.Size = new Size((frmhome.Size.Width - (frmhome.pn_PhimTat.Location.X + frmhome.pn_PhimTat.Size.Width + 5)) / 2 - 8, frmhome.lb_KeHoach.Size.Height);
            frmhome.lb_ThongKe.Size = new Size((frmhome.Size.Width - (frmhome.pn_PhimTat.Location.X + frmhome.pn_PhimTat.Size.Width + 5)) / 2 - 8, frmhome.lb_KeHoach.Size.Height);
            frmhome.lb_ThongBao.Size = new Size((frmhome.Size.Width - (frmhome.pn_PhimTat.Location.X + frmhome.pn_PhimTat.Size.Width + 5)) / 2 - 8, frmhome.lb_KeHoach.Size.Height);
            frmhome.lb_ThongBao.Location = new Point(frmhome.lb_KeHoach.Location.X + frmhome.lb_KeHoach.Size.Width - 10, frmhome.lb_KeHoach.Location.Y);
            frmhome.pn_ThongBaoMoi.Location = new Point(frmhome.lb_ThongBao.Location.X, frmhome.pn_KHSapToi.Location.Y);
            frmhome.pn_ThongBaoMoi.Size = new Size(frmhome.lb_ThongBao.Size.Width, frmhome.pn_KHSapToi.Size.Height);
            frmhome.lb_ThongKe.Location = new Point(frmhome.lb_KeHoach.Location.X, frmhome.pn_KHSapToi.Location.Y + frmhome.pn_KHSapToi.Size.Height + 5);
            frmhome.pn_ThongKeSoBo.Location = new Point(frmhome.lb_ThongKe.Location.X, frmhome.lb_ThongKe.Location.Y + 5);
            frmhome.pn_ThongKeSoBo.Size = new Size(frmhome.lb_ThongKe.Size.Width, frmhome.pn_KHSapToi.Size.Height + 4);
            frmhome.lb_Sigup.Size = new Size((frmhome.Size.Width - (frmhome.pn_PhimTat.Location.X + frmhome.pn_PhimTat.Size.Width + 5)) / 2 - 8, frmhome.lb_ThongKe.Size.Height);
            frmhome.lb_Sigup.Location = new Point(frmhome.pn_ThongBaoMoi.Location.X, frmhome.lb_ThongKe.Location.Y);
            frmhome.pn_DKMoi.Location = new Point(frmhome.lb_ThongBao.Location.X, frmhome.pn_ThongKeSoBo.Location.Y + 4);
            frmhome.pn_DKMoi.Size = new Size(frmhome.lb_ThongKe.Size.Width, frmhome.pn_KHSapToi.Size.Height);
            frmhome.lb_DemNen.Location = new Point(frmhome.lb_Sigup.Location.X + frmhome.lb_Sigup.Size.Width - 50, frmhome.lb_Sigup.Location.Y + 1);
        }

        private string dateFormat(DateTime dateTime)
        {
            return dateTime.Hour.ToString() + ":00";
        }

        private string getImageWWeather(string typeWeather)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            switch (typeWeather)
            {
                case "broken clouds":
                case "few clouds":
                case "overcast clouds":
                case "scattered clouds":
                    return @"\IMAGES\Icon\ThoiTiet\cloud.png";
                case "light rain":
                case "moderate rain":
                case "heavy intensity rain":

                    if (typeWeather.Equals("heavy intensity rain") && dt.Month > 5 && dt.Month < 10)
                    {
                        if (dt.Hour > 6 && dt.Hour < 18)
                            return @"\IMAGES\Icon\ThoiTiet\strom2.png";
                        else
                            return @"\IMAGES\Icon\ThoiTiet\strom.png";
                    }
                    else
                    {
                        if (dt.Hour > 6 && dt.Hour < 18)
                            return @"\IMAGES\Icon\ThoiTiet\weather2.png";
                        else
                            return @"\IMAGES\Icon\ThoiTiet\rain.png";
                    }

                case "clear sky":
                    if (dt.Hour > 6 && dt.Hour < 18)
                        return @"\IMAGES\Icon\ThoiTiet\sun.png";
                    else
                        return @"\IMAGES\Icon\ThoiTiet\moon2.png";

                case "light snow":
                    return @"\IMAGES\Icon\ThoiTiet\frost.png";
            }
            return null;
        }

        public void loadWeather()
        {
            try
            {
                char c = (char)176;
                logical.ThoiTiet weather = new logical.ThoiTiet();
                weather.loadXML();
                List<caseData.dataThoiTiet> listweather = weather.layDSThoiTiet();
                int x = 5, dem = 0;
                Label lb_Time, lb_Temperture;
                PictureBox pic_IconWeather;
                foreach (caseData.dataThoiTiet wt in listweather)
                {
                    lb_Time = new Label();
                    lb_Time.Text = "Thời gian: " + dateFormat(wt.NgayGio);
                    lb_Time.Size = new Size(125, 18);
                    lb_Time.TextAlign = ContentAlignment.MiddleCenter;
                    lb_Time.Location = new Point(x, 0);

                    lb_Temperture = new Label();
                    lb_Temperture.Text = wt.NhietDo.ToString() + c + "C";
                    lb_Temperture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb_Temperture.Size = new Size(125, 18);
                    lb_Temperture.TextAlign = ContentAlignment.MiddleCenter;
                    lb_Temperture.Location = new Point(x, 20);

                    pic_IconWeather = new PictureBox();
                    pic_IconWeather.Image = Image.FromFile((caseData.DataTam.DuLieu.linkFileGoc + getImageWWeather(wt.BieuTuong)));
                    pic_IconWeather.Size = new Size(32, 32);
                    pic_IconWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    pic_IconWeather.Location = new Point(lb_Temperture.Size.Width / 3 + x + 5, 43);

                    frmhome.pn_ThoiTiet.Controls.Add(lb_Temperture);
                    frmhome.pn_ThoiTiet.Controls.Add(lb_Time);
                    frmhome.pn_ThoiTiet.Controls.Add(pic_IconWeather);

                    x += lb_Time.Size.Width + 5;
                    dem++;
                    frmhome.pn_ThoiTiet.Size = new Size(frmhome.lb_ThoiTiet.Size.Width, frmhome.pn_ThoiTiet.Size.Height);
                    if (dem == 8)
                        break;
                }

                frmhome.lb_ThoiTiet.Text += " - " + caseData.DataTam.DuLieu.diaPhuong;
            }
            catch { }
        }

        public void loadThongKe()
        {
            string sqlSLCTV = "select count(IDThanhVien) from ThanhVien where IDChucVu = 8 and RoiCLB is null";
            string sqlSLTVCT = "select count(IDThanhVien) from ThanhVien where IDChucVu != 8 and RoiCLB is null";
            string sqlRoiCLB = "select count(IDThanhVien) as TVDaRoiCLB from ThanhVien where RoiCLB is not null";
            string sqlSLNu = "select count(IDThanhVien) from ThanhVien where GioiTinh = 0";
            string sqlNopTien = "select sum(Tien_NhaTaiTro.SoTien) + sum(TV_NopTien.SoTien) AS NopTIen from Tien_NhaTaiTro,TV_NopTien";
            string sqlXuatTien = "select sum(SoTien) AS TienXuat from TV_NhanTien";
            int soTVCT = 0, soCTV = 0, soLuongNu = 0, daroiCLB = 0;
            double tienNop = 0, tienXuat = 0;
            try
            {
                soTVCT = int.Parse(dalhome.lay1cell(sqlSLTVCT).ToString());
                soCTV = int.Parse(dalhome.lay1cell(sqlSLCTV).ToString());
                soLuongNu = int.Parse(dalhome.lay1cell(sqlSLNu).ToString());
                daroiCLB = int.Parse(dalhome.lay1cell(sqlRoiCLB).ToString());
            }
            catch { }

            try
            {
                tienNop = double.Parse(dalhome.lay1cell(sqlNopTien).ToString());
                tienXuat = double.Parse(dalhome.lay1cell(sqlXuatTien).ToString());
            }
            catch { }
            logical.APIeSMS eSMS = new logical.APIeSMS();
            frmhome.lb_SoLuongTV.Text += soTVCT.ToString();
            frmhome.lb_SoLuongCTV.Text += soCTV.ToString();
            frmhome.lb_TyLeNamNu.Text += ((soCTV + soTVCT) - soLuongNu).ToString() + "/" + soLuongNu;
            frmhome.lb_DaRoiCLB.Text += daroiCLB.ToString();
            frmhome.lb_QuyHienTai.Text += string.Format("{0:#,##0}", (tienNop - tienXuat)).ToString() + " VNĐ";
            frmhome.lb_QuyNhap.Text += string.Format("{0:#,##0}", (tienNop)).ToString() + " VNĐ";
            frmhome.lb_QuyXuat.Text += string.Format("{0:#,##0}", (tienXuat)).ToString() + " VNĐ";
            frmhome.lb_moneyeSMS.Text += string.Format("{0:#,##0}", double.Parse(eSMS.checkMoney())).ToString() + " VNĐ";
        }

        public void loadPlan()
        {
            string sqlquery = "select Top(10000) IDKeHoach,TieuDe,NoiDung,NgayRaKH,VanBanKemTheo,TenDiaDiem,TenTinh,TenHuyen,TenXa,DiaChiCuThe,HoThanhVien + ' ' + TenThanhVien as HoTen from KeHoach, ThanhVien,DiaChi,Xa,Huyen,Tinh,DiaDiem where KeHoach.NguoiRaKH = ThanhVien.IDThanhVien and DiaChi.IDDiaChi = KeHoach.IDDiaChi and KeHoach.IDDiaDiem = DiaDiem.IDDiaDiem and DiaChi.IDXa = Xa.IDXa and DiaChi.IDHuyen = Huyen.IDHuyen and Tinh.IDTinh = DiaChi.IDTinh order by NgayRaKH";
            DataTable dt = dalhome.getPlan(sqlquery);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pn_Plan[i] = new Panel();
                lb_Title[i] = new Label();
                lb_DateTime[i] = new Label();
                lb_FullName[i] = new Label();

                pn_Plan[i].BackColor = System.Drawing.SystemColors.ControlLightLight;
                pn_Plan[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pn_Plan[i].Cursor = System.Windows.Forms.Cursors.Hand;
                pn_Plan[i].Dock = System.Windows.Forms.DockStyle.Top;
                pn_Plan[i].Location = new System.Drawing.Point(0, 0);
                pn_Plan[i].Size = new System.Drawing.Size(frmhome.pn_KHSapToi.Size.Width, 100);
                pn_Plan[i].TabIndex = i;
                pn_Plan[i].Tag = dt.Rows[i]["IDKeHoach"].ToString();
                pn_Plan[i].Click += new System.EventHandler(keHoach_Click);

                lb_Title[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_Title[i].Location = new System.Drawing.Point(17, 5);
                lb_Title[i].Size = new System.Drawing.Size(frmhome.pn_KHSapToi.Size.Width - 30, 40);
                lb_Title[i].TabIndex = i;
                lb_Title[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lb_Title[i].Text = dt.Rows[i]["TieuDe"].ToString();
                lb_Title[i].Tag = dt.Rows[i]["IDKeHoach"].ToString();
                lb_Title[i].Click += new System.EventHandler(keHoach_Click);

                lb_DateTime[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_DateTime[i].Location = new System.Drawing.Point(0, 45);
                lb_DateTime[i].Size = new System.Drawing.Size(frmhome.pn_KHSapToi.Size.Width - 30, 23);
                lb_DateTime[i].TabIndex = 0;
                DateTime ngay = Convert.ToDateTime(dt.Rows[i]["NgayRaKH"].ToString());
                lb_DateTime[i].Text = "Ngày ra kế hoạch: " + string.Format("{0:dd/MM/yyyy hh:mm tt}", ngay);
                lb_DateTime[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                lb_DateTime[i].Tag = dt.Rows[i]["IDKeHoach"].ToString();
                lb_DateTime[i].Click += new System.EventHandler(keHoach_Click);

                lb_FullName[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_FullName[i].Location = new System.Drawing.Point(0, 72);
                lb_FullName[i].Size = new System.Drawing.Size(frmhome.pn_KHSapToi.Size.Width - 30, 23);
                lb_FullName[i].TabIndex = 0;
                lb_FullName[i].Text = "Người ra kế hoạch: " + dt.Rows[i]["HoTen"].ToString();
                lb_FullName[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                lb_FullName[i].Tag = dt.Rows[i]["IDKeHoach"].ToString();
                lb_FullName[i].Click += new System.EventHandler(keHoach_Click);

                frmhome.pn_KHSapToi.Controls.Add(pn_Plan[i]);
                pn_Plan[i].Controls.Add(lb_Title[i]);
                pn_Plan[i].Controls.Add(lb_DateTime[i]);
                pn_Plan[i].Controls.Add(lb_FullName[i]);
            }
        }

        public void loadNotification()
        {
            string sqlquery = "select Top(9500) IDThongBao,TieuDe,NoiDung,NgayDang, NguoiDang, HoThanhVien + ' ' + TenThanhVien as HoTen from ThongBao,ThanhVien where ThongBao.NguoiDang = ThanhVien.IDThanhVien order by NgayDang";
            DataTable dt = dalhome.getPlan(sqlquery);
            int i = 0;
            for (; i < dt.Rows.Count; i++)
            {
                pn_Notification[i] = new Panel();
                lb_NotfyTitle[i] = new Label();
                lb_NotifyDateTime[i] = new Label();
                lb_PostedFullName[i] = new Label();

                pn_Notification[i].BackColor = System.Drawing.SystemColors.ControlLightLight;
                pn_Notification[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pn_Notification[i].Cursor = System.Windows.Forms.Cursors.Hand;
                pn_Notification[i].Dock = System.Windows.Forms.DockStyle.Top;
                pn_Notification[i].Location = new System.Drawing.Point(0, 0);
                pn_Notification[i].Size = new System.Drawing.Size(frmhome.pn_ThongBaoMoi.Size.Width - 2, 100);
                pn_Notification[i].TabIndex = i;
                pn_Notification[i].Tag = dt.Rows[i]["IDThongBao"].ToString();
                pn_Notification[i].Click += new System.EventHandler(Poster_Click);

                lb_NotfyTitle[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_NotfyTitle[i].Location = new System.Drawing.Point(17, 5);
                lb_NotfyTitle[i].Size = new System.Drawing.Size(560, 40);
                lb_NotfyTitle[i].TabIndex = i;
                lb_NotfyTitle[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lb_NotfyTitle[i].Anchor = (AnchorStyles)(AnchorStyles.Left);
                lb_NotfyTitle[i].Text = dt.Rows[i]["TieuDe"].ToString();
                lb_NotfyTitle[i].Tag = dt.Rows[i]["IDThongBao"].ToString();
                lb_NotfyTitle[i].Click += new System.EventHandler(Poster_Click);

                lb_NotifyDateTime[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_NotifyDateTime[i].Location = new System.Drawing.Point(0, 45);
                lb_NotifyDateTime[i].Size = new System.Drawing.Size(frmhome.pn_ThongBaoMoi.Size.Width - 30, 23);
                lb_NotifyDateTime[i].TabIndex = 0;
                DateTime ngay = Convert.ToDateTime(dt.Rows[i]["NgayDang"].ToString());
                lb_NotifyDateTime[i].Text = tinhNgay(Convert.ToDateTime(ngay.ToString("dd/MM/yyyy hh:mm:ss tt")));
                lb_NotifyDateTime[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                lb_NotifyDateTime[i].Tag = dt.Rows[i]["IDThongBao"].ToString();
                lb_NotifyDateTime[i].Anchor = (AnchorStyles)(AnchorStyles.Left);
                lb_NotifyDateTime[i].Click += new System.EventHandler(Poster_Click);

                lb_PostedFullName[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_PostedFullName[i].Location = new System.Drawing.Point(0, 72);
                lb_PostedFullName[i].Size = new System.Drawing.Size(frmhome.pn_ThongBaoMoi.Size.Width - 30, 23);
                lb_PostedFullName[i].TabIndex = 0;
                lb_PostedFullName[i].Text = "Đăng bởi: " + dt.Rows[i]["HoTen"].ToString();
                lb_PostedFullName[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                lb_PostedFullName[i].Tag = dt.Rows[i]["IDThongBao"].ToString();
                lb_PostedFullName[i].Anchor = (AnchorStyles)(AnchorStyles.Left);
                lb_PostedFullName[i].Click += new System.EventHandler(Poster_Click);

                frmhome.pn_ThongBaoMoi.Controls.Add(pn_Notification[i]);
                pn_Notification[i].Controls.Add(lb_NotfyTitle[i]);
                pn_Notification[i].Controls.Add(lb_NotifyDateTime[i]);
                pn_Notification[i].Controls.Add(lb_PostedFullName[i]);
            }

            string sqlBirthDay = "SELECT [IDThanhVien],[HoThanhVien],[TenThanhVien],[GioiTinh],[NgaySinh] FROM [ThanhVien] where DAY(NgaySinh) = DAY(getdate()) and MONTH(NgaySinh) = month(GETDATE())";
            DataTable dtbd = dalhome.getPlan(sqlBirthDay);
            if (dtbd.Rows.Count > 0)
            {
                pn_Notification[i] = new Panel();
                lb_NotfyTitle[i] = new Label();
                lb_NotifyDateTime[i] = new Label();
                lb_PostedFullName[i] = new Label();

                pn_Notification[i].BackColor = System.Drawing.SystemColors.ControlLightLight;
                pn_Notification[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pn_Notification[i].Cursor = System.Windows.Forms.Cursors.Hand;
                pn_Notification[i].Dock = System.Windows.Forms.DockStyle.Top;
                pn_Notification[i].Location = new System.Drawing.Point(0, 0);
                pn_Notification[i].Size = new System.Drawing.Size(frmhome.pn_ThongBaoMoi.Size.Width - 2, 140);
                pn_Notification[i].Click += new System.EventHandler(birth_Click);

                lb_NotfyTitle[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_NotfyTitle[i].Location = new System.Drawing.Point(17, 5);
                lb_NotfyTitle[i].Size = new System.Drawing.Size(frmhome.pn_ThongBaoMoi.Size.Width - 30, 75);
                lb_NotfyTitle[i].Image = global::CDIO_QLCLB.Properties.Resources.birthDay;
                lb_NotfyTitle[i].ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                lb_NotfyTitle[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lb_NotfyTitle[i].Text = "Hôm là sinh nhật của " + dtbd.Rows.Count + " bạn trong CLB\nHãy gửi lời chúc tới họ nào !";
                lb_NotfyTitle[i].Click += new System.EventHandler(birth_Click);

                lb_NotifyDateTime[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_NotifyDateTime[i].Location = new System.Drawing.Point(0, 78);
                lb_NotifyDateTime[i].Size = new System.Drawing.Size(frmhome.pn_ThongBaoMoi.Size.Width - 30, 23);
                lb_NotifyDateTime[i].TabIndex = 0;
                lb_NotifyDateTime[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                DateTime ngay = DateTime.Now;
                lb_NotifyDateTime[i].Text = "Ngày : " + ngay.ToString("dd/MM/yyyy");
                lb_NotifyDateTime[i].Click += new System.EventHandler(birth_Click);

                lb_PostedFullName[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb_PostedFullName[i].Location = new System.Drawing.Point(0, 100);
                lb_PostedFullName[i].Size = new System.Drawing.Size(frmhome.pn_ThongBaoMoi.Size.Width - 30, 23);
                lb_PostedFullName[i].TabIndex = 0;
                lb_PostedFullName[i].Text = "Tin Hệ Thống";
                lb_PostedFullName[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                lb_PostedFullName[i].Click += new System.EventHandler(birth_Click);

                frmhome.pn_ThongBaoMoi.Controls.Add(pn_Notification[i]);
                pn_Notification[i].Controls.Add(lb_NotfyTitle[i]);
                pn_Notification[i].Controls.Add(lb_NotifyDateTime[i]);
                pn_Notification[i].Controls.Add(lb_PostedFullName[i]);
            }
        }

        private void birth_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(frmhome.MdiParent as frm_MainForm);
            bllmain.loadBirth();
        }

        public void loadSignUpMember()
        {
            caseData.txtRead txtread = new caseData.txtRead();
            logical.GgSheetAPI ggsheet = new logical.GgSheetAPI();
            string[] idTable = txtread.readfile(0);
            IList<IList<Object>> values = ggsheet.docfile(idTable[1], idTable[2]);
            int dem = 0;
            for (int i = 0; i < values.Count; i++)
            {
                var row = values[i];
                if (row.Count < 13 && row.Count > 0)
                {
                    pn_SignUpMember[dem] = new Panel();
                    lb_MSSV[dem] = new Label();
                    lb_SignUpDateTime[dem] = new Label();
                    lb_SignUpFullName[dem] = new Label();
                    lb_Sex[dem] = new Label();

                    pn_SignUpMember[dem].BackColor = System.Drawing.SystemColors.ControlLightLight;
                    pn_SignUpMember[dem].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pn_SignUpMember[dem].Cursor = System.Windows.Forms.Cursors.Hand;
                    pn_SignUpMember[dem].Dock = System.Windows.Forms.DockStyle.Top;
                    pn_SignUpMember[dem].Location = new System.Drawing.Point(0, 0);
                    pn_SignUpMember[dem].Size = new System.Drawing.Size(frmhome.pn_DKMoi.Size.Width, 100);
                    pn_SignUpMember[dem].TabIndex = i;
                    pn_SignUpMember[dem].Tag = i;
                    pn_SignUpMember[dem].Click += new System.EventHandler(SignUp_Click);

                    lb_SignUpFullName[dem].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb_SignUpFullName[dem].Location = new System.Drawing.Point(17, 5);
                    lb_SignUpFullName[dem].Size = new System.Drawing.Size(frmhome.pn_DKMoi.Size.Width - 30, 40);
                    lb_SignUpFullName[dem].TabIndex = i;
                    lb_SignUpFullName[dem].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    lb_SignUpFullName[dem].Anchor = (AnchorStyles)(AnchorStyles.Left);
                    lb_SignUpFullName[dem].Text = row[2] + " " + row[3] + " - " + row[1];
                    lb_SignUpFullName[dem].Tag = i;
                    lb_SignUpFullName[dem].Click += new System.EventHandler(SignUp_Click);

                    lb_SignUpDateTime[dem].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb_SignUpDateTime[dem].Location = new System.Drawing.Point(0, 72);
                    lb_SignUpDateTime[dem].Size = new System.Drawing.Size(frmhome.pn_DKMoi.Size.Width - 30, 23);
                    lb_SignUpDateTime[dem].TabIndex = 0;
                    DateTime ngay = Convert.ToDateTime(row[0]);
                    lb_SignUpDateTime[dem].Text = "Thời gian: " + ngay.ToString("dd/MM/yyyy hh:mm:ss tt");
                    lb_SignUpDateTime[dem].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    lb_SignUpDateTime[dem].Tag = i;
                    lb_SignUpDateTime[dem].Anchor = (AnchorStyles)(AnchorStyles.Left);
                    lb_SignUpDateTime[dem].Click += new System.EventHandler(SignUp_Click);

                    lb_Sex[dem].Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb_Sex[dem].Location = new System.Drawing.Point(0, 45);
                    lb_Sex[dem].Size = new System.Drawing.Size(frmhome.pn_DKMoi.Size.Width - 30, 23);
                    lb_Sex[dem].TabIndex = 0;
                    lb_Sex[dem].Text = "Giới tính: " + row[5] + "    Khoa: " + row[8] + "    Lớp: " + row[9];
                    lb_Sex[dem].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    lb_Sex[dem].Tag = i;
                    lb_Sex[dem].Anchor = (AnchorStyles)(AnchorStyles.Left);
                    lb_Sex[dem].Click += new System.EventHandler(SignUp_Click);

                    frmhome.pn_DKMoi.Controls.Add(pn_SignUpMember[dem]);
                    pn_SignUpMember[dem].Controls.Add(lb_SignUpFullName[dem]);
                    pn_SignUpMember[dem].Controls.Add(lb_SignUpDateTime[dem]);
                    pn_SignUpMember[dem].Controls.Add(lb_Sex[dem]);
                    dem++;
                }
            }
            frmhome.lb_DemDK.Text = dem.ToString();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(frmhome.MdiParent as frm_MainForm);
            try
            {
                caseData.DataTam.DuLieu.idTemp = (((Label)sender).Tag.ToString());
            }
            catch
            {
                caseData.DataTam.DuLieu.idTemp = (((Panel)sender).Tag.ToString());
            }
            bllmain.loadSignUp();
        }

        private void Poster_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(frmhome.MdiParent as frm_MainForm);
            try
            {
                caseData.DataTam.DuLieu.idTemp = (((Label)sender).Tag.ToString());
            }
            catch
            {
                caseData.DataTam.DuLieu.idTemp = (((Panel)sender).Tag.ToString());
            }
            bllmain.loadNotification();
        }

        private string tinhNgay(DateTime dataDate)
        {
            DateTime dateNow = DateTime.Now;
            if ((dateNow - dataDate).Days > 0)
                return "Đăng cách đây: " + (dateNow - dataDate).Days + " ngày";
            if ((dateNow - dataDate).Hours > 0)
                return "Đăng cách đây: " + (dateNow - dataDate).Hours + " giờ";
            if ((dateNow - dataDate).Minutes > 0)
                return "Đăng cách đây: " + (dateNow - dataDate).Minutes + " phút";
            return "Đăng cách đây: " + (dateNow - dataDate).Seconds + " giây";
        }

        private void keHoach_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(frmhome.MdiParent as frm_MainForm);
            try
            {
                caseData.DataTam.DuLieu.idTemp = (((Label)sender).Tag.ToString());
            }
            catch
            {
                caseData.DataTam.DuLieu.idTemp = (((Panel)sender).Tag.ToString());
            }
            bllmain.loadPlanningDetails();
        }

        public void logout()
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLL.BLL_MainForm frmmain = new BLL.BLL_MainForm(frmhome.MdiParent as frm_MainForm);
                GUI.frm_Login frmlogin = new GUI.frm_Login();

                frmlogin.Show();
                frmmain.logout();
                caseData.DataTam.DuLieu.ID = "";
                caseData.DataTam.DuLieu.dt = null;
            }
        }
    }
}