using System.Drawing;
namespace CDIO_QLCLB.GUI
{
    partial class frm_Home
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
            this.components = new System.ComponentModel.Container();
            this.pn_Top = new System.Windows.Forms.Panel();
            this.lb_ThoiTiet = new System.Windows.Forms.Label();
            this.pn_ThoiTiet = new System.Windows.Forms.Panel();
            this.pn_KHSapToi = new System.Windows.Forms.Panel();
            this.pn_ThongBaoMoi = new System.Windows.Forms.Panel();
            this.pn_ThongKeSoBo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_moneyeSMS = new System.Windows.Forms.Label();
            this.lb_QuyXuat = new System.Windows.Forms.Label();
            this.lb_QuyNhap = new System.Windows.Forms.Label();
            this.lb_QuyHienTai = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_DaRoiCLB = new System.Windows.Forms.Label();
            this.lb_SoLuongCTV = new System.Windows.Forms.Label();
            this.lb_TyLeNamNu = new System.Windows.Forms.Label();
            this.lb_SoLuongTV = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_DKMoi = new System.Windows.Forms.Panel();
            this.pn_PhimTat = new System.Windows.Forms.Panel();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.bt_XuatQuy = new System.Windows.Forms.Button();
            this.bt_NhapQuy = new System.Windows.Forms.Button();
            this.bt_LapKH = new System.Windows.Forms.Button();
            this.bt_QLNhom = new System.Windows.Forms.Button();
            this.bt_ThemThanhVien = new System.Windows.Forms.Button();
            this.bt_LenLichHop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.loadThoiTiet = new System.Windows.Forms.Timer(this.components);
            this.loadWeather2h = new System.Windows.Forms.Timer(this.components);
            this.loadThongBao = new System.Windows.Forms.Timer(this.components);
            this.loadSignUp = new System.Windows.Forms.Timer(this.components);
            this.lb_DemDK = new System.Windows.Forms.Label();
            this.lb_ThongKe = new System.Windows.Forms.Label();
            this.lb_DemNen = new System.Windows.Forms.Label();
            this.lb_Sigup = new System.Windows.Forms.Label();
            this.lb_ThongBao = new System.Windows.Forms.Label();
            this.lb_KeHoach = new System.Windows.Forms.Label();
            this.uc_userInfo1 = new CDIO_QLCLB.GUI.uc_userInfo();
            this.pn_Top.SuspendLayout();
            this.pn_ThongKeSoBo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_PhimTat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Top
            // 
            this.pn_Top.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pn_Top.Controls.Add(this.lb_ThoiTiet);
            this.pn_Top.Controls.Add(this.pn_ThoiTiet);
            this.pn_Top.Controls.Add(this.uc_userInfo1);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(1436, 141);
            this.pn_Top.TabIndex = 1;
            // 
            // lb_ThoiTiet
            // 
            this.lb_ThoiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ThoiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.lb_ThoiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ThoiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThoiTiet.Image = global::CDIO_QLCLB.Properties.Resources.sun;
            this.lb_ThoiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_ThoiTiet.Location = new System.Drawing.Point(458, 13);
            this.lb_ThoiTiet.Name = "lb_ThoiTiet";
            this.lb_ThoiTiet.Size = new System.Drawing.Size(968, 29);
            this.lb_ThoiTiet.TabIndex = 0;
            this.lb_ThoiTiet.Text = "Thời Tiết";
            this.lb_ThoiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_ThoiTiet
            // 
            this.pn_ThoiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ThoiTiet.AutoSize = true;
            this.pn_ThoiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThoiTiet.Location = new System.Drawing.Point(458, 41);
            this.pn_ThoiTiet.Name = "pn_ThoiTiet";
            this.pn_ThoiTiet.Size = new System.Drawing.Size(968, 88);
            this.pn_ThoiTiet.TabIndex = 1;
            // 
            // pn_KHSapToi
            // 
            this.pn_KHSapToi.AutoScroll = true;
            this.pn_KHSapToi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_KHSapToi.Location = new System.Drawing.Point(291, 212);
            this.pn_KHSapToi.Name = "pn_KHSapToi";
            this.pn_KHSapToi.Size = new System.Drawing.Size(655, 245);
            this.pn_KHSapToi.TabIndex = 2;
            this.pn_KHSapToi.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_KHSapToi_Paint);
            // 
            // pn_ThongBaoMoi
            // 
            this.pn_ThongBaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ThongBaoMoi.AutoScroll = true;
            this.pn_ThongBaoMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThongBaoMoi.Location = new System.Drawing.Point(955, 211);
            this.pn_ThongBaoMoi.Name = "pn_ThongBaoMoi";
            this.pn_ThongBaoMoi.Size = new System.Drawing.Size(468, 247);
            this.pn_ThongBaoMoi.TabIndex = 2;
            // 
            // pn_ThongKeSoBo
            // 
            this.pn_ThongKeSoBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_ThongKeSoBo.AutoScroll = true;
            this.pn_ThongKeSoBo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThongKeSoBo.Controls.Add(this.panel3);
            this.pn_ThongKeSoBo.Controls.Add(this.panel2);
            this.pn_ThongKeSoBo.Location = new System.Drawing.Point(291, 511);
            this.pn_ThongKeSoBo.Name = "pn_ThongKeSoBo";
            this.pn_ThongKeSoBo.Size = new System.Drawing.Size(655, 175);
            this.pn_ThongKeSoBo.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lb_moneyeSMS);
            this.panel3.Controls.Add(this.lb_QuyXuat);
            this.panel3.Controls.Add(this.lb_QuyNhap);
            this.panel3.Controls.Add(this.lb_QuyHienTai);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 124);
            this.panel3.TabIndex = 0;
            // 
            // lb_moneyeSMS
            // 
            this.lb_moneyeSMS.AutoSize = true;
            this.lb_moneyeSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_moneyeSMS.Location = new System.Drawing.Point(369, 59);
            this.lb_moneyeSMS.Name = "lb_moneyeSMS";
            this.lb_moneyeSMS.Size = new System.Drawing.Size(112, 20);
            this.lb_moneyeSMS.TabIndex = 1;
            this.lb_moneyeSMS.Text = "Số dư eSMS: ";
            // 
            // lb_QuyXuat
            // 
            this.lb_QuyXuat.AutoSize = true;
            this.lb_QuyXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuyXuat.Location = new System.Drawing.Point(369, 95);
            this.lb_QuyXuat.Name = "lb_QuyXuat";
            this.lb_QuyXuat.Size = new System.Drawing.Size(85, 20);
            this.lb_QuyXuat.TabIndex = 1;
            this.lb_QuyXuat.Text = "Quỹ xuất: ";
            // 
            // lb_QuyNhap
            // 
            this.lb_QuyNhap.AutoSize = true;
            this.lb_QuyNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuyNhap.Location = new System.Drawing.Point(8, 95);
            this.lb_QuyNhap.Name = "lb_QuyNhap";
            this.lb_QuyNhap.Size = new System.Drawing.Size(90, 20);
            this.lb_QuyNhap.TabIndex = 1;
            this.lb_QuyNhap.Text = "Quỹ nhập: ";
            // 
            // lb_QuyHienTai
            // 
            this.lb_QuyHienTai.AutoSize = true;
            this.lb_QuyHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuyHienTai.Location = new System.Drawing.Point(3, 59);
            this.lb_QuyHienTai.Name = "lb_QuyHienTai";
            this.lb_QuyHienTai.Size = new System.Drawing.Size(122, 20);
            this.lb_QuyHienTai.TabIndex = 1;
            this.lb_QuyHienTai.Text = "Quỹ hiện tại: ";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::CDIO_QLCLB.Properties.Resources.bars;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(632, 47);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tiền Quỹ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lb_DaRoiCLB);
            this.panel2.Controls.Add(this.lb_SoLuongCTV);
            this.panel2.Controls.Add(this.lb_TyLeNamNu);
            this.panel2.Controls.Add(this.lb_SoLuongTV);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 124);
            this.panel2.TabIndex = 0;
            // 
            // lb_DaRoiCLB
            // 
            this.lb_DaRoiCLB.AutoSize = true;
            this.lb_DaRoiCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DaRoiCLB.Location = new System.Drawing.Point(369, 97);
            this.lb_DaRoiCLB.Name = "lb_DaRoiCLB";
            this.lb_DaRoiCLB.Size = new System.Drawing.Size(103, 20);
            this.lb_DaRoiCLB.TabIndex = 1;
            this.lb_DaRoiCLB.Text = "Đã rời CLB: ";
            // 
            // lb_SoLuongCTV
            // 
            this.lb_SoLuongCTV.AutoSize = true;
            this.lb_SoLuongCTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuongCTV.Location = new System.Drawing.Point(3, 97);
            this.lb_SoLuongCTV.Name = "lb_SoLuongCTV";
            this.lb_SoLuongCTV.Size = new System.Drawing.Size(122, 20);
            this.lb_SoLuongCTV.TabIndex = 1;
            this.lb_SoLuongCTV.Text = "Số lượng CTV: ";
            // 
            // lb_TyLeNamNu
            // 
            this.lb_TyLeNamNu.AutoSize = true;
            this.lb_TyLeNamNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TyLeNamNu.Location = new System.Drawing.Point(369, 61);
            this.lb_TyLeNamNu.Name = "lb_TyLeNamNu";
            this.lb_TyLeNamNu.Size = new System.Drawing.Size(121, 20);
            this.lb_TyLeNamNu.TabIndex = 1;
            this.lb_TyLeNamNu.Text = "Tỷ lệ Nam/Nữ: ";
            // 
            // lb_SoLuongTV
            // 
            this.lb_SoLuongTV.AutoSize = true;
            this.lb_SoLuongTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuongTV.Location = new System.Drawing.Point(3, 61);
            this.lb_SoLuongTV.Name = "lb_SoLuongTV";
            this.lb_SoLuongTV.Size = new System.Drawing.Size(165, 20);
            this.lb_SoLuongTV.TabIndex = 1;
            this.lb_SoLuongTV.Text = "Số lượng thành viên: ";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::CDIO_QLCLB.Properties.Resources.analyst__1_;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(632, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thành Viên";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_DKMoi
            // 
            this.pn_DKMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_DKMoi.AutoScroll = true;
            this.pn_DKMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_DKMoi.Location = new System.Drawing.Point(956, 511);
            this.pn_DKMoi.Name = "pn_DKMoi";
            this.pn_DKMoi.Size = new System.Drawing.Size(468, 175);
            this.pn_DKMoi.TabIndex = 2;
            // 
            // pn_PhimTat
            // 
            this.pn_PhimTat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_PhimTat.AutoScroll = true;
            this.pn_PhimTat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_PhimTat.Controls.Add(this.bt_Logout);
            this.pn_PhimTat.Controls.Add(this.bt_XuatQuy);
            this.pn_PhimTat.Controls.Add(this.bt_NhapQuy);
            this.pn_PhimTat.Controls.Add(this.bt_LapKH);
            this.pn_PhimTat.Controls.Add(this.bt_QLNhom);
            this.pn_PhimTat.Controls.Add(this.bt_ThemThanhVien);
            this.pn_PhimTat.Controls.Add(this.bt_LenLichHop);
            this.pn_PhimTat.Controls.Add(this.label6);
            this.pn_PhimTat.Location = new System.Drawing.Point(12, 165);
            this.pn_PhimTat.Name = "pn_PhimTat";
            this.pn_PhimTat.Size = new System.Drawing.Size(274, 521);
            this.pn_PhimTat.TabIndex = 2;
            // 
            // bt_Logout
            // 
            this.bt_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Logout.Image = global::CDIO_QLCLB.Properties.Resources.logout;
            this.bt_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Logout.Location = new System.Drawing.Point(3, 463);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(242, 50);
            this.bt_Logout.TabIndex = 1;
            this.bt_Logout.Text = "Đăng Xuất";
            this.bt_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Logout.UseVisualStyleBackColor = true;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // bt_XuatQuy
            // 
            this.bt_XuatQuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_XuatQuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_XuatQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_XuatQuy.Image = global::CDIO_QLCLB.Properties.Resources.value;
            this.bt_XuatQuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_XuatQuy.Location = new System.Drawing.Point(3, 395);
            this.bt_XuatQuy.Name = "bt_XuatQuy";
            this.bt_XuatQuy.Size = new System.Drawing.Size(242, 50);
            this.bt_XuatQuy.TabIndex = 1;
            this.bt_XuatQuy.Text = "Xuất Quỹ";
            this.bt_XuatQuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_XuatQuy.UseVisualStyleBackColor = true;
            this.bt_XuatQuy.Click += new System.EventHandler(this.bt_XuatQuy_Click);
            // 
            // bt_NhapQuy
            // 
            this.bt_NhapQuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_NhapQuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_NhapQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NhapQuy.Image = global::CDIO_QLCLB.Properties.Resources.money;
            this.bt_NhapQuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_NhapQuy.Location = new System.Drawing.Point(3, 325);
            this.bt_NhapQuy.Name = "bt_NhapQuy";
            this.bt_NhapQuy.Size = new System.Drawing.Size(242, 50);
            this.bt_NhapQuy.TabIndex = 1;
            this.bt_NhapQuy.Text = "Nhập Quỹ";
            this.bt_NhapQuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_NhapQuy.UseVisualStyleBackColor = true;
            this.bt_NhapQuy.Click += new System.EventHandler(this.bt_NhapQuy_Click);
            // 
            // bt_LapKH
            // 
            this.bt_LapKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_LapKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_LapKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LapKH.Image = global::CDIO_QLCLB.Properties.Resources.planning;
            this.bt_LapKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LapKH.Location = new System.Drawing.Point(3, 254);
            this.bt_LapKH.Name = "bt_LapKH";
            this.bt_LapKH.Size = new System.Drawing.Size(242, 50);
            this.bt_LapKH.TabIndex = 1;
            this.bt_LapKH.Text = "Lập Kế Hoạch";
            this.bt_LapKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_LapKH.UseVisualStyleBackColor = true;
            this.bt_LapKH.Click += new System.EventHandler(this.bt_LapKH_Click);
            // 
            // bt_QLNhom
            // 
            this.bt_QLNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_QLNhom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_QLNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_QLNhom.Image = global::CDIO_QLCLB.Properties.Resources.teamwork;
            this.bt_QLNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_QLNhom.Location = new System.Drawing.Point(3, 183);
            this.bt_QLNhom.Name = "bt_QLNhom";
            this.bt_QLNhom.Size = new System.Drawing.Size(242, 50);
            this.bt_QLNhom.TabIndex = 1;
            this.bt_QLNhom.Text = "Quản Lý Nhóm";
            this.bt_QLNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_QLNhom.UseVisualStyleBackColor = true;
            this.bt_QLNhom.Click += new System.EventHandler(this.bt_QLNhom_Click);
            // 
            // bt_ThemThanhVien
            // 
            this.bt_ThemThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ThemThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ThemThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThemThanhVien.Image = global::CDIO_QLCLB.Properties.Resources.teacher;
            this.bt_ThemThanhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ThemThanhVien.Location = new System.Drawing.Point(3, 110);
            this.bt_ThemThanhVien.Name = "bt_ThemThanhVien";
            this.bt_ThemThanhVien.Size = new System.Drawing.Size(242, 50);
            this.bt_ThemThanhVien.TabIndex = 1;
            this.bt_ThemThanhVien.Text = "Thêm Thành Viên";
            this.bt_ThemThanhVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ThemThanhVien.UseVisualStyleBackColor = true;
            this.bt_ThemThanhVien.Click += new System.EventHandler(this.bt_ThemThanhVien_Click);
            // 
            // bt_LenLichHop
            // 
            this.bt_LenLichHop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_LenLichHop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_LenLichHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LenLichHop.Image = global::CDIO_QLCLB.Properties.Resources.work;
            this.bt_LenLichHop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LenLichHop.Location = new System.Drawing.Point(3, 40);
            this.bt_LenLichHop.Name = "bt_LenLichHop";
            this.bt_LenLichHop.Size = new System.Drawing.Size(242, 50);
            this.bt_LenLichHop.TabIndex = 1;
            this.bt_LenLichHop.Text = "Lên Lịch Họp";
            this.bt_LenLichHop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_LenLichHop.UseVisualStyleBackColor = true;
            this.bt_LenLichHop.Click += new System.EventHandler(this.bt_LenLichHop_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phím Tắt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadThoiTiet
            // 
            this.loadThoiTiet.Enabled = true;
            this.loadThoiTiet.Interval = 1000;
            this.loadThoiTiet.Tick += new System.EventHandler(this.loadThoiTiet_Tick);
            // 
            // loadWeather2h
            // 
            this.loadWeather2h.Enabled = true;
            this.loadWeather2h.Interval = 3600000;
            this.loadWeather2h.Tick += new System.EventHandler(this.loadWeather2h_Tick);
            // 
            // loadThongBao
            // 
            this.loadThongBao.Enabled = true;
            this.loadThongBao.Interval = 30000;
            this.loadThongBao.Tick += new System.EventHandler(this.loadThongBao_Tick);
            // 
            // loadSignUp
            // 
            this.loadSignUp.Enabled = true;
            this.loadSignUp.Interval = 30000;
            this.loadSignUp.Tick += new System.EventHandler(this.loadSignUp_Tick);
            // 
            // lb_DemDK
            // 
            this.lb_DemDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DemDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lb_DemDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DemDK.ForeColor = System.Drawing.Color.White;
            this.lb_DemDK.Location = new System.Drawing.Point(1382, 476);
            this.lb_DemDK.Name = "lb_DemDK";
            this.lb_DemDK.Size = new System.Drawing.Size(34, 26);
            this.lb_DemDK.TabIndex = 4;
            this.lb_DemDK.Text = "0";
            this.lb_DemDK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ThongKe
            // 
            this.lb_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(46)))));
            this.lb_ThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongKe.Image = global::CDIO_QLCLB.Properties.Resources.bar_chart;
            this.lb_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_ThongKe.Location = new System.Drawing.Point(292, 464);
            this.lb_ThongKe.Name = "lb_ThongKe";
            this.lb_ThongKe.Size = new System.Drawing.Size(655, 48);
            this.lb_ThongKe.TabIndex = 0;
            this.lb_ThongKe.Text = "Thống Kê Sơ Bộ";
            this.lb_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DemNen
            // 
            this.lb_DemNen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DemNen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(205)))), ((int)(((byte)(76)))));
            this.lb_DemNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DemNen.Image = global::CDIO_QLCLB.Properties.Resources.circle;
            this.lb_DemNen.Location = new System.Drawing.Point(1375, 466);
            this.lb_DemNen.Name = "lb_DemNen";
            this.lb_DemNen.Size = new System.Drawing.Size(45, 45);
            this.lb_DemNen.TabIndex = 4;
            this.lb_DemNen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Sigup
            // 
            this.lb_Sigup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Sigup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(205)))), ((int)(((byte)(76)))));
            this.lb_Sigup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Sigup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sigup.Image = global::CDIO_QLCLB.Properties.Resources.membership;
            this.lb_Sigup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_Sigup.Location = new System.Drawing.Point(956, 465);
            this.lb_Sigup.Name = "lb_Sigup";
            this.lb_Sigup.Size = new System.Drawing.Size(467, 47);
            this.lb_Sigup.TabIndex = 0;
            this.lb_Sigup.Text = "Đăng Ký Mới Chưa Duyệt";
            this.lb_Sigup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ThongBao
            // 
            this.lb_ThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.lb_ThongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongBao.Image = global::CDIO_QLCLB.Properties.Resources.shout;
            this.lb_ThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_ThongBao.Location = new System.Drawing.Point(956, 165);
            this.lb_ThongBao.Name = "lb_ThongBao";
            this.lb_ThongBao.Size = new System.Drawing.Size(466, 47);
            this.lb_ThongBao.TabIndex = 0;
            this.lb_ThongBao.Text = "Thông Báo Mới";
            this.lb_ThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_KeHoach
            // 
            this.lb_KeHoach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(210)))), ((int)(((byte)(209)))));
            this.lb_KeHoach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_KeHoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KeHoach.Image = global::CDIO_QLCLB.Properties.Resources.planning;
            this.lb_KeHoach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_KeHoach.Location = new System.Drawing.Point(291, 164);
            this.lb_KeHoach.Name = "lb_KeHoach";
            this.lb_KeHoach.Size = new System.Drawing.Size(654, 48);
            this.lb_KeHoach.TabIndex = 0;
            this.lb_KeHoach.Text = "Kế Hoạch Săp Tới";
            this.lb_KeHoach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_userInfo1
            // 
            this.uc_userInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uc_userInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_userInfo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uc_userInfo1.Location = new System.Drawing.Point(12, 13);
            this.uc_userInfo1.Name = "uc_userInfo1";
            this.uc_userInfo1.Size = new System.Drawing.Size(408, 116);
            this.uc_userInfo1.TabIndex = 0;
            this.uc_userInfo1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uc_userInfo1_MouseClick);
            // 
            // frm_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1436, 698);
            this.ControlBox = false;
            this.Controls.Add(this.lb_ThongKe);
            this.Controls.Add(this.lb_DemDK);
            this.Controls.Add(this.lb_DemNen);
            this.Controls.Add(this.lb_Sigup);
            this.Controls.Add(this.lb_ThongBao);
            this.Controls.Add(this.pn_DKMoi);
            this.Controls.Add(this.pn_ThongKeSoBo);
            this.Controls.Add(this.lb_KeHoach);
            this.Controls.Add(this.pn_PhimTat);
            this.Controls.Add(this.pn_ThongBaoMoi);
            this.Controls.Add(this.pn_KHSapToi);
            this.Controls.Add(this.pn_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Index_Load);
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.pn_ThongKeSoBo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_PhimTat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private uc_userInfo uc_userInfo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_LenLichHop;
        private System.Windows.Forms.Button bt_ThemThanhVien;
        private System.Windows.Forms.Button bt_LapKH;
        private System.Windows.Forms.Button bt_QLNhom;
        private System.Windows.Forms.Button bt_NhapQuy;
        private System.Windows.Forms.Button bt_XuatQuy;
        protected internal System.Windows.Forms.Panel pn_ThoiTiet;
        protected internal System.Windows.Forms.Panel pn_KHSapToi;
        protected internal System.Windows.Forms.Panel pn_ThongBaoMoi;
        protected internal System.Windows.Forms.Panel pn_ThongKeSoBo;
        protected internal System.Windows.Forms.Panel pn_DKMoi;
        private System.Windows.Forms.Timer loadThoiTiet;
        private System.Windows.Forms.Timer loadWeather2h;
        private System.Windows.Forms.Timer loadThongBao;
        private System.Windows.Forms.Timer loadSignUp;
        protected internal System.Windows.Forms.Label lb_DemDK;
        private System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.Label lb_QuyXuat;
        protected internal System.Windows.Forms.Label lb_QuyNhap;
        protected internal System.Windows.Forms.Label lb_QuyHienTai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Label lb_DaRoiCLB;
        protected internal System.Windows.Forms.Label lb_SoLuongCTV;
        protected internal System.Windows.Forms.Label lb_TyLeNamNu;
        protected internal System.Windows.Forms.Label lb_SoLuongTV;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.Label lb_moneyeSMS;
        private System.Windows.Forms.Button bt_Logout;
        protected internal System.Windows.Forms.Panel pn_PhimTat;
        protected internal System.Windows.Forms.Panel pn_Top;
        protected internal System.Windows.Forms.Label lb_KeHoach;
        protected internal System.Windows.Forms.Label lb_ThongBao;
        protected internal System.Windows.Forms.Label lb_Sigup;
        protected internal System.Windows.Forms.Label lb_ThongKe;
        protected internal System.Windows.Forms.Label lb_ThoiTiet;
        protected internal System.Windows.Forms.Label lb_DemNen;
    }
}