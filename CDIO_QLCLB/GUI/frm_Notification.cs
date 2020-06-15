using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.GUI
{
    public partial class frm_Notification : Form
    {
        BLL.BLL_Notification bllnotfi;
        public frm_Notification(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllnotfi = new BLL.BLL_Notification(this);
        }

        private void frm_Notification_Load(object sender, EventArgs e)
        {
            bllnotfi.loadAllNotifi();
            //linklb_NoiDung.Links.Add(56/*Bắt đầu*/, 68/*Độ dài link*/, "Đây điền nội dung link");
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
            caseData.DataTam.DuLieu.idTemp = "";
        }
    }
}
