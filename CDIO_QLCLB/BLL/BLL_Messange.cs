using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_Messange
    {
        GUI.frm_Messange frmmessange;
        DAL.DAL_Messange dalmessange = new DAL.DAL_Messange();
        GUI.uc_Messange ucmessange;
        XuLyAnh.MaHoaHinhAnh mha = new XuLyAnh.MaHoaHinhAnh();
        Panel pn_Image;
        PictureBox pic_Image;
        TextBox messange;
        static int loadCount = 1;

        public BLL_Messange(GUI.frm_Messange frm)
        {
            frmmessange = frm;
        }

        public void loadListMess()
        {
            frmmessange.pn_MessList.Controls.Clear();
            loadListMesssMem();
            loadListMesssTeam();
        }

        public string loadtitleMessMem(string id)
        {
            string sqlquery = "select NoiDung from TinNhan where IDTinNhan = (select MAX(IDTinNhan) from TinNhan where NguoiGui = " + caseData.DataTam.DuLieu.ID + " and NguoiNhan = " + id + " or NguoiNhan = " + caseData.DataTam.DuLieu.ID + " and NguoiGui = " + id + ")";
            string noidung;
            try
            {
                noidung = dalmessange.getHoTen(sqlquery);
                noidung = noidung.Substring(noidung.Split(':')[0].Length + 1, noidung.Length - noidung.Split(':')[0].Length - 1);
            }
            catch
            {
                noidung = "Không có tin nhắn nào";
            }
            return noidung;
        }

        private void loadListMesssMem()
        {
            string sqlquery = "select ThanhVien.IDThanhVien,(HoThanhVien +' ' +TenThanhVien+' - '+ right(MSSV,4)) as HoTen from ThanhVien right join TaiKhoan on TaiKhoan.IDThanhVien = ThanhVien.IDThanhVien";
            DataTable dt = dalmessange.getMess(sqlquery);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (caseData.DataTam.DuLieu.ID != dt.Rows[i]["IDThanhVien"].ToString())
                {
                    ucmessange = new GUI.uc_Messange();
                    ucmessange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    ucmessange.Cursor = System.Windows.Forms.Cursors.Hand;
                    ucmessange.Dock = System.Windows.Forms.DockStyle.Top;
                    ucmessange.Location = new System.Drawing.Point(0, 0);
                    ucmessange.Name = "uc_Messange1" + i;
                    ucmessange.Size = new System.Drawing.Size(310, 61);
                    ucmessange.TabIndex = i;
                    ucmessange.lb_ChatName.Text = dt.Rows[i]["HoTen"].ToString();
                    string noidung = loadtitleMessMem(dt.Rows[i]["IDThanhVien"].ToString());
                    if (mha.IsBase64String(noidung) && noidung.Length > 200)
                    {
                        noidung = "Đã gửi 1 ảnh";
                    }
                    ucmessange.lb_NewMessage.Text = noidung;
                    ucmessange.Tag = dt.Rows[i]["IDThanhVien"].ToString();
                    ucmessange.Click += new EventHandler(ucmessangeMem_Click);
                    frmmessange.pn_MessList.Controls.Add(ucmessange);
                }
            }
        }

        private void ucmessangeMem_Click(object sender, EventArgs e)
        {
            frmmessange.pn_Mess.Controls.Clear();
            mha = new XuLyAnh.MaHoaHinhAnh();
            string id = ((GUI.uc_Messange)sender).Tag.ToString();
            frmmessange.TeamChat = false;
            frmmessange.IdMember = id;
            string sqlquery = "select * from TinNhan where NguoiGui = " + id + " and NguoiNhan = " + caseData.DataTam.DuLieu.ID + " or NguoiGui = " + caseData.DataTam.DuLieu.ID + " and NguoiNhan = " + id ;
            DataTable dt = dalmessange.getMess(sqlquery);
            sqlquery = "select (HoThanhVien +' ' +TenThanhVien+' - '+ right(MSSV,4)) as HoTen from ThanhVien where IDThanhVien = " + id;
            string tenNguoiGui = dalmessange.getHoTen(sqlquery);
            frmmessange.lb_HoTen.Text = tenNguoiGui;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string noidung = dt.Rows[i]["NoiDung"].ToString();
                noidung = noidung.Substring(noidung.Split(':')[0].Length + 1, noidung.Length - noidung.Split(':')[0].Length - 1);

                addmessLoad(noidung, tenNguoiGui, dt.Rows[i]["NguoiGui"].ToString());
            }
        }

        private void addmessLoad(string mess, string name, string idmem)
        {
            if (mha.IsBase64String(mess.ToString()) && mess.Length > 200)
            {//đang ở đây
                pic_Image = new PictureBox();
                pic_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pic_Image.Location = new System.Drawing.Point(9, 6);
                pic_Image.Name = "pic_Image";
                pic_Image.Size = new System.Drawing.Size(157, 107);
                pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pic_Image.TabIndex = 4;
                pic_Image.Image = mha.ChuoiSangAnh(mess.ToString());
                pic_Image.TabStop = false;

                pn_Image = new Panel();
                pn_Image.Dock = System.Windows.Forms.DockStyle.Top;
                pn_Image.Location = new System.Drawing.Point(0, 57);
                pn_Image.Name = "pn_Image";
                pn_Image.Size = new System.Drawing.Size(756, 119);
                pn_Image.TabIndex = 5;

                pn_Image.Controls.Add(pic_Image);

                frmmessange.pn_Mess.Controls.Add(pn_Image);

                if (idmem.ToString() == caseData.DataTam.DuLieu.ID)
                {
                    pic_Image.Location = new Point(pn_Image.Size.Width - pic_Image.Size.Width - 30, pic_Image.Location.Y);
                }
            }
            else
            {
                messange = new TextBox();

                messange.BackColor = Color.White;
                messange.AllowDrop = true;
                messange.BorderStyle = BorderStyle.None;
                messange.Dock = System.Windows.Forms.DockStyle.Top;
                messange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                messange.Location = new System.Drawing.Point(0, 27);
                messange.Multiline = true;
                messange.Name = "messange";
                messange.ReadOnly = true;
                messange.Size = new System.Drawing.Size(756, 30);
                messange.TabIndex = 3;

                frmmessange.pn_Mess.Controls.Add(messange);

                if (idmem.ToString() == caseData.DataTam.DuLieu.ID)
                {
                    messange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                    messange.Text = "Bạn: " + mess;
                }
                else
                {
                    messange.Text = name + ": " + mess;
                }

                Size size = TextRenderer.MeasureText(messange.Text, messange.Font);
                messange.Width = size.Width - size.Width / 3;
                int linecount = mess.Split('\n').Length;
                messange.Height = size.Height + linecount * 26;
            }
            int change = frmmessange.pn_Mess.VerticalScroll.Value + frmmessange.VerticalScroll.SmallChange * 100;
            frmmessange.pn_Mess.AutoScrollPosition = new Point(0, change);
        }

        public void addmessReceive(string mess, string name, string idmem)
        {
            if (mha.IsBase64String(mess.ToString()) && mess.Length > 200)
            {//đang ở đây
                pic_Image = new PictureBox();
                pic_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pic_Image.Location = new System.Drawing.Point(9, 6);
                pic_Image.Name = "pic_Image";
                pic_Image.Size = new System.Drawing.Size(157, 107);
                pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pic_Image.TabIndex = 4;
                pic_Image.Image = mha.ChuoiSangAnh(mess.ToString());
                pic_Image.TabStop = false;

                pn_Image = new Panel();
                pn_Image.Dock = System.Windows.Forms.DockStyle.Bottom;
                pn_Image.Location = new System.Drawing.Point(0, 57);
                pn_Image.Name = "pn_Image";
                pn_Image.Size = new System.Drawing.Size(756, 119);
                pn_Image.TabIndex = 5;

                pn_Image.Controls.Add(pic_Image);

                frmmessange.BeginInvoke((Action)(() =>
                {
                    frmmessange.pn_Mess.Controls.Add(pn_Image);
                }));

                if (idmem.ToString() == caseData.DataTam.DuLieu.ID)
                {
                    pic_Image.Location = new Point(pn_Image.Size.Width - pic_Image.Size.Width - 30, pic_Image.Location.Y);
                }
            }
            else
            {
                messange = new TextBox();

                messange.BackColor = Color.White;
                messange.AllowDrop = true;
                messange.BorderStyle = BorderStyle.None;
                messange.Dock = System.Windows.Forms.DockStyle.Bottom;
                messange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                messange.Location = new System.Drawing.Point(0, 27);
                messange.Multiline = true;
                messange.Name = "messange";
                messange.ReadOnly = true;
                messange.Size = new System.Drawing.Size(756, 30);
                messange.TabIndex = 3;

                frmmessange.BeginInvoke((Action)(() =>
                {
                    frmmessange.pn_Mess.Controls.Add(messange);
                }));

                if (idmem.ToString() == caseData.DataTam.DuLieu.ID)
                {
                    messange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                    messange.Text = "Bạn: " + mess;
                }
                else
                {
                    messange.Text = name + ": " + mess;
                }

                Size size = TextRenderer.MeasureText(messange.Text, messange.Font);
                messange.Width = size.Width - size.Width / 3;
                int linecount = mess.Split('\n').Length;
                messange.Height = size.Height + linecount * 26;
            }
        }

        public void addmessSend(string mess, string name, string idmem)
        {
            if (mha.IsBase64String(mess.ToString()) && mess.Length > 200)
            {//đang ở đây
                pic_Image = new PictureBox();
                pic_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pic_Image.Location = new System.Drawing.Point(9, 6);
                pic_Image.Name = "pic_Image";
                pic_Image.Size = new System.Drawing.Size(157, 107);
                pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pic_Image.TabIndex = 4;
                pic_Image.Image = mha.ChuoiSangAnh(mess.ToString());
                pic_Image.TabStop = false;

                pn_Image = new Panel();
                pn_Image.Dock = System.Windows.Forms.DockStyle.Bottom;
                pn_Image.Location = new System.Drawing.Point(0, 57);
                pn_Image.Name = "pn_Image";
                pn_Image.Size = new System.Drawing.Size(756, 119);
                pn_Image.TabIndex = 5;

                pn_Image.Controls.Add(pic_Image);

                frmmessange.pn_Mess.Controls.Add(pn_Image);

                if (idmem.ToString() == caseData.DataTam.DuLieu.ID)
                {
                    pic_Image.Location = new Point(pn_Image.Size.Width - pic_Image.Size.Width - 30, pic_Image.Location.Y);
                }
            }
            else
            {
                messange = new TextBox();

                messange.BackColor = Color.White;
                messange.AllowDrop = true;
                messange.BorderStyle = BorderStyle.None;
                messange.Dock = System.Windows.Forms.DockStyle.Bottom;
                messange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                messange.Location = new System.Drawing.Point(0, 27);
                messange.Multiline = true;
                messange.Name = "messange";
                messange.ReadOnly = true;
                messange.Size = new System.Drawing.Size(756, 30);
                messange.TabIndex = 3;

                frmmessange.pn_Mess.Controls.Add(messange);

                if (idmem.ToString() == caseData.DataTam.DuLieu.ID)
                {
                    messange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                    messange.Text = "Bạn: " + mess;
                }
                else
                {
                    messange.Text = name + ": " + mess;
                }

                Size size = TextRenderer.MeasureText(messange.Text, messange.Font);
                messange.Width = size.Width - size.Width / 3;
                int linecount = mess.Split('\n').Length;
                messange.Height = size.Height + linecount * 26;
            }
        }

        private void loadListMesssTeam()
        {
            /*--------------Load nhóm---------------------*/
            string sqlquery = "select * from NhomChat";
            DataTable dt = dalmessange.getMess(sqlquery);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sqlquery = "select NoiDung,(TenThanhVien + '-' + right(MSSV,4) + ': ') as HoTen from NhomChat_TinNhan,ThanhVien where IDThanhVien = IDNguoiGui and IDTinNhan = (select Max(IDTinNhan) from NhomChat_TinNhan where NhomChat_TinNhan.IDNhomChat =" + dt.Rows[i]["IDNhom"].ToString() + ")";
                ucmessange = new GUI.uc_Messange();
                ucmessange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                ucmessange.Cursor = System.Windows.Forms.Cursors.Hand;
                ucmessange.Dock = System.Windows.Forms.DockStyle.Top;
                ucmessange.Location = new System.Drawing.Point(0, 0);
                ucmessange.Name = "uc_Messange1" + i;
                ucmessange.Size = new System.Drawing.Size(310, 61);
                ucmessange.TabIndex = i;
                DataTable dtsend = dalmessange.getMess(sqlquery);
                string noidung = dtsend.Rows[0]["NoiDung"].ToString();
                noidung = noidung.Substring(noidung.Split(':')[0].Length, noidung.Length - noidung.Split(':')[0].Length);
                if (mha.IsBase64String(noidung) && noidung.Length > 200)
                {
                    noidung = "Đã gửi 1 ảnh";
                }
                ucmessange.lb_ChatName.Text = dt.Rows[i]["TenNhom"].ToString();
                ucmessange.lb_NewMessage.Text = dtsend.Rows[0]["HoTen"].ToString() + noidung;
                ucmessange.Tag = dt.Rows[i]["IDNhom"].ToString();
                ucmessange.Click += new EventHandler(ucmessange_Click);
                frmmessange.pn_MessList.Controls.Add(ucmessange);
            }
        }

        public void loadAnh()
        {
            try
            {
                caseData.MoFile fopen = new caseData.MoFile();
                string imagelink = fopen.moFileAnh();
                XuLyAnh.CatAvatar resize = new XuLyAnh.CatAvatar();
                Image image = Image.FromFile(imagelink);
                int imagewidth = image.Size.Width, imageheight = image.Size.Height;
                frmmessange.pic_DinhKem.Image = resize.Resize(image as Bitmap, imagewidth / 5, imageheight / 5);
            }
            catch { }
        }

        public string getName(string id)
        {
            string sqlquery = "select (HoThanhVien +' ' +TenThanhVien+' - '+ right(MSSV,4)) as HoTen from ThanhVien where IDThanhVien = " + id;
            return dalmessange.getHoTen(sqlquery);
        }

        private void ucmessange_Click(object sender, EventArgs e)
        {
            frmmessange.pn_Mess.Controls.Clear();
            mha = new XuLyAnh.MaHoaHinhAnh();
            string id = ((GUI.uc_Messange)sender).Tag.ToString();
            frmmessange.TeamChat = true;
            frmmessange.IdMember = id;

            string sqlquery = "select count(IDTinNhan) from NhomChat_TinNhan";
            int soTinNhan = int.Parse(dalmessange.getHoTen(sqlquery));
            sqlquery = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ThoiGianGui) AS RowNum FROM dbo.NhomChat_TinNhan ) AS MyDerivedTable WHERE MyDerivedTable.RowNum BETWEEN " + (soTinNhan - 10) + " AND " + soTinNhan + " order by ThoiGianGui DESC";
            DataTable dt = dalmessange.getMess(sqlquery);

            frmmessange.lb_HoTen.Text = "Nhóm BCN";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tenNguoiGui = getName(dt.Rows[i]["IDNguoiGui"].ToString());
                string noidung = dt.Rows[i]["NoiDung"].ToString();
                noidung = noidung.Substring(noidung.Split(':')[0].Length + 1, noidung.Length - noidung.Split(':')[0].Length - 1);

                addmessLoad(noidung, tenNguoiGui, dt.Rows[i]["IDNguoiGui"].ToString());
            }

            int change = frmmessange.pn_Mess.VerticalScroll.Value + frmmessange.VerticalScroll.SmallChange * 100;
            frmmessange.pn_Mess.AutoScrollPosition = new Point(0, change);
        }
    }
}
