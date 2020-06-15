namespace CDIO_QLCLB.GUI
{
    partial class frm_MemberList
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
            this.pn_List = new System.Windows.Forms.Panel();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_SoLuongTVCT = new System.Windows.Forms.Label();
            this.lb_CTV = new System.Windows.Forms.Label();
            this.lb_SoBanGhi = new System.Windows.Forms.Label();
            this.bt_XuatDS = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Label();
            this.bt_Back = new System.Windows.Forms.Label();
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
            this.lb_TieuDe.Size = new System.Drawing.Size(1163, 39);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "DANH SÁCH THÀNH VIÊN";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 1);
            this.panel1.TabIndex = 2;
            // 
            // pn_List
            // 
            this.pn_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_List.AutoScroll = true;
            this.pn_List.Location = new System.Drawing.Point(39, 220);
            this.pn_List.Name = "pn_List";
            this.pn_List.Size = new System.Drawing.Size(1197, 294);
            this.pn_List.TabIndex = 0;
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(39, 135);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(286, 29);
            this.tb_Search.TabIndex = 3;
            this.tb_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Search_KeyPress);
            // 
            // lb_SoLuongTVCT
            // 
            this.lb_SoLuongTVCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SoLuongTVCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuongTVCT.ForeColor = System.Drawing.Color.Black;
            this.lb_SoLuongTVCT.Location = new System.Drawing.Point(729, 132);
            this.lb_SoLuongTVCT.Name = "lb_SoLuongTVCT";
            this.lb_SoLuongTVCT.Size = new System.Drawing.Size(288, 39);
            this.lb_SoLuongTVCT.TabIndex = 0;
            this.lb_SoLuongTVCT.Text = "Thành viên chính thức: ";
            this.lb_SoLuongTVCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_CTV
            // 
            this.lb_CTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CTV.ForeColor = System.Drawing.Color.Black;
            this.lb_CTV.Location = new System.Drawing.Point(1023, 132);
            this.lb_CTV.Name = "lb_CTV";
            this.lb_CTV.Size = new System.Drawing.Size(213, 39);
            this.lb_CTV.TabIndex = 0;
            this.lb_CTV.Text = "Cộng tác viên: ";
            this.lb_CTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_SoBanGhi
            // 
            this.lb_SoBanGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoBanGhi.ForeColor = System.Drawing.Color.Green;
            this.lb_SoBanGhi.Location = new System.Drawing.Point(407, 132);
            this.lb_SoBanGhi.Name = "lb_SoBanGhi";
            this.lb_SoBanGhi.Size = new System.Drawing.Size(288, 39);
            this.lb_SoBanGhi.TabIndex = 0;
            this.lb_SoBanGhi.Text = "Số bản ghi tìm được: ";
            this.lb_SoBanGhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_XuatDS
            // 
            this.bt_XuatDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_XuatDS.Location = new System.Drawing.Point(39, 171);
            this.bt_XuatDS.Name = "bt_XuatDS";
            this.bt_XuatDS.Size = new System.Drawing.Size(158, 41);
            this.bt_XuatDS.TabIndex = 4;
            this.bt_XuatDS.Text = "Xuất danh sách";
            this.bt_XuatDS.UseVisualStyleBackColor = true;
            this.bt_XuatDS.Click += new System.EventHandler(this.bt_XuatDS_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.Image = global::CDIO_QLCLB.Properties.Resources.search;
            this.bt_Search.Location = new System.Drawing.Point(342, 135);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(32, 32);
            this.bt_Search.TabIndex = 0;
            this.bt_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
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
            // frm_MemberList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 540);
            this.ControlBox = false;
            this.Controls.Add(this.bt_XuatDS);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.pn_List);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.lb_CTV);
            this.Controls.Add(this.lb_SoBanGhi);
            this.Controls.Add(this.lb_SoLuongTVCT);
            this.Controls.Add(this.lb_TieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MemberList";
            this.Text = "Danh sách thành viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MemberList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bt_Back;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel pn_List;
        private System.Windows.Forms.Label bt_Search;
        protected internal System.Windows.Forms.Label lb_SoLuongTVCT;
        protected internal System.Windows.Forms.Label lb_CTV;
        protected internal System.Windows.Forms.TextBox tb_Search;
        protected internal System.Windows.Forms.Label lb_SoBanGhi;
        private System.Windows.Forms.Button bt_XuatDS;
    }
}