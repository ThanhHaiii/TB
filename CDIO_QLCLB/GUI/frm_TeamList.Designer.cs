namespace CDIO_QLCLB.GUI
{
    partial class frm_TeamList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_InfoTeam = new System.Windows.Forms.Panel();
            this.cb_ThemTV = new System.Windows.Forms.ComboBox();
            this.dgv_DSTV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pn_NhiemVu = new System.Windows.Forms.Panel();
            this.lb_Ranking = new System.Windows.Forms.Label();
            this.lb_SoThanhVien = new System.Windows.Forms.Label();
            this.lb_NgayLapNhom = new System.Windows.Forms.Label();
            this.lb_SDTNhomTruong = new System.Windows.Forms.Label();
            this.lb_NhomTruong = new System.Windows.Forms.Label();
            this.pn_TeamList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_TeamName = new System.Windows.Forms.Label();
            this.bt_DanhGia = new System.Windows.Forms.Button();
            this.bt_DiemDanh = new System.Windows.Forms.Button();
            this.bt_PhanCong = new System.Windows.Forms.Button();
            this.tb_SuaNhom = new System.Windows.Forms.Button();
            this.tb_TaoNhom = new System.Windows.Forms.Button();
            this.bt_addMember = new System.Windows.Forms.Button();
            this.bt_XoaTV = new System.Windows.Forms.Button();
            this.tb_Facebook = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Label();
            this.IDThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhiemVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoanThanhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_InfoTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTV)).BeginInit();
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
            this.lb_TieuDe.Size = new System.Drawing.Size(1737, 39);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "QUẢN LÝ NHÓM";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1771, 1);
            this.panel1.TabIndex = 2;
            // 
            // pn_InfoTeam
            // 
            this.pn_InfoTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_InfoTeam.AutoScroll = true;
            this.pn_InfoTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_InfoTeam.Controls.Add(this.cb_ThemTV);
            this.pn_InfoTeam.Controls.Add(this.bt_addMember);
            this.pn_InfoTeam.Controls.Add(this.bt_XoaTV);
            this.pn_InfoTeam.Controls.Add(this.dgv_DSTV);
            this.pn_InfoTeam.Controls.Add(this.label8);
            this.pn_InfoTeam.Controls.Add(this.label7);
            this.pn_InfoTeam.Controls.Add(this.panel5);
            this.pn_InfoTeam.Controls.Add(this.panel3);
            this.pn_InfoTeam.Controls.Add(this.pn_NhiemVu);
            this.pn_InfoTeam.Controls.Add(this.tb_Facebook);
            this.pn_InfoTeam.Controls.Add(this.lb_Ranking);
            this.pn_InfoTeam.Controls.Add(this.lb_SoThanhVien);
            this.pn_InfoTeam.Controls.Add(this.lb_NgayLapNhom);
            this.pn_InfoTeam.Controls.Add(this.lb_SDTNhomTruong);
            this.pn_InfoTeam.Controls.Add(this.lb_NhomTruong);
            this.pn_InfoTeam.Location = new System.Drawing.Point(634, 182);
            this.pn_InfoTeam.Name = "pn_InfoTeam";
            this.pn_InfoTeam.Size = new System.Drawing.Size(1176, 678);
            this.pn_InfoTeam.TabIndex = 0;
            // 
            // cb_ThemTV
            // 
            this.cb_ThemTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ThemTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ThemTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ThemTV.FormattingEnabled = true;
            this.cb_ThemTV.Location = new System.Drawing.Point(227, 607);
            this.cb_ThemTV.Name = "cb_ThemTV";
            this.cb_ThemTV.Size = new System.Drawing.Size(694, 26);
            this.cb_ThemTV.TabIndex = 5;
            // 
            // dgv_DSTV
            // 
            this.dgv_DSTV.AllowUserToAddRows = false;
            this.dgv_DSTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSTV.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSTV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSTV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DSTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDThanhVien,
            this.HoThanhVien,
            this.TenThanhVien,
            this.MSSV,
            this.TenNhiemVu,
            this.HoanThanhNV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSTV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSTV.Location = new System.Drawing.Point(27, 409);
            this.dgv_DSTV.Name = "dgv_DSTV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSTV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DSTV.RowHeadersWidth = 51;
            this.dgv_DSTV.RowTemplate.Height = 24;
            this.dgv_DSTV.Size = new System.Drawing.Size(1101, 183);
            this.dgv_DSTV.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(27, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1101, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh sách thành viên";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1101, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhiệm vụ đang làm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(27, 365);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1101, 1);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(27, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 1);
            this.panel3.TabIndex = 2;
            // 
            // pn_NhiemVu
            // 
            this.pn_NhiemVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_NhiemVu.AutoScroll = true;
            this.pn_NhiemVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_NhiemVu.Location = new System.Drawing.Point(27, 187);
            this.pn_NhiemVu.Name = "pn_NhiemVu";
            this.pn_NhiemVu.Size = new System.Drawing.Size(1101, 162);
            this.pn_NhiemVu.TabIndex = 0;
            // 
            // lb_Ranking
            // 
            this.lb_Ranking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Ranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ranking.ForeColor = System.Drawing.Color.Black;
            this.lb_Ranking.Location = new System.Drawing.Point(868, 84);
            this.lb_Ranking.Name = "lb_Ranking";
            this.lb_Ranking.Size = new System.Drawing.Size(260, 36);
            this.lb_Ranking.TabIndex = 0;
            this.lb_Ranking.Text = "Điểm nhóm:";
            this.lb_Ranking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_SoThanhVien
            // 
            this.lb_SoThanhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SoThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoThanhVien.ForeColor = System.Drawing.Color.Black;
            this.lb_SoThanhVien.Location = new System.Drawing.Point(868, 48);
            this.lb_SoThanhVien.Name = "lb_SoThanhVien";
            this.lb_SoThanhVien.Size = new System.Drawing.Size(260, 36);
            this.lb_SoThanhVien.TabIndex = 0;
            this.lb_SoThanhVien.Text = "Số thành viên:";
            this.lb_SoThanhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_NgayLapNhom
            // 
            this.lb_NgayLapNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NgayLapNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayLapNhom.ForeColor = System.Drawing.Color.Black;
            this.lb_NgayLapNhom.Location = new System.Drawing.Point(868, 8);
            this.lb_NgayLapNhom.Name = "lb_NgayLapNhom";
            this.lb_NgayLapNhom.Size = new System.Drawing.Size(260, 36);
            this.lb_NgayLapNhom.TabIndex = 0;
            this.lb_NgayLapNhom.Text = "Ngày lập nhóm:";
            this.lb_NgayLapNhom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_SDTNhomTruong
            // 
            this.lb_SDTNhomTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDTNhomTruong.ForeColor = System.Drawing.Color.Black;
            this.lb_SDTNhomTruong.Location = new System.Drawing.Point(23, 48);
            this.lb_SDTNhomTruong.Name = "lb_SDTNhomTruong";
            this.lb_SDTNhomTruong.Size = new System.Drawing.Size(310, 36);
            this.lb_SDTNhomTruong.TabIndex = 0;
            this.lb_SDTNhomTruong.Text = "Số điện thoại:";
            this.lb_SDTNhomTruong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_NhomTruong
            // 
            this.lb_NhomTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhomTruong.ForeColor = System.Drawing.Color.Black;
            this.lb_NhomTruong.Location = new System.Drawing.Point(23, 8);
            this.lb_NhomTruong.Name = "lb_NhomTruong";
            this.lb_NhomTruong.Size = new System.Drawing.Size(310, 36);
            this.lb_NhomTruong.TabIndex = 0;
            this.lb_NhomTruong.Text = "Nhóm trưởng:";
            this.lb_NhomTruong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_TeamList
            // 
            this.pn_TeamList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_TeamList.AutoScroll = true;
            this.pn_TeamList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_TeamList.Location = new System.Drawing.Point(294, 182);
            this.pn_TeamList.Name = "pn_TeamList";
            this.pn_TeamList.Size = new System.Drawing.Size(312, 678);
            this.pn_TeamList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(294, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhóm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel2.Size = new System.Drawing.Size(231, 713);
            this.panel2.TabIndex = 0;
            // 
            // lb_TeamName
            // 
            this.lb_TeamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TeamName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(205)))), ((int)(((byte)(76)))));
            this.lb_TeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TeamName.ForeColor = System.Drawing.Color.Black;
            this.lb_TeamName.Location = new System.Drawing.Point(634, 147);
            this.lb_TeamName.Name = "lb_TeamName";
            this.lb_TeamName.Size = new System.Drawing.Size(1176, 36);
            this.lb_TeamName.TabIndex = 0;
            this.lb_TeamName.Text = "<Tên nhóm>";
            this.lb_TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // bt_addMember
            // 
            this.bt_addMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addMember.Image = global::CDIO_QLCLB.Properties.Resources.membership;
            this.bt_addMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_addMember.Location = new System.Drawing.Point(944, 598);
            this.bt_addMember.Name = "bt_addMember";
            this.bt_addMember.Size = new System.Drawing.Size(184, 41);
            this.bt_addMember.TabIndex = 4;
            this.bt_addMember.Text = "Thêm Thành Viên";
            this.bt_addMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_addMember.UseVisualStyleBackColor = true;
            this.bt_addMember.Click += new System.EventHandler(this.bt_addMember_Click);
            // 
            // bt_XoaTV
            // 
            this.bt_XoaTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_XoaTV.Image = global::CDIO_QLCLB.Properties.Resources.delete;
            this.bt_XoaTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_XoaTV.Location = new System.Drawing.Point(31, 598);
            this.bt_XoaTV.Name = "bt_XoaTV";
            this.bt_XoaTV.Size = new System.Drawing.Size(173, 41);
            this.bt_XoaTV.TabIndex = 4;
            this.bt_XoaTV.Text = "Xóa Thành Viên";
            this.bt_XoaTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_XoaTV.UseVisualStyleBackColor = true;
            this.bt_XoaTV.Click += new System.EventHandler(this.bt_XoaTV_Click);
            // 
            // tb_Facebook
            // 
            this.tb_Facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_Facebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Facebook.Image = global::CDIO_QLCLB.Properties.Resources.facebook_Blue;
            this.tb_Facebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_Facebook.Location = new System.Drawing.Point(27, 81);
            this.tb_Facebook.Name = "tb_Facebook";
            this.tb_Facebook.Size = new System.Drawing.Size(217, 45);
            this.tb_Facebook.TabIndex = 1;
            this.tb_Facebook.Text = "Facebook nhóm trưởng";
            this.tb_Facebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tb_Facebook.UseVisualStyleBackColor = true;
            this.tb_Facebook.Click += new System.EventHandler(this.tb_Facebook_Click);
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
            // 
            // IDThanhVien
            // 
            this.IDThanhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDThanhVien.DataPropertyName = "IDThanhVien";
            this.IDThanhVien.HeaderText = "ID";
            this.IDThanhVien.MinimumWidth = 6;
            this.IDThanhVien.Name = "IDThanhVien";
            this.IDThanhVien.Width = 53;
            // 
            // HoThanhVien
            // 
            this.HoThanhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoThanhVien.DataPropertyName = "HoThanhVien";
            this.HoThanhVien.HeaderText = "Họ";
            this.HoThanhVien.MinimumWidth = 6;
            this.HoThanhVien.Name = "HoThanhVien";
            this.HoThanhVien.Width = 59;
            // 
            // TenThanhVien
            // 
            this.TenThanhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenThanhVien.DataPropertyName = "TenThanhVien";
            this.TenThanhVien.HeaderText = "Tên";
            this.TenThanhVien.MinimumWidth = 6;
            this.TenThanhVien.Name = "TenThanhVien";
            this.TenThanhVien.Width = 65;
            // 
            // MSSV
            // 
            this.MSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 83;
            // 
            // TenNhiemVu
            // 
            this.TenNhiemVu.DataPropertyName = "TenNhiemVu";
            this.TenNhiemVu.HeaderText = "Nhiệm Vụ";
            this.TenNhiemVu.MinimumWidth = 6;
            this.TenNhiemVu.Name = "TenNhiemVu";
            this.TenNhiemVu.Width = 125;
            // 
            // HoanThanhNV
            // 
            this.HoanThanhNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoanThanhNV.DataPropertyName = "HoanThanhNV";
            this.HoanThanhNV.HeaderText = "Tình trạng nhiệm vụ";
            this.HoanThanhNV.MinimumWidth = 6;
            this.HoanThanhNV.Name = "HoanThanhNV";
            // 
            // frm_TeamList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1850, 892);
            this.ControlBox = false;
            this.Controls.Add(this.lb_TeamName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_TeamList);
            this.Controls.Add(this.pn_InfoTeam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TeamList";
            this.Text = "Danh sách thành viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pn_InfoTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label bt_Back;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel pn_InfoTeam;
        protected internal System.Windows.Forms.Panel pn_TeamList;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Label lb_TeamName;
        private System.Windows.Forms.Button bt_addMember;
        private System.Windows.Forms.Button bt_XoaTV;
        protected internal System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.Panel pn_NhiemVu;
        protected internal System.Windows.Forms.Label lb_Ranking;
        protected internal System.Windows.Forms.Label lb_SoThanhVien;
        protected internal System.Windows.Forms.Label lb_NgayLapNhom;
        protected internal System.Windows.Forms.Label lb_SDTNhomTruong;
        protected internal System.Windows.Forms.Label lb_NhomTruong;
        private System.Windows.Forms.Button tb_TaoNhom;
        private System.Windows.Forms.Button bt_DanhGia;
        private System.Windows.Forms.Button bt_DiemDanh;
        private System.Windows.Forms.Button bt_PhanCong;
        private System.Windows.Forms.Button tb_SuaNhom;
        protected internal System.Windows.Forms.ComboBox cb_ThemTV;
        protected internal System.Windows.Forms.DataGridView dgv_DSTV;
        protected internal System.Windows.Forms.Button tb_Facebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhiemVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoanThanhNV;
    }
}