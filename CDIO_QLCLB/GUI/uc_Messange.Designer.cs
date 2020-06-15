namespace CDIO_QLCLB.GUI
{
    partial class uc_Messange
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
            this.lb_ChatName = new System.Windows.Forms.Label();
            this.lb_NewMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_ChatName
            // 
            this.lb_ChatName.AutoSize = true;
            this.lb_ChatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChatName.Location = new System.Drawing.Point(8, 7);
            this.lb_ChatName.Name = "lb_ChatName";
            this.lb_ChatName.Size = new System.Drawing.Size(140, 18);
            this.lb_ChatName.TabIndex = 0;
            this.lb_ChatName.Text = "<Tên nhóm chat>";
            // 
            // lb_NewMessage
            // 
            this.lb_NewMessage.AutoSize = true;
            this.lb_NewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewMessage.Location = new System.Drawing.Point(11, 35);
            this.lb_NewMessage.Name = "lb_NewMessage";
            this.lb_NewMessage.Size = new System.Drawing.Size(143, 18);
            this.lb_NewMessage.TabIndex = 1;
            this.lb_NewMessage.Text = "<Tin nhắn mới nhất>";
            // 
            // uc_Messange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_NewMessage);
            this.Controls.Add(this.lb_ChatName);
            this.Name = "uc_Messange";
            this.Size = new System.Drawing.Size(355, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_ChatName;
        protected internal System.Windows.Forms.Label lb_NewMessage;
    }
}
