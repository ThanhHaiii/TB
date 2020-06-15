namespace CDIO_QLCLB.GUI
{
    partial class frm_ThongBao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Back = new System.Windows.Forms.Label();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.tb_TieuDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_NgayDang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ccb_NguoiDang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_GuiThongBao = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(51, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 1);
            this.panel1.TabIndex = 5;
            // 
            // bt_Back
            // 
            this.bt_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Back.Image = global::CDIO_QLCLB.Properties.Resources.left_arrow;
            this.bt_Back.Location = new System.Drawing.Point(22, 20);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(35, 32);
            this.bt_Back.TabIndex = 3;
            this.bt_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Location = new System.Drawing.Point(85, 29);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(831, 23);
            this.lb_TieuDe.TabIndex = 4;
            this.lb_TieuDe.Text = "THÔNG BÁO";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_TieuDe
            // 
            this.tb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TieuDe.Location = new System.Drawing.Point(196, 156);
            this.tb_TieuDe.Name = "tb_TieuDe";
            this.tb_TieuDe.Size = new System.Drawing.Size(348, 23);
            this.tb_TieuDe.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiêu đề:";
            // 
            // dtp_NgayDang
            // 
            this.dtp_NgayDang.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayDang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayDang.Location = new System.Drawing.Point(196, 216);
            this.dtp_NgayDang.Name = "dtp_NgayDang";
            this.dtp_NgayDang.Size = new System.Drawing.Size(120, 23);
            this.dtp_NgayDang.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày đăng:";
            // 
            // ccb_NguoiDang
            // 
            this.ccb_NguoiDang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_NguoiDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_NguoiDang.FormattingEnabled = true;
            this.ccb_NguoiDang.Location = new System.Drawing.Point(196, 286);
            this.ccb_NguoiDang.Name = "ccb_NguoiDang";
            this.ccb_NguoiDang.Size = new System.Drawing.Size(257, 25);
            this.ccb_NguoiDang.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Người đăng:";
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NoiDung.Location = new System.Drawing.Point(593, 175);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.Size = new System.Drawing.Size(383, 285);
            this.tb_NoiDung.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::CDIO_QLCLB.Properties.Resources.notepad1;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(589, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 43);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nội dung:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Save
            // 
            this.bt_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Image = global::CDIO_QLCLB.Properties.Resources.save;
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(179, 533);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(137, 47);
            this.bt_Save.TabIndex = 14;
            this.bt_Save.Text = "Lưu";
            this.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_GuiThongBao
            // 
            this.bt_GuiThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_GuiThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_GuiThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GuiThongBao.Image = global::CDIO_QLCLB.Properties.Resources.origami1;
            this.bt_GuiThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GuiThongBao.Location = new System.Drawing.Point(459, 533);
            this.bt_GuiThongBao.Name = "bt_GuiThongBao";
            this.bt_GuiThongBao.Size = new System.Drawing.Size(158, 47);
            this.bt_GuiThongBao.TabIndex = 15;
            this.bt_GuiThongBao.Text = "Gửi Thông Báo";
            this.bt_GuiThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_GuiThongBao.UseVisualStyleBackColor = true;
            this.bt_GuiThongBao.Click += new System.EventHandler(this.bt_GuiThongBao_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Image = global::CDIO_QLCLB.Properties.Resources.delete;
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(341, 533);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(112, 47);
            this.bt_Xoa.TabIndex = 20;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // frm_ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 749);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_GuiThongBao);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.tb_NoiDung);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ccb_NguoiDang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_NgayDang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_TieuDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.lb_TieuDe);
            this.Name = "frm_ThongBao";
            this.Text = "frm_ThongBao";
            this.Load += new System.EventHandler(this.frm_ThongBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bt_Back;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        protected internal System.Windows.Forms.TextBox tb_TieuDe;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.DateTimePicker dtp_NgayDang;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.ComboBox ccb_NguoiDang;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_GuiThongBao;
        protected internal System.Windows.Forms.Button bt_Xoa;
    }
}