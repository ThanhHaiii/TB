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
    public partial class frm_AddTeam : Form
    {
        BLL.BLL_AddTeam blladdteam;
        public frm_AddTeam(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            blladdteam = new BLL.BLL_AddTeam(this);
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadTeamList();
        }

        private void bt_ThemThanhVien_Click(object sender, EventArgs e)
        {
            blladdteam.addMember();
        }

        private void bt_AddTaoNhom_Click(object sender, EventArgs e)
        {
            blladdteam.createTeam();
        }

        private void bt_AddDeletemember_Click(object sender, EventArgs e)
        {
            blladdteam.xoaThanhVien();
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
