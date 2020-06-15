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
    public partial class frm_Attendance : Form
    {
        BLL.BLL_Attendance bLL_attendance;
        public frm_Attendance(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;

            bLL_attendance = new BLL.BLL_Attendance(this);
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadTeamList();
        }

        private void bt_ThemThanhVien_Click(object sender, EventArgs e)
        {
            //bllmodify.addmember();
        }

        private void bt_AddDeletemember_Click(object sender, EventArgs e)
        {
            //bllmodify.xoaThanhVien();
        }

        private void tb_TaoNhom_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadcreatTeam();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            //bllmodify.update();
        }

        private void bt_SelectAll_Click(object sender, EventArgs e)
        {
            string idteam = ((Button)sender).Tag.ToString();
            bLL_attendance.selectall(idteam);
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            string idteam = ((Button)sender).Tag.ToString();
            bLL_attendance.clearSelectAll(idteam);
        }

        private void bt_DDanh_Click(object sender, EventArgs e)
        {
            string idteam = ((Button)sender).Tag.ToString();
            bLL_attendance.diemDanh(idteam);
        }
    }
}
