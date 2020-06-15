namespace CDIO_QLCLB.GUI
{
    partial class frm_AddMeetings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Browse = new System.Windows.Forms.Button();
            this.dtp_GioHop = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayHop = new System.Windows.Forms.DateTimePicker();
            this.tb_linkToTrinh = new System.Windows.Forms.TextBox();
            this.tb_TieuDe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_DiaChiCuThe = new System.Windows.Forms.TextBox();
            this.cbb_TenXa = new System.Windows.Forms.ComboBox();
            this.cbb_TenHuyen = new System.Windows.Forms.ComboBox();
            this.cbb_TenTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ccb_NguoiChuTri = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.bt_GuiThongBao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_PostFacebook = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Location = new System.Drawing.Point(73, 74);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(1273, 23);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "THÊM CUỘC HỌP";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.bt_Browse);
            this.panel2.Controls.Add(this.dtp_GioHop);
            this.panel2.Controls.Add(this.dtp_NgayHop);
            this.panel2.Controls.Add(this.tb_linkToTrinh);
            this.panel2.Controls.Add(this.tb_TieuDe);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ccb_NguoiChuTri);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(39, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 560);
            this.panel2.TabIndex = 3;
            // 
            // bt_Browse
            // 
            this.bt_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Browse.Location = new System.Drawing.Point(419, 481);
            this.bt_Browse.Name = "bt_Browse";
            this.bt_Browse.Size = new System.Drawing.Size(93, 34);
            this.bt_Browse.TabIndex = 9;
            this.bt_Browse.Text = "Browse...";
            this.bt_Browse.UseVisualStyleBackColor = true;
            this.bt_Browse.Click += new System.EventHandler(this.bt_Browse_Click);
            // 
            // dtp_GioHop
            // 
            this.dtp_GioHop.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_GioHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_GioHop.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_GioHop.Location = new System.Drawing.Point(390, 70);
            this.dtp_GioHop.Name = "dtp_GioHop";
            this.dtp_GioHop.Size = new System.Drawing.Size(122, 23);
            this.dtp_GioHop.TabIndex = 2;
            // 
            // dtp_NgayHop
            // 
            this.dtp_NgayHop.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayHop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayHop.Location = new System.Drawing.Point(164, 70);
            this.dtp_NgayHop.Name = "dtp_NgayHop";
            this.dtp_NgayHop.Size = new System.Drawing.Size(120, 23);
            this.dtp_NgayHop.TabIndex = 1;
            // 
            // tb_linkToTrinh
            // 
            this.tb_linkToTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_linkToTrinh.Location = new System.Drawing.Point(164, 485);
            this.tb_linkToTrinh.Name = "tb_linkToTrinh";
            this.tb_linkToTrinh.Size = new System.Drawing.Size(238, 23);
            this.tb_linkToTrinh.TabIndex = 8;
            // 
            // tb_TieuDe
            // 
            this.tb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TieuDe.Location = new System.Drawing.Point(164, 20);
            this.tb_TieuDe.Name = "tb_TieuDe";
            this.tb_TieuDe.Size = new System.Drawing.Size(348, 23);
            this.tb_TieuDe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_DiaChiCuThe);
            this.groupBox1.Controls.Add(this.cbb_TenXa);
            this.groupBox1.Controls.Add(this.cbb_TenHuyen);
            this.groupBox1.Controls.Add(this.cbb_TenTinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Địa chỉ";
            // 
            // tb_DiaChiCuThe
            // 
            this.tb_DiaChiCuThe.Location = new System.Drawing.Point(144, 181);
            this.tb_DiaChiCuThe.Multiline = true;
            this.tb_DiaChiCuThe.Name = "tb_DiaChiCuThe";
            this.tb_DiaChiCuThe.Size = new System.Drawing.Size(348, 81);
            this.tb_DiaChiCuThe.TabIndex = 6;
            // 
            // cbb_TenXa
            // 
            this.cbb_TenXa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TenXa.FormattingEnabled = true;
            this.cbb_TenXa.Location = new System.Drawing.Point(144, 131);
            this.cbb_TenXa.Name = "cbb_TenXa";
            this.cbb_TenXa.Size = new System.Drawing.Size(348, 25);
            this.cbb_TenXa.TabIndex = 5;
            // 
            // cbb_TenHuyen
            // 
            this.cbb_TenHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TenHuyen.FormattingEnabled = true;
            this.cbb_TenHuyen.Location = new System.Drawing.Point(144, 83);
            this.cbb_TenHuyen.Name = "cbb_TenHuyen";
            this.cbb_TenHuyen.Size = new System.Drawing.Size(348, 25);
            this.cbb_TenHuyen.TabIndex = 4;
            this.cbb_TenHuyen.SelectedIndexChanged += new System.EventHandler(this.cbb_TenHuyen_SelectedIndexChanged);
            // 
            // cbb_TenTinh
            // 
            this.cbb_TenTinh.BackColor = System.Drawing.Color.White;
            this.cbb_TenTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TenTinh.FormattingEnabled = true;
            this.cbb_TenTinh.Location = new System.Drawing.Point(144, 37);
            this.cbb_TenTinh.Name = "cbb_TenTinh";
            this.cbb_TenTinh.Size = new System.Drawing.Size(348, 25);
            this.cbb_TenTinh.TabIndex = 3;
            this.cbb_TenTinh.SelectedIndexChanged += new System.EventHandler(this.cbb_TenTinh_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ cụ thể:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Xã:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Huyện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tỉnh:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::CDIO_QLCLB.Properties.Resources.map;
            this.label10.Location = new System.Drawing.Point(73, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 33);
            this.label10.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tờ trình:";
            // 
            // ccb_NguoiChuTri
            // 
            this.ccb_NguoiChuTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_NguoiChuTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_NguoiChuTri.FormattingEnabled = true;
            this.ccb_NguoiChuTri.Location = new System.Drawing.Point(164, 434);
            this.ccb_NguoiChuTri.Name = "ccb_NguoiChuTri";
            this.ccb_NguoiChuTri.Size = new System.Drawing.Size(348, 25);
            this.ccb_NguoiChuTri.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Người chủ trì:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(312, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giờ họp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày họp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề cuộc họp:";
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NoiDung.Location = new System.Drawing.Point(632, 233);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.Size = new System.Drawing.Size(714, 388);
            this.tb_NoiDung.TabIndex = 10;
            // 
            // bt_GuiThongBao
            // 
            this.bt_GuiThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_GuiThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_GuiThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GuiThongBao.Image = global::CDIO_QLCLB.Properties.Resources.origami1;
            this.bt_GuiThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GuiThongBao.Location = new System.Drawing.Point(1198, 662);
            this.bt_GuiThongBao.Name = "bt_GuiThongBao";
            this.bt_GuiThongBao.Size = new System.Drawing.Size(148, 47);
            this.bt_GuiThongBao.TabIndex = 11;
            this.bt_GuiThongBao.Text = "Gửi SMS";
            this.bt_GuiThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_GuiThongBao.UseVisualStyleBackColor = true;
            this.bt_GuiThongBao.Click += new System.EventHandler(this.bt_GuiThongBao_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CDIO_QLCLB.Properties.Resources.littering;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(794, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Nhập lại";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Image = global::CDIO_QLCLB.Properties.Resources.save;
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(632, 662);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(137, 47);
            this.bt_Save.TabIndex = 11;
            this.bt_Save.Text = "Lưu";
            this.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Back
            // 
            this.bt_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Back.Image = global::CDIO_QLCLB.Properties.Resources.left_arrow;
            this.bt_Back.Location = new System.Drawing.Point(35, 65);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(32, 32);
            this.bt_Back.TabIndex = 0;
            this.bt_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::CDIO_QLCLB.Properties.Resources.notepad1;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(628, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nội dung cuộc họp:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_PostFacebook
            // 
            this.bt_PostFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_PostFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_PostFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PostFacebook.Image = global::CDIO_QLCLB.Properties.Resources.facebook_Blue;
            this.bt_PostFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_PostFacebook.Location = new System.Drawing.Point(976, 662);
            this.bt_PostFacebook.Name = "bt_PostFacebook";
            this.bt_PostFacebook.Size = new System.Drawing.Size(196, 47);
            this.bt_PostFacebook.TabIndex = 11;
            this.bt_PostFacebook.Text = "Đăng Facebook";
            this.bt_PostFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_PostFacebook.UseVisualStyleBackColor = true;
            this.bt_PostFacebook.Click += new System.EventHandler(this.bt_PostFacebook_Click);
            // 
            // frm_AddMeetings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 756);
            this.ControlBox = false;
            this.Controls.Add(this.bt_PostFacebook);
            this.Controls.Add(this.bt_GuiThongBao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.tb_NoiDung);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.lb_TieuDe);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddMeetings";
            this.Text = "Thêm cuộc họp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_AddMeetings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bt_Back;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox tb_TieuDe;
        protected internal System.Windows.Forms.DateTimePicker dtp_NgayHop;
        protected internal System.Windows.Forms.ComboBox cbb_TenTinh;
        protected internal System.Windows.Forms.ComboBox cbb_TenXa;
        protected internal System.Windows.Forms.ComboBox cbb_TenHuyen;
        protected internal System.Windows.Forms.TextBox tb_DiaChiCuThe;
        private System.Windows.Forms.Button bt_Browse;
        private System.Windows.Forms.Label label11;
        protected internal System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.ComboBox ccb_NguoiChuTri;
        protected internal System.Windows.Forms.TextBox tb_linkToTrinh;
        protected internal System.Windows.Forms.DateTimePicker dtp_GioHop;
        private System.Windows.Forms.Button bt_GuiThongBao;
        private System.Windows.Forms.Button bt_PostFacebook;
    }
}