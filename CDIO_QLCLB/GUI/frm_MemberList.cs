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
    public partial class frm_MemberList : Form
    {
        BLL.BLL_MemberList bllmemberlist;
        public frm_MemberList(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllmemberlist = new BLL.BLL_MemberList(this);
            lb_SoBanGhi.Hide();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
        }

        private void frm_MemberList_Load(object sender, EventArgs e)
        {
            bllmemberlist.loadMemberlist();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            bllmemberlist.search();
            tb_Search.Text = "";
        }

        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bllmemberlist.search();
                tb_Search.Text = "";
            }
        }

        private void bt_XuatDS_Click(object sender, EventArgs e)
        {
            frm_ExportListMember frm_ExportList = new frm_ExportListMember();
            frm_ExportList.Show();
        }
    }
}
