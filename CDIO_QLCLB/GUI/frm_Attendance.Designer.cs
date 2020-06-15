namespace CDIO_QLCLB.GUI
{
    partial class frm_Attendance
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
            this.bt_DanhGia = new System.Windows.Forms.Button();
            this.bt_DiemDanh = new System.Windows.Forms.Button();
            this.bt_PhanCong = new System.Windows.Forms.Button();
            this.tb_SuaNhom = new System.Windows.Forms.Button();
            this.tb_TaoNhom = new System.Windows.Forms.Button();
            this.pn_TeamList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_MemberList = new System.Windows.Forms.Panel();
            this.lb_DSThanhVien = new System.Windows.Forms.Label();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_SelectAll = new System.Windows.Forms.Button();
            this.bt_DDanh = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Label();
            this.cbb_keHoach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_GhiChu = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
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
            this.lb_TieuDe.Size = new System.Drawing.Size(1286, 39);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "ĐIỂM DANH";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 1);
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
            this.panel2.Size = new System.Drawing.Size(231, 351);
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
            this.tb_TaoNhom.Click += new System.EventHandler(this.tb_TaoNhom_Click);
            // 
            // pn_TeamList
            // 
            this.pn_TeamList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_TeamList.AutoScroll = true;
            this.pn_TeamList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_TeamList.Location = new System.Drawing.Point(278, 182);
            this.pn_TeamList.Name = "pn_TeamList";
            this.pn_TeamList.Size = new System.Drawing.Size(331, 316);
            this.pn_TeamList.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(278, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách nhóm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_MemberList
            // 
            this.pn_MemberList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_MemberList.AutoScroll = true;
            this.pn_MemberList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_MemberList.Location = new System.Drawing.Point(615, 182);
            this.pn_MemberList.Name = "pn_MemberList";
            this.pn_MemberList.Size = new System.Drawing.Size(744, 210);
            this.pn_MemberList.TabIndex = 10;
            // 
            // lb_DSThanhVien
            // 
            this.lb_DSThanhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DSThanhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.lb_DSThanhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_DSThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DSThanhVien.ForeColor = System.Drawing.Color.Black;
            this.lb_DSThanhVien.Location = new System.Drawing.Point(615, 147);
            this.lb_DSThanhVien.Name = "lb_DSThanhVien";
            this.lb_DSThanhVien.Size = new System.Drawing.Size(744, 39);
            this.lb_DSThanhVien.TabIndex = 9;
            this.lb_DSThanhVien.Text = "Danh sách thành viên";
            this.lb_DSThanhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Clear
            // 
            this.bt_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Clear.BackColor = System.Drawing.Color.White;
            this.bt_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Image = global::CDIO_QLCLB.Properties.Resources.clean;
            this.bt_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Clear.Location = new System.Drawing.Point(1064, 456);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(193, 42);
            this.bt_Clear.TabIndex = 0;
            this.bt_Clear.Text = "Bỏ chọn";
            this.bt_Clear.UseVisualStyleBackColor = false;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_SelectAll
            // 
            this.bt_SelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_SelectAll.BackColor = System.Drawing.Color.White;
            this.bt_SelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SelectAll.Image = global::CDIO_QLCLB.Properties.Resources.tick;
            this.bt_SelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SelectAll.Location = new System.Drawing.Point(842, 456);
            this.bt_SelectAll.Name = "bt_SelectAll";
            this.bt_SelectAll.Size = new System.Drawing.Size(193, 42);
            this.bt_SelectAll.TabIndex = 0;
            this.bt_SelectAll.Text = "Chọn hết";
            this.bt_SelectAll.UseVisualStyleBackColor = false;
            this.bt_SelectAll.Click += new System.EventHandler(this.bt_SelectAll_Click);
            // 
            // bt_DDanh
            // 
            this.bt_DDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_DDanh.BackColor = System.Drawing.Color.White;
            this.bt_DDanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DDanh.Image = global::CDIO_QLCLB.Properties.Resources.shift;
            this.bt_DDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DDanh.Location = new System.Drawing.Point(615, 456);
            this.bt_DDanh.Name = "bt_DDanh";
            this.bt_DDanh.Size = new System.Drawing.Size(193, 42);
            this.bt_DDanh.TabIndex = 0;
            this.bt_DDanh.Text = "Điểm danh";
            this.bt_DDanh.UseVisualStyleBackColor = false;
            this.bt_DDanh.Click += new System.EventHandler(this.bt_DDanh_Click);
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
            // cbb_keHoach
            // 
            this.cbb_keHoach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbb_keHoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_keHoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_keHoach.FormattingEnabled = true;
            this.cbb_keHoach.Location = new System.Drawing.Point(705, 399);
            this.cbb_keHoach.Name = "cbb_keHoach";
            this.cbb_keHoach.Size = new System.Drawing.Size(269, 26);
            this.cbb_keHoach.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kế hoạch:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1000, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ghi chú:";
            // 
            // tb_GhiChu
            // 
            this.tb_GhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GhiChu.Location = new System.Drawing.Point(1090, 399);
            this.tb_GhiChu.Name = "tb_GhiChu";
            this.tb_GhiChu.Size = new System.Drawing.Size(269, 24);
            this.tb_GhiChu.TabIndex = 13;
            // 
            // frm_Attendance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1399, 530);
            this.ControlBox = false;
            this.Controls.Add(this.tb_GhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_keHoach);
            this.Controls.Add(this.pn_MemberList);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_SelectAll);
            this.Controls.Add(this.bt_DDanh);
            this.Controls.Add(this.pn_TeamList);
            this.Controls.Add(this.lb_DSThanhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.lb_TieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Attendance";
            this.Text = "Quản lý nhóm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        protected internal System.Windows.Forms.Panel pn_TeamList;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Panel pn_MemberList;
        protected internal System.Windows.Forms.Label lb_DSThanhVien;
        protected internal System.Windows.Forms.Button bt_SelectAll;
        protected internal System.Windows.Forms.Button bt_Clear;
        protected internal System.Windows.Forms.Button bt_DDanh;
        protected internal System.Windows.Forms.ComboBox cbb_keHoach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox tb_GhiChu;
    }
}