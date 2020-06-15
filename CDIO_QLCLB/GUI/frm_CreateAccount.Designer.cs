namespace CDIO_QLCLB.GUI
{
    partial class frm_CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CreateAccount));
            this.dgv_DSTV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.bt_Create = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DSTV
            // 
            this.dgv_DSTV.AllowUserToAddRows = false;
            this.dgv_DSTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoThanhVien,
            this.TenThanhVien,
            this.MSSV,
            this.ChucVu,
            this.Chon});
            this.dgv_DSTV.Location = new System.Drawing.Point(49, 108);
            this.dgv_DSTV.Name = "dgv_DSTV";
            this.dgv_DSTV.RowHeadersWidth = 51;
            this.dgv_DSTV.RowTemplate.Height = 24;
            this.dgv_DSTV.Size = new System.Drawing.Size(1300, 268);
            this.dgv_DSTV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(49, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 1);
            this.panel1.TabIndex = 4;
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_TieuDe.Location = new System.Drawing.Point(88, 9);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(1226, 39);
            this.lb_TieuDe.TabIndex = 3;
            this.lb_TieuDe.Text = "TẠO TÀI KHOẢN";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Create
            // 
            this.bt_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Create.Image = global::CDIO_QLCLB.Properties.Resources.createAccount;
            this.bt_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Create.Location = new System.Drawing.Point(49, 421);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(185, 47);
            this.bt_Create.TabIndex = 12;
            this.bt_Create.Text = "Tạo tài khoản";
            this.bt_Create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Create.UseVisualStyleBackColor = true;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "IDThanhVien";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // HoThanhVien
            // 
            this.HoThanhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoThanhVien.DataPropertyName = "HoThanhVien";
            this.HoThanhVien.HeaderText = "Họ";
            this.HoThanhVien.MinimumWidth = 6;
            this.HoThanhVien.Name = "HoThanhVien";
            this.HoThanhVien.ReadOnly = true;
            // 
            // TenThanhVien
            // 
            this.TenThanhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenThanhVien.DataPropertyName = "TenThanhVien";
            this.TenThanhVien.HeaderText = "Tên";
            this.TenThanhVien.MinimumWidth = 6;
            this.TenThanhVien.Name = "TenThanhVien";
            this.TenThanhVien.ReadOnly = true;
            this.TenThanhVien.Width = 62;
            // 
            // MSSV
            // 
            this.MSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 75;
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Width = 88;
            // 
            // Chon
            // 
            this.Chon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Chon.FalseValue = "false";
            this.Chon.HeaderText = "Chọn";
            this.Chon.MinimumWidth = 6;
            this.Chon.Name = "Chon";
            this.Chon.ReadOnly = true;
            this.Chon.TrueValue = "true";
            this.Chon.Width = 47;
            // 
            // frm_CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 499);
            this.Controls.Add(this.bt_Create);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_TieuDe);
            this.Controls.Add(this.dgv_DSTV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CreateAccount";
            this.Text = "Tạo tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        protected internal System.Windows.Forms.DataGridView dgv_DSTV;
        private System.Windows.Forms.Button bt_Create;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
    }
}