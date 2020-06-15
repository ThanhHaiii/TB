namespace CDIO_QLCLB.GUI
{
    partial class uc_userInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_Avatar = new System.Windows.Forms.PictureBox();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_ChucVu = new System.Windows.Forms.Label();
            this.lb_MSSV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.Image = global::CDIO_QLCLB.Properties.Resources.noImage;
            this.pic_Avatar.Location = new System.Drawing.Point(3, 15);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Size = new System.Drawing.Size(105, 105);
            this.pic_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Avatar.TabIndex = 0;
            this.pic_Avatar.TabStop = false;
            this.pic_Avatar.Click += new System.EventHandler(this.pic_Avatar_Click);
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.Location = new System.Drawing.Point(226, 26);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(92, 20);
            this.lb_HoTen.TabIndex = 1;
            this.lb_HoTen.Text = "<Họ Tên>";
            this.lb_HoTen.Click += new System.EventHandler(this.lb_HoTen_Click);
            // 
            // lb_ChucVu
            // 
            this.lb_ChucVu.AutoSize = true;
            this.lb_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChucVu.Location = new System.Drawing.Point(226, 91);
            this.lb_ChucVu.Name = "lb_ChucVu";
            this.lb_ChucVu.Size = new System.Drawing.Size(90, 20);
            this.lb_ChucVu.TabIndex = 1;
            this.lb_ChucVu.Text = "<Chức vụ>";
            this.lb_ChucVu.Click += new System.EventHandler(this.lb_ChucVu_Click);
            // 
            // lb_MSSV
            // 
            this.lb_MSSV.AutoSize = true;
            this.lb_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MSSV.Location = new System.Drawing.Point(226, 58);
            this.lb_MSSV.Name = "lb_MSSV";
            this.lb_MSSV.Size = new System.Drawing.Size(76, 20);
            this.lb_MSSV.TabIndex = 1;
            this.lb_MSSV.Text = "<MSSV>";
            this.lb_MSSV.Click += new System.EventHandler(this.lb_MSSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chức vụ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // uc_userInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_MSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_ChucVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.pic_Avatar);
            this.Name = "uc_userInfo";
            this.Size = new System.Drawing.Size(554, 134);
            this.Load += new System.EventHandler(this.uc_userInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.Label lb_HoTen;
        protected internal System.Windows.Forms.Label lb_ChucVu;
        protected internal System.Windows.Forms.PictureBox pic_Avatar;
        protected internal System.Windows.Forms.Label lb_MSSV;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label label3;
    }
}
