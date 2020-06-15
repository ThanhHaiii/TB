namespace CDIO_QLCLB.GUI
{
    partial class frm_BirthDay
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
            this.bt_Back = new System.Windows.Forms.Label();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_LoiNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Chen = new System.Windows.Forms.ComboBox();
            this.bt_GuiTin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            this.SuspendLayout();
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
            // lb_TieuDe
            // 
            this.lb_TieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Location = new System.Drawing.Point(73, 74);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(1207, 23);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "Sinh Nhật Thành Viên";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_List
            // 
            this.dgv_List.AllowUserToAddRows = false;
            this.dgv_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_List.BackgroundColor = System.Drawing.Color.White;
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List.Location = new System.Drawing.Point(39, 163);
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.RowHeadersWidth = 51;
            this.dgv_List.RowTemplate.Height = 24;
            this.dgv_List.Size = new System.Drawing.Size(557, 327);
            this.dgv_List.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hôm nay là sinh nhật của:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_LoiNhan
            // 
            this.tb_LoiNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_LoiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LoiNhan.Location = new System.Drawing.Point(647, 260);
            this.tb_LoiNhan.Multiline = true;
            this.tb_LoiNhan.Name = "tb_LoiNhan";
            this.tb_LoiNhan.Size = new System.Drawing.Size(633, 181);
            this.tb_LoiNhan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gửi lời chúc mừng tới họ nào";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chèn thêm:";
            // 
            // cbb_Chen
            // 
            this.cbb_Chen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Chen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbb_Chen.FormattingEnabled = true;
            this.cbb_Chen.Items.AddRange(new object[] {
            "<HoTen>",
            "<MSSV>",
            "<Khoa>",
            "<Lop>",
            "<NgaySinh>"});
            this.cbb_Chen.Location = new System.Drawing.Point(784, 214);
            this.cbb_Chen.Name = "cbb_Chen";
            this.cbb_Chen.Size = new System.Drawing.Size(240, 24);
            this.cbb_Chen.TabIndex = 1;
            this.cbb_Chen.SelectedIndexChanged += new System.EventHandler(this.cbb_Chen_SelectedIndexChanged);
            // 
            // bt_GuiTin
            // 
            this.bt_GuiTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_GuiTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GuiTin.Image = global::CDIO_QLCLB.Properties.Resources.origami;
            this.bt_GuiTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GuiTin.Location = new System.Drawing.Point(647, 447);
            this.bt_GuiTin.Name = "bt_GuiTin";
            this.bt_GuiTin.Size = new System.Drawing.Size(633, 43);
            this.bt_GuiTin.TabIndex = 4;
            this.bt_GuiTin.Text = "Gửi Tin Nhắn";
            this.bt_GuiTin.UseVisualStyleBackColor = true;
            this.bt_GuiTin.Click += new System.EventHandler(this.bt_GuiTin_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::CDIO_QLCLB.Properties.Resources.birthDay;
            this.label4.Location = new System.Drawing.Point(1199, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 82);
            this.label4.TabIndex = 0;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_BirthDay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 550);
            this.ControlBox = false;
            this.Controls.Add(this.bt_GuiTin);
            this.Controls.Add(this.cbb_Chen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_LoiNhan);
            this.Controls.Add(this.dgv_List);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_BirthDay";
            this.Text = "Sinh nhật thành viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BirthDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bt_Back;
        protected internal System.Windows.Forms.Label lb_TieuDe;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.ComboBox cbb_Chen;
        private System.Windows.Forms.Button bt_GuiTin;
        protected internal System.Windows.Forms.DataGridView dgv_List;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox tb_LoiNhan;
    }
}