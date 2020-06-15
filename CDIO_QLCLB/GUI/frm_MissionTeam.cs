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
    public partial class frm_MissionTeam : Form
    {
        BLL.BLL_MissionTeam bllmission;
        public frm_MissionTeam(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllmission = new BLL.BLL_MissionTeam(this);
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

        private void cbb_NVTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bllmission.loadCTNhiemVu(cbb_NVTeam.SelectedValue.ToString());
            }
            catch { }
        }

        private void cbb_TenTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            bllmission.loadHuyen(cbb_TenTinh.SelectedValue.ToString());
        }

        private void cbb_TenHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            bllmission.loadXa(cbb_TenHuyen.SelectedValue.ToString());
        }

        private void bt_SaveTeam_Click(object sender, EventArgs e)
        {
            bllmission.saveMissionTeam();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bllmission.savaMissMember();
        }

        private void cbb_TinhMem_SelectedIndexChanged(object sender, EventArgs e)
        {
            bllmission.loadHuyenMem(cbb_TinhMem.SelectedValue.ToString());
        }

        private void cbb_HuyenMem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bllmission.loadXaMem(cbb_HuyenMem.SelectedValue.ToString());
            }
            catch { }
        }

        private void cbb_NVMem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bllmission.loadCTNhiemVuMem(cbb_NVMem.SelectedValue.ToString());
            }
            catch { }
        }

        private void bt_DiemDanh_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadAttendance();
        }
    }
}
