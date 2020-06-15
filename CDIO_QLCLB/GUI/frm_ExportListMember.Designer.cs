namespace CDIO_QLCLB.GUI
{
    partial class frm_ExportListMember
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
            this.rdb_All = new System.Windows.Forms.RadioButton();
            this.rdb_TVCT = new System.Windows.Forms.RadioButton();
            this.rdb_CTV = new System.Windows.Forms.RadioButton();
            this.bt_Export = new System.Windows.Forms.Button();
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_All
            // 
            this.rdb_All.AutoSize = true;
            this.rdb_All.Location = new System.Drawing.Point(30, 13);
            this.rdb_All.Name = "rdb_All";
            this.rdb_All.Size = new System.Drawing.Size(69, 21);
            this.rdb_All.TabIndex = 0;
            this.rdb_All.TabStop = true;
            this.rdb_All.Text = "Tất cả";
            this.rdb_All.UseVisualStyleBackColor = true;
            this.rdb_All.CheckedChanged += new System.EventHandler(this.rdb_All_CheckedChanged);
            // 
            // rdb_TVCT
            // 
            this.rdb_TVCT.AutoSize = true;
            this.rdb_TVCT.Location = new System.Drawing.Point(126, 13);
            this.rdb_TVCT.Name = "rdb_TVCT";
            this.rdb_TVCT.Size = new System.Drawing.Size(169, 21);
            this.rdb_TVCT.TabIndex = 1;
            this.rdb_TVCT.TabStop = true;
            this.rdb_TVCT.Text = "Thành viên chính thức";
            this.rdb_TVCT.UseVisualStyleBackColor = true;
            this.rdb_TVCT.CheckedChanged += new System.EventHandler(this.rdb_TVCT_CheckedChanged);
            // 
            // rdb_CTV
            // 
            this.rdb_CTV.AutoSize = true;
            this.rdb_CTV.Location = new System.Drawing.Point(328, 13);
            this.rdb_CTV.Name = "rdb_CTV";
            this.rdb_CTV.Size = new System.Drawing.Size(115, 21);
            this.rdb_CTV.TabIndex = 2;
            this.rdb_CTV.TabStop = true;
            this.rdb_CTV.Text = "Cộng tác viên";
            this.rdb_CTV.UseVisualStyleBackColor = true;
            this.rdb_CTV.CheckedChanged += new System.EventHandler(this.rdb_CTV_CheckedChanged);
            // 
            // bt_Export
            // 
            this.bt_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Export.Image = global::CDIO_QLCLB.Properties.Resources.excel;
            this.bt_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Export.Location = new System.Drawing.Point(536, 6);
            this.bt_Export.Name = "bt_Export";
            this.bt_Export.Size = new System.Drawing.Size(161, 48);
            this.bt_Export.TabIndex = 1;
            this.bt_Export.Text = "Xuất file Excel";
            this.bt_Export.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Export.UseVisualStyleBackColor = true;
            this.bt_Export.Click += new System.EventHandler(this.bt_Export_Click);
            // 
            // dgv_List
            // 
            this.dgv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSSV,
            this.HoThanhVien,
            this.TenThanhVien,
            this.sex,
            this.ChucVu,
            this.Lop});
            this.dgv_List.Location = new System.Drawing.Point(30, 87);
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.RowHeadersWidth = 51;
            this.dgv_List.RowTemplate.Height = 24;
            this.dgv_List.Size = new System.Drawing.Size(1043, 429);
            this.dgv_List.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 64;
            // 
            // MSSV
            // 
            this.MSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 75;
            // 
            // HoThanhVien
            // 
            this.HoThanhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoThanhVien.DataPropertyName = "HoThanhVien";
            this.HoThanhVien.HeaderText = "Họ";
            this.HoThanhVien.MinimumWidth = 6;
            this.HoThanhVien.Name = "HoThanhVien";
            this.HoThanhVien.Width = 55;
            // 
            // TenThanhVien
            // 
            this.TenThanhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenThanhVien.DataPropertyName = "TenThanhVien";
            this.TenThanhVien.HeaderText = "Tên";
            this.TenThanhVien.MinimumWidth = 6;
            this.TenThanhVien.Name = "TenThanhVien";
            this.TenThanhVien.Width = 62;
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sex.DataPropertyName = "gioitinh";
            this.sex.HeaderText = "Giới tính";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.Width = 89;
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChucVu.DataPropertyName = "TenChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 88;
            // 
            // Lop
            // 
            this.Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            this.Lop.Width = 61;
            // 
            // frm_ExportListMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 528);
            this.Controls.Add(this.dgv_List);
            this.Controls.Add(this.bt_Export);
            this.Controls.Add(this.rdb_CTV);
            this.Controls.Add(this.rdb_TVCT);
            this.Controls.Add(this.rdb_All);
            this.Name = "frm_ExportListMember";
            this.Text = "Danh sách Thành viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Export;
        protected internal System.Windows.Forms.DataGridView dgv_List;
        protected internal System.Windows.Forms.RadioButton rdb_All;
        protected internal System.Windows.Forms.RadioButton rdb_TVCT;
        protected internal System.Windows.Forms.RadioButton rdb_CTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
    }
}