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
    public partial class frm_MemberInfo : Form
    {
        BLL.BLL_MemberInfo bllsignUp;
        public frm_MemberInfo(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllsignUp = new BLL.BLL_MemberInfo(this);
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
            caseData.DataTam.DuLieu.idTemp = "";
        }

        private void frm_signUp_Load(object sender, EventArgs e)
        {
            bllsignUp.loadInfo();
            lb_PheDuyet.Hide();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi?","Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllsignUp.deleteMember();
                BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
                bllmain.loadIndex();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bllsignUp.pheDuyet();
        }
    }
}
