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
    public partial class frm_TeamManager : Form
    {
        BLL.BLL_TeamManager bllteam;
        public frm_TeamManager(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllteam = new BLL.BLL_TeamManager(this);
        }

        private void tb_Facebook_Click(object sender, EventArgs e)
        {
            bllteam.clickfb();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
        }

        private void tb_TaoNhom_Click_1(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadcreatTeam();
        }

        private void tb_SuaNhom_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadmodify();
        }

        private void bt_PhanCong_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadMissionTeam();
        }

        private void bt_DiemDanh_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadAttendance();
        }
    }
}
