namespace CDIO_QLCLB.GUI
{
    partial class frm_PlanningDetails
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
            this.lb_DateTime = new System.Windows.Forms.Label();
            this.lb_FullName = new System.Windows.Forms.Label();
            this.lb_Location = new System.Windows.Forms.Label();
            this.tb_MainContent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_Back = new System.Windows.Forms.Label();
            this.linklb_Documen = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Location = new System.Drawing.Point(73, 74);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(1207, 23);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "<<Đây là Tiêu đề>>";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DateTime
            // 
            this.lb_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DateTime.Location = new System.Drawing.Point(74, 178);
            this.lb_DateTime.Name = "lb_DateTime";
            this.lb_DateTime.Size = new System.Drawing.Size(493, 43);
            this.lb_DateTime.TabIndex = 0;
            this.lb_DateTime.Text = "<<Ngày ra Kế Hoạch>>";
            this.lb_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_FullName
            // 
            this.lb_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FullName.Location = new System.Drawing.Point(74, 135);
            this.lb_FullName.Name = "lb_FullName";
            this.lb_FullName.Size = new System.Drawing.Size(513, 43);
            this.lb_FullName.TabIndex = 0;
            this.lb_FullName.Text = "<<Người ra Kế Hoạch>>";
            this.lb_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Location
            // 
            this.lb_Location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Location.Location = new System.Drawing.Point(926, 135);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.Size = new System.Drawing.Size(354, 43);
            this.lb_Location.TabIndex = 0;
            this.lb_Location.Text = "<<Địa ĐIểm Thực Hiện Kế Hoạch>>";
            this.lb_Location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_MainContent
            // 
            this.tb_MainContent.AllowDrop = true;
            this.tb_MainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MainContent.BackColor = System.Drawing.Color.White;
            this.tb_MainContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MainContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_MainContent.Location = new System.Drawing.Point(39, 266);
            this.tb_MainContent.Multiline = true;
            this.tb_MainContent.Name = "tb_MainContent";
            this.tb_MainContent.ReadOnly = true;
            this.tb_MainContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_MainContent.Size = new System.Drawing.Size(1241, 253);
            this.tb_MainContent.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 1);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::CDIO_QLCLB.Properties.Resources.analyst;
            this.label8.Location = new System.Drawing.Point(36, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 32);
            this.label8.TabIndex = 0;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::CDIO_QLCLB.Properties.Resources.attachment;
            this.label10.Location = new System.Drawing.Point(859, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 32);
            this.label10.TabIndex = 0;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::CDIO_QLCLB.Properties.Resources.map;
            this.label9.Location = new System.Drawing.Point(859, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 32);
            this.label9.TabIndex = 0;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::CDIO_QLCLB.Properties.Resources.schedule;
            this.label7.Location = new System.Drawing.Point(39, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 32);
            this.label7.TabIndex = 0;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // linklb_Documen
            // 
            this.linklb_Documen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklb_Documen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_Documen.Location = new System.Drawing.Point(927, 192);
            this.linklb_Documen.Name = "linklb_Documen";
            this.linklb_Documen.Size = new System.Drawing.Size(353, 23);
            this.linklb_Documen.TabIndex = 3;
            this.linklb_Documen.TabStop = true;
            this.linklb_Documen.Text = "<<Đây là tài liệu đính kèm>>";
            // 
            // frm_PlanningDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 550);
            this.ControlBox = false;
            this.Controls.Add(this.linklb_Documen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_MainContent);
            this.Controls.Add(this.lb_Location);
            this.Controls.Add(this.lb_FullName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.lb_DateTime);
            this.Controls.Add(this.lb_TieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PlanningDetails";
            this.Text = "Kế Hoạch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PlanningDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bt_Back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        protected internal System.Windows.Forms.Label lb_DateTime;
        protected internal System.Windows.Forms.Label lb_FullName;
        protected internal System.Windows.Forms.Label lb_Location;
        protected internal System.Windows.Forms.LinkLabel linklb_Documen;
        protected internal System.Windows.Forms.TextBox tb_MainContent;
    }
}