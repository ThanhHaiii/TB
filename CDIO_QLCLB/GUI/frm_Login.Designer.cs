using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace CDIO_QLCLB.GUI
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MemberList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Login = new System.Windows.Forms.Button();
            this.pn_PassWD = new System.Windows.Forms.Panel();
            this.pn_UserName = new System.Windows.Forms.Panel();
            this.icon_PassWd = new System.Windows.Forms.Label();
            this.icon_User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_PassWd = new System.Windows.Forms.TextBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.lbGachNgang = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbFacebook = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.bt_Login);
            this.panel1.Controls.Add(this.pn_PassWD);
            this.panel1.Controls.Add(this.pn_UserName);
            this.panel1.Controls.Add(this.icon_PassWd);
            this.panel1.Controls.Add(this.icon_User);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_PassWd);
            this.panel1.Controls.Add(this.tb_UserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 409);
            this.panel1.TabIndex = 0;
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Login.Font = new System.Drawing.Font("UTM Mobifone KT", 16.2F);
            this.bt_Login.ForeColor = System.Drawing.Color.White;
            this.bt_Login.Image = global::CDIO_QLCLB.Properties.Resources.login;
            this.bt_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Login.Location = new System.Drawing.Point(0, 337);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Login.Size = new System.Drawing.Size(861, 72);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "Đăng nhập";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            this.bt_Login.MouseLeave += new System.EventHandler(this.bt_Login_MouseLeave);
            this.bt_Login.MouseHover += new System.EventHandler(this.bt_Login_MouseHover);
            // 
            // pn_PassWD
            // 
            this.pn_PassWD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pn_PassWD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn_PassWD.Location = new System.Drawing.Point(287, 261);
            this.pn_PassWD.Name = "pn_PassWD";
            this.pn_PassWD.Size = new System.Drawing.Size(346, 2);
            this.pn_PassWD.TabIndex = 2;
            // 
            // pn_UserName
            // 
            this.pn_UserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pn_UserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn_UserName.Location = new System.Drawing.Point(287, 176);
            this.pn_UserName.Name = "pn_UserName";
            this.pn_UserName.Size = new System.Drawing.Size(346, 2);
            this.pn_UserName.TabIndex = 2;
            // 
            // icon_PassWd
            // 
            this.icon_PassWd.Font = new System.Drawing.Font("UTM NguyenHa 02", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon_PassWd.Image = global::CDIO_QLCLB.Properties.Resources.PassWD_Black;
            this.icon_PassWd.Location = new System.Drawing.Point(204, 221);
            this.icon_PassWd.Name = "icon_PassWd";
            this.icon_PassWd.Size = new System.Drawing.Size(50, 45);
            this.icon_PassWd.TabIndex = 1;
            // 
            // icon_User
            // 
            this.icon_User.Font = new System.Drawing.Font("UTM NguyenHa 02", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon_User.Image = global::CDIO_QLCLB.Properties.Resources.avatarBlack;
            this.icon_User.Location = new System.Drawing.Point(204, 136);
            this.icon_User.Name = "icon_User";
            this.icon_User.Size = new System.Drawing.Size(50, 45);
            this.icon_User.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM NguyenHa 02", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập";
            // 
            // tb_PassWd
            // 
            this.tb_PassWd.BackColor = System.Drawing.SystemColors.Control;
            this.tb_PassWd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PassWd.Font = new System.Drawing.Font("UTM Mobifone KT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PassWd.Location = new System.Drawing.Point(287, 220);
            this.tb_PassWd.Multiline = true;
            this.tb_PassWd.Name = "tb_PassWd";
            this.tb_PassWd.Size = new System.Drawing.Size(346, 46);
            this.tb_PassWd.TabIndex = 1;
            this.tb_PassWd.Text = "Mật khẩu";
            this.tb_PassWd.TextChanged += new System.EventHandler(this.tb_PassWd_TextChanged);
            this.tb_PassWd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PassWd_KeyPress);
            this.tb_PassWd.MouseLeave += new System.EventHandler(this.tb_PassWd_MouseLeave);
            this.tb_PassWd.MouseHover += new System.EventHandler(this.tb_PassWd_MouseHover);
            // 
            // tb_UserName
            // 
            this.tb_UserName.BackColor = System.Drawing.SystemColors.Control;
            this.tb_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_UserName.Font = new System.Drawing.Font("UTM Mobifone KT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(287, 135);
            this.tb_UserName.Multiline = true;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(346, 46);
            this.tb_UserName.TabIndex = 0;
            this.tb_UserName.Text = "Tên đăng nhập";
            this.tb_UserName.TextChanged += new System.EventHandler(this.tb_UserName_TextChanged);
            this.tb_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_UserName_KeyPress);
            this.tb_UserName.MouseLeave += new System.EventHandler(this.tb_UserName_MouseLeave);
            this.tb_UserName.MouseHover += new System.EventHandler(this.tb_UserName_MouseHover);
            // 
            // lbGachNgang
            // 
            this.lbGachNgang.AllowDrop = true;
            this.lbGachNgang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGachNgang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbGachNgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGachNgang.ForeColor = System.Drawing.Color.White;
            this.lbGachNgang.Location = new System.Drawing.Point(747, -2);
            this.lbGachNgang.MaximumSize = new System.Drawing.Size(50, 50);
            this.lbGachNgang.MinimumSize = new System.Drawing.Size(50, 50);
            this.lbGachNgang.Name = "lbGachNgang";
            this.lbGachNgang.Size = new System.Drawing.Size(50, 50);
            this.lbGachNgang.TabIndex = 23;
            this.lbGachNgang.Text = "|";
            this.lbGachNgang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("UTM NguyenHa 02", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Title.Location = new System.Drawing.Point(12, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(405, 29);
            this.lb_Title.TabIndex = 26;
            this.lb_Title.Text = "CLB Tình nguyện Sinh viên Duy Tân";
            this.lb_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_Title_MouseMove);
            // 
            // lbClose
            // 
            this.lbClose.AllowDrop = true;
            this.lbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Image = global::CDIO_QLCLB.Properties.Resources.close_while;
            this.lbClose.Location = new System.Drawing.Point(799, 7);
            this.lbClose.MaximumSize = new System.Drawing.Size(50, 50);
            this.lbClose.MinimumSize = new System.Drawing.Size(50, 50);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(50, 50);
            this.lbClose.TabIndex = 25;
            this.lbClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            this.lbClose.MouseHover += new System.EventHandler(this.lbClose_MouseHover);
            // 
            // lbFacebook
            // 
            this.lbFacebook.AllowDrop = true;
            this.lbFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFacebook.Image = global::CDIO_QLCLB.Properties.Resources.facebook;
            this.lbFacebook.Location = new System.Drawing.Point(686, 7);
            this.lbFacebook.Name = "lbFacebook";
            this.lbFacebook.Size = new System.Drawing.Size(71, 50);
            this.lbFacebook.TabIndex = 24;
            this.lbFacebook.Click += new System.EventHandler(this.lbFacebook_Click);
            this.lbFacebook.MouseLeave += new System.EventHandler(this.lbFacebook_MouseLeave);
            this.lbFacebook.MouseHover += new System.EventHandler(this.lbFacebook_MouseHover);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(861, 469);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.lbGachNgang);
            this.Controls.Add(this.lbFacebook);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Text = "CLB Thiện Nguyện Nắng - Đăng Nhập";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void XuLyLoginMouseHover()
        {
            if (tb_UserName.Text.Equals("Tên đăng nhập"))
            {
                tb_UserName.Text = "";
                tb_UserName.Focus();
                pn_UserName.BackColor = System.Drawing.Color.FromArgb(0, 203, 38);
                tb_UserName.ForeColor = System.Drawing.Color.FromArgb(0, 203, 38);
                icon_User.Image = global::CDIO_QLCLB.Properties.Resources.avatar_Green;
            }
        }

        private void XuLyLoginMouseLeave()
        {
            if (tb_UserName.Text.Equals(""))
            {
                tb_UserName.Text = "Tên đăng nhập";
                pn_UserName.BackColor = System.Drawing.Color.Black;
                tb_UserName.ForeColor = System.Drawing.Color.Black;
                icon_User.Image = global::CDIO_QLCLB.Properties.Resources.avatarBlack;
            }
            else
            {
                pn_UserName.BackColor = System.Drawing.Color.Black;
                tb_UserName.ForeColor = System.Drawing.Color.Black;
                icon_User.Image = global::CDIO_QLCLB.Properties.Resources.avatarBlack;
            }
        }

        private void XuLyPassWdLeave()
        {
            if (tb_PassWd.Text.Equals(""))
            {
                tb_PassWd.Text = "Mật khẩu";
                tb_PassWd.PasswordChar = '\0';
                pn_PassWD.BackColor = System.Drawing.Color.Black;
                tb_PassWd.ForeColor = System.Drawing.Color.Black;
                icon_PassWd.Image = global::CDIO_QLCLB.Properties.Resources.PassWD_Black;
            }
            else
            {
                pn_PassWD.BackColor = System.Drawing.Color.Black;
                tb_PassWd.ForeColor = System.Drawing.Color.Black;
                icon_PassWd.Image = global::CDIO_QLCLB.Properties.Resources.PassWD_Black;
            }
        }

        private void XuLyPassWdHover()
        {
            if (tb_PassWd.Text.Equals("Mật khẩu"))
            {
                tb_PassWd.Text = "";
                tb_PassWd.PasswordChar = '*';
                tb_PassWd.Focus();
                pn_PassWD.BackColor = System.Drawing.Color.FromArgb(0, 203, 38);
                tb_PassWd.ForeColor = System.Drawing.Color.FromArgb(0, 203, 38);
                icon_PassWd.Image = global::CDIO_QLCLB.Properties.Resources.PassWD_green;
            }
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        public string layID;
        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void frm_Login_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void bt_Login_MouseHover(object sender, System.EventArgs e)
        {
            bt_Login.BackColor = System.Drawing.Color.FromArgb(0, 203, 38);
            bt_Login.ForeColor = System.Drawing.Color.Black;
        }

        private void bt_Login_MouseLeave(object sender, System.EventArgs e)
        {
            bt_Login.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            bt_Login.ForeColor = System.Drawing.Color.White;
        }

        private void lbFacebook_MouseHover(object sender, System.EventArgs e)
        {
            lbFacebook.Image = global::CDIO_QLCLB.Properties.Resources.facebook_Blue;
        }

        private void lbFacebook_MouseLeave(object sender, System.EventArgs e)
        {
            lbFacebook.Image = global::CDIO_QLCLB.Properties.Resources.facebook;
        }

        private void lbFacebook_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.facebook.com/CLBTinhNguyenSinhVienDuyTan/");
        }

        private void lbClose_MouseHover(object sender, System.EventArgs e)
        {
            lbClose.Image = global::CDIO_QLCLB.Properties.Resources.close_red;
        }

        private void lbClose_MouseLeave(object sender, System.EventArgs e)
        {
            lbClose.Image = global::CDIO_QLCLB.Properties.Resources.close_while;
        }

        private void lbClose_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lb_Title_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void tb_UserName_MouseHover(object sender, System.EventArgs e)
        {
            XuLyLoginMouseHover();
        }

        private void tb_UserName_MouseLeave(object sender, System.EventArgs e)
        {
            XuLyLoginMouseLeave();
        }

        private void tb_UserName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                bt_Login.PerformClick();
        }

        private void tb_UserName_TextChanged(object sender, System.EventArgs e)
        {
            pn_UserName.BackColor = System.Drawing.Color.FromArgb(0, 203, 38);
            tb_UserName.ForeColor = System.Drawing.Color.FromArgb(0, 203, 38);
            icon_User.Image = global::CDIO_QLCLB.Properties.Resources.avatar_Green;
        }

        private void tb_PassWd_MouseHover(object sender, System.EventArgs e)
        {
            XuLyPassWdHover();
        }

        private void tb_PassWd_MouseLeave(object sender, System.EventArgs e)
        {
            XuLyPassWdLeave();
        }

        private void tb_PassWd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                bt_Login.PerformClick();
        }

        private void tb_PassWd_TextChanged(object sender, System.EventArgs e)
        {
            tb_PassWd.PasswordChar = '*';
            pn_PassWD.BackColor = System.Drawing.Color.FromArgb(0, 203, 38);
            tb_PassWd.ForeColor = System.Drawing.Color.FromArgb(0, 203, 38);
            icon_PassWd.Image = global::CDIO_QLCLB.Properties.Resources.PassWD_green;
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbGachNgang;
        private System.Windows.Forms.Label lbFacebook;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label icon_User;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Panel pn_UserName;
        private System.Windows.Forms.Panel pn_PassWD;
        private System.Windows.Forms.Label icon_PassWd;
        protected internal System.Windows.Forms.TextBox tb_PassWd;
        private System.Windows.Forms.Button bt_Login;
    }
}