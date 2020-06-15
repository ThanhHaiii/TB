namespace CDIO_QLCLB.GUI
{
    partial class uc_tt
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
            this.lb_TenCH = new System.Windows.Forms.Label();
            this.lb_nguoidang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_TenCH
            // 
            this.lb_TenCH.AutoSize = true;
            this.lb_TenCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenCH.Location = new System.Drawing.Point(20, 17);
            this.lb_TenCH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenCH.Name = "lb_TenCH";
            this.lb_TenCH.Size = new System.Drawing.Size(129, 17);
            this.lb_TenCH.TabIndex = 2;
            this.lb_TenCH.Text = "<Tên Cuộc Họp>";
            // 
            // lb_nguoidang
            // 
            this.lb_nguoidang.AutoSize = true;
            this.lb_nguoidang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nguoidang.Location = new System.Drawing.Point(20, 55);
            this.lb_nguoidang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nguoidang.Name = "lb_nguoidang";
            this.lb_nguoidang.Size = new System.Drawing.Size(99, 17);
            this.lb_nguoidang.TabIndex = 3;
            this.lb_nguoidang.Text = "<Người Đăng>";
            // 
            // uc_tt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_nguoidang);
            this.Controls.Add(this.lb_TenCH);
            this.Name = "uc_tt";
            this.Size = new System.Drawing.Size(306, 147);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_TenCH;
        protected internal System.Windows.Forms.Label lb_nguoidang;
    }
}
