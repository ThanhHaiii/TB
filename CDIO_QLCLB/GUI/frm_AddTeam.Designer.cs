﻿namespace CDIO_QLCLB.GUI
{
    partial class frm_AddTeam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_DanhGia = new System.Windows.Forms.Button();
            this.bt_DiemDanh = new System.Windows.Forms.Button();
            this.bt_PhanCong = new System.Windows.Forms.Button();
            this.tb_SuaNhom = new System.Windows.Forms.Button();
            this.tb_TaoNhom = new System.Windows.Forms.Button();
            this.pn_AddTeam = new System.Windows.Forms.Panel();
            this.cbb_AddNhomTruong = new System.Windows.Forms.ComboBox();
            this.tb_AddTenNhom = new System.Windows.Forms.TextBox();
            this.cbb_AddListMember = new System.Windows.Forms.ComboBox();
            this.dtg_AddThanhVien = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_ThemThanhVien = new System.Windows.Forms.Button();
            this.bt_AddTaoNhom = new System.Windows.Forms.Button();
            this.bt_AddDeletemember = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Back = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pn_AddTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AddThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_TieuDe.Location = new System.Drawing.Point(73, 65);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(1210, 39);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "TẠO NHÓM MỚI";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bt_DanhGia);
            this.panel2.Controls.Add(this.bt_DiemDanh);
            this.panel2.Controls.Add(this.bt_PhanCong);
            this.panel2.Controls.Add(this.tb_SuaNhom);
            this.panel2.Controls.Add(this.tb_TaoNhom);
            this.panel2.Location = new System.Drawing.Point(39, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 373);
            this.panel2.TabIndex = 0;
            // 
            // bt_DanhGia
            // 
            this.bt_DanhGia.BackColor = System.Drawing.Color.White;
            this.bt_DanhGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DanhGia.Image = global::CDIO_QLCLB.Properties.Resources.evaluate;
            this.bt_DanhGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DanhGia.Location = new System.Drawing.Point(3, 267);
            this.bt_DanhGia.Name = "bt_DanhGia";
            this.bt_DanhGia.Size = new System.Drawing.Size(193, 42);
            this.bt_DanhGia.TabIndex = 0;
            this.bt_DanhGia.Text = "Đánh giá";
            this.bt_DanhGia.UseVisualStyleBackColor = false;
            // 
            // bt_DiemDanh
            // 
            this.bt_DiemDanh.BackColor = System.Drawing.Color.White;
            this.bt_DiemDanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DiemDanh.Image = global::CDIO_QLCLB.Properties.Resources.shift;
            this.bt_DiemDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DiemDanh.Location = new System.Drawing.Point(3, 202);
            this.bt_DiemDanh.Name = "bt_DiemDanh";
            this.bt_DiemDanh.Size = new System.Drawing.Size(193, 42);
            this.bt_DiemDanh.TabIndex = 0;
            this.bt_DiemDanh.Text = "Điểm danh";
            this.bt_DiemDanh.UseVisualStyleBackColor = false;
            this.bt_DiemDanh.Click += new System.EventHandler(this.bt_DiemDanh_Click);
            // 
            // bt_PhanCong
            // 
            this.bt_PhanCong.BackColor = System.Drawing.Color.White;
            this.bt_PhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_PhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PhanCong.Image = global::CDIO_QLCLB.Properties.Resources.boss;
            this.bt_PhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_PhanCong.Location = new System.Drawing.Point(3, 137);
            this.bt_PhanCong.Name = "bt_PhanCong";
            this.bt_PhanCong.Size = new System.Drawing.Size(193, 42);
            this.bt_PhanCong.TabIndex = 0;
            this.bt_PhanCong.Text = "Phân công";
            this.bt_PhanCong.UseVisualStyleBackColor = false;
            this.bt_PhanCong.Click += new System.EventHandler(this.bt_PhanCong_Click);
            // 
            // tb_SuaNhom
            // 
            this.tb_SuaNhom.BackColor = System.Drawing.Color.White;
            this.tb_SuaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_SuaNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_SuaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SuaNhom.Image = global::CDIO_QLCLB.Properties.Resources.editTeam;
            this.tb_SuaNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_SuaNhom.Location = new System.Drawing.Point(3, 73);
            this.tb_SuaNhom.Name = "tb_SuaNhom";
            this.tb_SuaNhom.Size = new System.Drawing.Size(193, 42);
            this.tb_SuaNhom.TabIndex = 0;
            this.tb_SuaNhom.Text = "Sửa nhóm";
            this.tb_SuaNhom.UseVisualStyleBackColor = false;
            this.tb_SuaNhom.Click += new System.EventHandler(this.tb_SuaNhom_Click);
            // 
            // tb_TaoNhom
            // 
            this.tb_TaoNhom.BackColor = System.Drawing.Color.White;
            this.tb_TaoNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_TaoNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_TaoNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TaoNhom.Image = global::CDIO_QLCLB.Properties.Resources.addTeam;
            this.tb_TaoNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_TaoNhom.Location = new System.Drawing.Point(3, 11);
            this.tb_TaoNhom.Name = "tb_TaoNhom";
            this.tb_TaoNhom.Size = new System.Drawing.Size(193, 42);
            this.tb_TaoNhom.TabIndex = 0;
            this.tb_TaoNhom.Text = "Tạo nhóm";
            this.tb_TaoNhom.UseVisualStyleBackColor = false;
            // 
            // pn_AddTeam
            // 
            this.pn_AddTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_AddTeam.AutoScroll = true;
            this.pn_AddTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_AddTeam.Controls.Add(this.cbb_AddNhomTruong);
            this.pn_AddTeam.Controls.Add(this.tb_AddTenNhom);
            this.pn_AddTeam.Controls.Add(this.cbb_AddListMember);
            this.pn_AddTeam.Controls.Add(this.dtg_AddThanhVien);
            this.pn_AddTeam.Controls.Add(this.bt_ThemThanhVien);
            this.pn_AddTeam.Controls.Add(this.bt_AddTaoNhom);
            this.pn_AddTeam.Controls.Add(this.bt_AddDeletemember);
            this.pn_AddTeam.Controls.Add(this.label3);
            this.pn_AddTeam.Controls.Add(this.label4);
            this.pn_AddTeam.Controls.Add(this.label2);
            this.pn_AddTeam.Location = new System.Drawing.Point(296, 147);
            this.pn_AddTeam.Name = "pn_AddTeam";
            this.pn_AddTeam.Size = new System.Drawing.Size(1004, 373);
            this.pn_AddTeam.TabIndex = 4;
            // 
            // cbb_AddNhomTruong
            // 
            this.cbb_AddNhomTruong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_AddNhomTruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_AddNhomTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_AddNhomTruong.FormattingEnabled = true;
            this.cbb_AddNhomTruong.Location = new System.Drawing.Point(679, 27);
            this.cbb_AddNhomTruong.Name = "cbb_AddNhomTruong";
            this.cbb_AddNhomTruong.Size = new System.Drawing.Size(298, 28);
            this.cbb_AddNhomTruong.TabIndex = 7;
            // 
            // tb_AddTenNhom
            // 
            this.tb_AddTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AddTenNhom.Location = new System.Drawing.Point(132, 27);
            this.tb_AddTenNhom.Name = "tb_AddTenNhom";
            this.tb_AddTenNhom.Size = new System.Drawing.Size(265, 27);
            this.tb_AddTenNhom.TabIndex = 6;
            // 
            // cbb_AddListMember
            // 
            this.cbb_AddListMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_AddListMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_AddListMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_AddListMember.FormattingEnabled = true;
            this.cbb_AddListMember.Location = new System.Drawing.Point(405, 325);
            this.cbb_AddListMember.Name = "cbb_AddListMember";
            this.cbb_AddListMember.Size = new System.Drawing.Size(358, 26);
            this.cbb_AddListMember.TabIndex = 5;
            // 
            // dtg_AddThanhVien
            // 
            this.dtg_AddThanhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_AddThanhVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AddThanhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_AddThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_AddThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ho,
            this.ten,
            this.MaSV,
            this.GioiTinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_AddThanhVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_AddThanhVien.Location = new System.Drawing.Point(32, 120);
            this.dtg_AddThanhVien.Name = "dtg_AddThanhVien";
            this.dtg_AddThanhVien.RowHeadersWidth = 51;
            this.dtg_AddThanhVien.RowTemplate.Height = 24;
            this.dtg_AddThanhVien.Size = new System.Drawing.Size(945, 181);
            this.dtg_AddThanhVien.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 24;
            // 
            // ho
            // 
            this.ho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ho.HeaderText = "Họ";
            this.ho.MinimumWidth = 6;
            this.ho.Name = "ho";
            this.ho.ReadOnly = true;
            this.ho.Width = 59;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 65;
            // 
            // MaSV
            // 
            this.MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaSV.HeaderText = "MSSV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 83;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // bt_ThemThanhVien
            // 
            this.bt_ThemThanhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ThemThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThemThanhVien.Image = global::CDIO_QLCLB.Properties.Resources.membership;
            this.bt_ThemThanhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ThemThanhVien.Location = new System.Drawing.Point(793, 318);
            this.bt_ThemThanhVien.Name = "bt_ThemThanhVien";
            this.bt_ThemThanhVien.Size = new System.Drawing.Size(184, 41);
            this.bt_ThemThanhVien.TabIndex = 4;
            this.bt_ThemThanhVien.Text = "Thêm Thành Viên";
            this.bt_ThemThanhVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ThemThanhVien.UseVisualStyleBackColor = true;
            this.bt_ThemThanhVien.Click += new System.EventHandler(this.bt_ThemThanhVien_Click);
            // 
            // bt_AddTaoNhom
            // 
            this.bt_AddTaoNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_AddTaoNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddTaoNhom.Image = global::CDIO_QLCLB.Properties.Resources.tick;
            this.bt_AddTaoNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AddTaoNhom.Location = new System.Drawing.Point(32, 318);
            this.bt_AddTaoNhom.Name = "bt_AddTaoNhom";
            this.bt_AddTaoNhom.Size = new System.Drawing.Size(141, 41);
            this.bt_AddTaoNhom.TabIndex = 4;
            this.bt_AddTaoNhom.Text = "Tạo nhóm";
            this.bt_AddTaoNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_AddTaoNhom.UseVisualStyleBackColor = true;
            this.bt_AddTaoNhom.Click += new System.EventHandler(this.bt_AddTaoNhom_Click);
            // 
            // bt_AddDeletemember
            // 
            this.bt_AddDeletemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_AddDeletemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddDeletemember.Image = global::CDIO_QLCLB.Properties.Resources.delete;
            this.bt_AddDeletemember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AddDeletemember.Location = new System.Drawing.Point(199, 318);
            this.bt_AddDeletemember.Name = "bt_AddDeletemember";
            this.bt_AddDeletemember.Size = new System.Drawing.Size(173, 41);
            this.bt_AddDeletemember.TabIndex = 4;
            this.bt_AddDeletemember.Text = "Xóa Thành Viên";
            this.bt_AddDeletemember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_AddDeletemember.UseVisualStyleBackColor = true;
            this.bt_AddDeletemember.Click += new System.EventHandler(this.bt_AddDeletemember_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhóm trưởng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách thành viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhóm:";
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
            // frm_AddTeam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 552);
            this.ControlBox = false;
            this.Controls.Add(this.pn_AddTeam);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.lb_TieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddTeam";
            this.Text = "Quản lý nhóm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.pn_AddTeam.ResumeLayout(false);
            this.pn_AddTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AddThanhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label bt_Back;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tb_TaoNhom;
        private System.Windows.Forms.Button bt_DanhGia;
        private System.Windows.Forms.Button bt_DiemDanh;
        private System.Windows.Forms.Button bt_PhanCong;
        private System.Windows.Forms.Button tb_SuaNhom;
        protected internal System.Windows.Forms.Panel pn_AddTeam;
        protected internal System.Windows.Forms.ComboBox cbb_AddNhomTruong;
        protected internal System.Windows.Forms.TextBox tb_AddTenNhom;
        protected internal System.Windows.Forms.ComboBox cbb_AddListMember;
        protected internal System.Windows.Forms.DataGridView dtg_AddThanhVien;
        protected internal System.Windows.Forms.Button bt_ThemThanhVien;
        private System.Windows.Forms.Button bt_AddTaoNhom;
        private System.Windows.Forms.Button bt_AddDeletemember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}