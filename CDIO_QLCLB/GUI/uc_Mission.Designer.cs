namespace CDIO_QLCLB.GUI
{
    partial class uc_Mission
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
            this.lb_MissionName = new System.Windows.Forms.Label();
            this.lb_Deadline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_MissionName
            // 
            this.lb_MissionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MissionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MissionName.Location = new System.Drawing.Point(14, 18);
            this.lb_MissionName.Name = "lb_MissionName";
            this.lb_MissionName.Size = new System.Drawing.Size(262, 24);
            this.lb_MissionName.TabIndex = 0;
            this.lb_MissionName.Text = "<Tên nhiệm vụ>";
            this.lb_MissionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Deadline
            // 
            this.lb_Deadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Deadline.Location = new System.Drawing.Point(17, 53);
            this.lb_Deadline.Name = "lb_Deadline";
            this.lb_Deadline.Size = new System.Drawing.Size(272, 18);
            this.lb_Deadline.TabIndex = 0;
            this.lb_Deadline.Text = "<Hạn hoàn thành:>";
            this.lb_Deadline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uc_Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Deadline);
            this.Controls.Add(this.lb_MissionName);
            this.Name = "uc_Mission";
            this.Size = new System.Drawing.Size(306, 90);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_MissionName;
        protected internal System.Windows.Forms.Label lb_Deadline;
    }
}
