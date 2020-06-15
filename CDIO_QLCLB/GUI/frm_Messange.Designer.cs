namespace CDIO_QLCLB.GUI
{
    partial class frm_Messange
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
            this.pn_MessList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.tb_Messange = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_Mess = new System.Windows.Forms.Panel();
            this.pic_DinhKem = new System.Windows.Forms.PictureBox();
            this.bt_Send = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Label();
            this.bt_Them = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DinhKem)).BeginInit();
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
            this.lb_TieuDe.Size = new System.Drawing.Size(1056, 39);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "NHẮN TIN";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 1);
            this.panel1.TabIndex = 2;
            // 
            // pn_MessList
            // 
            this.pn_MessList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_MessList.AutoScroll = true;
            this.pn_MessList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_MessList.Location = new System.Drawing.Point(39, 181);
            this.pn_MessList.Name = "pn_MessList";
            this.pn_MessList.Size = new System.Drawing.Size(312, 351);
            this.pn_MessList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tin nhắn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.lb_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.ForeColor = System.Drawing.Color.Black;
            this.lb_HoTen.Location = new System.Drawing.Point(371, 146);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(758, 32);
            this.lb_HoTen.TabIndex = 0;
            this.lb_HoTen.Text = "<Tên người nhận>";
            this.lb_HoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Messange
            // 
            this.tb_Messange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Messange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Messange.Location = new System.Drawing.Point(485, 471);
            this.tb_Messange.Multiline = true;
            this.tb_Messange.Name = "tb_Messange";
            this.tb_Messange.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_Messange.Size = new System.Drawing.Size(520, 61);
            this.tb_Messange.TabIndex = 3;
            this.tb_Messange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Messange_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pn_Mess);
            this.panel2.Location = new System.Drawing.Point(371, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 284);
            this.panel2.TabIndex = 0;
            // 
            // pn_Mess
            // 
            this.pn_Mess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Mess.AutoScroll = true;
            this.pn_Mess.Location = new System.Drawing.Point(15, 16);
            this.pn_Mess.Name = "pn_Mess";
            this.pn_Mess.Size = new System.Drawing.Size(726, 253);
            this.pn_Mess.TabIndex = 0;
            // 
            // pic_DinhKem
            // 
            this.pic_DinhKem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_DinhKem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_DinhKem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_DinhKem.Image = global::CDIO_QLCLB.Properties.Resources.shapes;
            this.pic_DinhKem.Location = new System.Drawing.Point(372, 471);
            this.pic_DinhKem.Name = "pic_DinhKem";
            this.pic_DinhKem.Size = new System.Drawing.Size(107, 61);
            this.pic_DinhKem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_DinhKem.TabIndex = 5;
            this.pic_DinhKem.TabStop = false;
            this.pic_DinhKem.Click += new System.EventHandler(this.pic_DinhKem_Click);
            // 
            // bt_Send
            // 
            this.bt_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send.Image = global::CDIO_QLCLB.Properties.Resources.origami;
            this.bt_Send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Send.Location = new System.Drawing.Point(1011, 471);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(118, 61);
            this.bt_Send.TabIndex = 4;
            this.bt_Send.Text = "Gửi";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
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
            // bt_Them
            // 
            this.bt_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.bt_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(1025, 146);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(104, 32);
            this.bt_Them.TabIndex = 6;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            // 
            // frm_Messange
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 567);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.pic_DinhKem);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.tb_Messange);
            this.Controls.Add(this.pn_MessList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Messange";
            this.Text = "Quản lý nhóm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_DinhKem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bt_Back;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel pn_MessList;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.TextBox tb_Messange;
        private System.Windows.Forms.Button bt_Send;
        protected internal System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Panel pn_Mess;
        protected internal System.Windows.Forms.PictureBox pic_DinhKem;
        private System.Windows.Forms.Button bt_Them;
    }
}