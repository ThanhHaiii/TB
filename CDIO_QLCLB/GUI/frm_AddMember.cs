using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CDIO_QLCLB.GUI
{
    public partial class frm_AddMember : Form
    {
        BLL.BLL_AddMember blladdmember;
        public frm_AddMember(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            blladdmember = new BLL.BLL_AddMember(this);
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            caseData.DataTam.DuLieu.idTemp = null;
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            if (caseData.DataTam.DuLieu.memberlist)
                bllmain.loadmemberlist();
            else
                bllmain.loadIndex();
        }

        private void cbb_TenTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            blladdmember.loadHuyen(cbb_TenTinh.SelectedValue.ToString());
        }

        private void cbb_TenHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            blladdmember.loadXa(cbb_TenHuyen.SelectedValue.ToString());
        }

        private void bt_ChonAnh_MouseHover(object sender, EventArgs e)
        {
            bt_ChonAnh.Show();
            bt_ChonAnh.BackColor = Color.FromArgb(180, Color.Black);
        }

        private void bt_ChonAnh_MouseLeave(object sender, EventArgs e)
        {
            bt_ChonAnh.Hide();
        }

        private void bt_ChonAnh_Click(object sender, EventArgs e)
        {
            blladdmember.loadAnh();
        }

        private void pic_Avartar_MouseHover(object sender, EventArgs e)
        {
            bt_ChonAnh.Show();
            bt_ChonAnh.BackColor = Color.FromArgb(80, Color.Black);
        }

        private void pic_Avartar_MouseLeave(object sender, EventArgs e)
        {
        }

        private void frm_AddMember_Load_1(object sender, EventArgs e)
        {
            blladdmember.loadRePassWD();
            blladdmember.loadTinh();
            bt_ChonAnh.Hide();
            blladdmember.loadAddmember();
        }

        private void bt_Save_Click_1(object sender, EventArgs e)
        {
            blladdmember.saveMember();
        }

        private void tb_NhapLai_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thao tác sẽ làm mất hết dữ liệu bạn vừa điền.\nBạn có muốn tiếp tục?","Cảnh báo",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                blladdmember.loadAddmember();
            }
        }

        private void rdb_CTV_CheckedChanged(object sender, EventArgs e)
        {
            cbb_ChucVu.SelectedIndex = 7;
            cbb_ChucVu.Enabled = false;
        }

        private void rdb_TVCT_CheckedChanged(object sender, EventArgs e)
        {
            cbb_ChucVu.SelectedIndex = 6;
            cbb_ChucVu.Enabled = true;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn đang thao thác xóa thành viên : " + tb_Ho.Text + " " + 
                tb_Ten.Text + "\nViệc xóa sẽ làm mất dữ liệu thành viên.\nBạn có chắc chắn tiếp tục?","Xóa ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                blladdmember.xoaThanhVien();
            }
        }

        private void bt_DoiPass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đổi mật khẩu", "Đổi mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                blladdmember.doipasswd();
        }

        private void lb_Export_Click(object sender, EventArgs e)
        {
            Thread exportThread = new Thread(blladdmember.exportComfirMember);
            exportThread.IsBackground = true;
            exportThread.Start();
        }
    }
}
