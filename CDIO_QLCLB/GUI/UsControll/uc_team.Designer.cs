namespace CDIO_QLCLB.GUI
{
    partial class uc_team
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
            this.lb_TenNhom = new System.Windows.Forms.Label();
            this.lb_TenNhomTuong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_TenNhom
            // 
            this.lb_TenNhom.AutoSize = true;
            this.lb_TenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNhom.Location = new System.Drawing.Point(3, 8);
            this.lb_TenNhom.Name = "lb_TenNhom";
            this.lb_TenNhom.Size = new System.Drawing.Size(106, 18);
            this.lb_TenNhom.TabIndex = 0;
            this.lb_TenNhom.Text = "<Tên Nhóm>";
            // 
            // lb_TenNhomTuong
            // 
            this.lb_TenNhomTuong.AutoSize = true;
            this.lb_TenNhomTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNhomTuong.Location = new System.Drawing.Point(3, 37);
            this.lb_TenNhomTuong.Name = "lb_TenNhomTuong";
            this.lb_TenNhomTuong.Size = new System.Drawing.Size(142, 18);
            this.lb_TenNhomTuong.TabIndex = 0;
            this.lb_TenNhomTuong.Text = "<Tên Nhóm trưởng>";
            // 
            // uc_team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_TenNhomTuong);
            this.Controls.Add(this.lb_TenNhom);
            this.Name = "uc_team";
            this.Size = new System.Drawing.Size(298, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_TenNhom;
        protected internal System.Windows.Forms.Label lb_TenNhomTuong;
    }
}
