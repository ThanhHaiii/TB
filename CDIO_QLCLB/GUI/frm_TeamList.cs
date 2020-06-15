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
    public partial class frm_TeamList : Form
    {
        BLL.BLL_TeamList bllteam;
        public frm_TeamList(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllteam = new BLL.BLL_TeamList(this);
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            //bllmemberlist.search();
        }

        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
                //bllmemberlist.search();
        }

        private void tb_Facebook_Click(object sender, EventArgs e)
        {
            bllteam.clickfb();
        }

        private void bt_XoaTV_Click(object sender, EventArgs e)
        {
            bllteam.xoaThanhVien();
        }

        private void bt_addMember_Click(object sender, EventArgs e)
        {
            bllteam.addmember();
        }
    }
}
