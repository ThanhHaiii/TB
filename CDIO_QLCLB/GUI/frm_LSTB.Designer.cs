namespace CDIO_QLCLB.GUI
{
    partial class frm_LSTB
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
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.pn_List = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Search = new System.Windows.Forms.Label();
            this.bt_Back = new System.Windows.Forms.Label();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(25, 91);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(286, 29);
            this.tb_Search.TabIndex = 12;
            // 
            // pn_List
            // 
            this.pn_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_List.AutoScroll = true;
            this.pn_List.Location = new System.Drawing.Point(25, 176);
            this.pn_List.Name = "pn_List";
            this.pn_List.Size = new System.Drawing.Size(1197, 294);
            this.pn_List.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(25, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 1);
            this.panel1.TabIndex = 11;
            // 
            // bt_Search
            // 
            this.bt_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.Image = global::CDIO_QLCLB.Properties.Resources.search;
            this.bt_Search.Location = new System.Drawing.Point(328, 91);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(32, 32);
            this.bt_Search.TabIndex = 6;
            this.bt_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Back
            // 
            this.bt_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Back.Image = global::CDIO_QLCLB.Properties.Resources.left_arrow;
            this.bt_Back.Location = new System.Drawing.Point(21, 21);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(32, 32);
            this.bt_Back.TabIndex = 7;
            this.bt_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_TieuDe.Location = new System.Drawing.Point(59, 21);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(1163, 39);
            this.lb_TieuDe.TabIndex = 10;
            this.lb_TieuDe.Text = "LỊCH SỬ THÔNG BÁO";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_LSTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 749);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.pn_List);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.lb_TieuDe);
            this.Name = "frm_LSTB";
            this.Text = "frm_LSTB";
            this.Load += new System.EventHandler(this.frm_LSTB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.TextBox tb_Search;
        protected internal System.Windows.Forms.Panel pn_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bt_Search;
        private System.Windows.Forms.Label bt_Back;
        protected internal System.Windows.Forms.Label lb_TieuDe;
    }
}