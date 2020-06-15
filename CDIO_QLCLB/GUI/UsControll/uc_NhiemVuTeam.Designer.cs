namespace CDIO_QLCLB.GUI
{
    partial class uc_NhiemVuTeam
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
            this.lb_TenNV = new System.Windows.Forms.Label();
            this.lb_TimeStart = new System.Windows.Forms.Label();
            this.lb_TimeEnd = new System.Windows.Forms.Label();
            this.lb_NguoiRaNV = new System.Windows.Forms.Label();
            this.lb_location = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_TenNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNV.Location = new System.Drawing.Point(0, 0);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(959, 36);
            this.lb_TenNV.TabIndex = 0;
            this.lb_TenNV.Text = "<Tên nhiệm vụ>";
            this.lb_TenNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TimeStart
            // 
            this.lb_TimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeStart.Location = new System.Drawing.Point(15, 43);
            this.lb_TimeStart.Name = "lb_TimeStart";
            this.lb_TimeStart.Size = new System.Drawing.Size(400, 18);
            this.lb_TimeStart.TabIndex = 0;
            this.lb_TimeStart.Text = "Ngày ra nhiệm vụ:";
            this.lb_TimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_TimeEnd
            // 
            this.lb_TimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeEnd.Location = new System.Drawing.Point(594, 43);
            this.lb_TimeEnd.Name = "lb_TimeEnd";
            this.lb_TimeEnd.Size = new System.Drawing.Size(351, 18);
            this.lb_TimeEnd.TabIndex = 0;
            this.lb_TimeEnd.Text = "Hạn hoàn thành:";
            this.lb_TimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_NguoiRaNV
            // 
            this.lb_NguoiRaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NguoiRaNV.Location = new System.Drawing.Point(15, 70);
            this.lb_NguoiRaNV.Name = "lb_NguoiRaNV";
            this.lb_NguoiRaNV.Size = new System.Drawing.Size(405, 18);
            this.lb_NguoiRaNV.TabIndex = 0;
            this.lb_NguoiRaNV.Text = "Người ra nhiệm vụ:";
            this.lb_NguoiRaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_location
            // 
            this.lb_location.AllowDrop = true;
            this.lb_location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_location.Location = new System.Drawing.Point(448, 70);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(497, 45);
            this.lb_location.TabIndex = 0;
            this.lb_location.Text = "Địa điểm thực hiện:";
            this.lb_location.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uc_NhiemVuTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_location);
            this.Controls.Add(this.lb_TimeEnd);
            this.Controls.Add(this.lb_NguoiRaNV);
            this.Controls.Add(this.lb_TimeStart);
            this.Controls.Add(this.lb_TenNV);
            this.Name = "uc_NhiemVuTeam";
            this.Size = new System.Drawing.Size(959, 126);
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.Label lb_TenNV;
        protected internal System.Windows.Forms.Label lb_TimeStart;
        protected internal System.Windows.Forms.Label lb_NguoiRaNV;
        protected internal System.Windows.Forms.Label lb_location;
        protected internal System.Windows.Forms.Label lb_TimeEnd;
    }
}
