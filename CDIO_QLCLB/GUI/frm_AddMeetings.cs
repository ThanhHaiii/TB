using System;
using System.Windows.Forms;

namespace CDIO_QLCLB.GUI
{
    public partial class frm_AddMeetings : Form
    {
        BLL.BLL_AddMeetings blladdMeeting;
        public frm_AddMeetings(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            blladdMeeting = new BLL.BLL_AddMeetings(this);
        }

        private void frm_AddMeetings_Load(object sender, EventArgs e)
        {
            blladdMeeting.loadForm();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
            caseData.DataTam.DuLieu.idTemp = "";
        }

        private void cbb_TenTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            blladdMeeting.loadHuyen(cbb_TenTinh.SelectedValue.ToString());
        }

        private void cbb_TenHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            blladdMeeting.loadXa(cbb_TenHuyen.SelectedValue.ToString());
        }

        private void bt_Browse_Click(object sender, EventArgs e)
        {
            blladdMeeting.openfile();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            blladdMeeting.saveMeeting();
        }

        private void bt_GuiThongBao_Click(object sender, EventArgs e)
        {
            blladdMeeting.sendSMS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thao tác sẽ xóa hết các TextBox !\nBạn chắc chắn là tiếp tục?","Nhập lại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tb_DiaChiCuThe.Text = "";
                tb_linkToTrinh.Text = "";
                tb_NoiDung.Text = "";
                tb_TieuDe.Text = "";
            }
        }

        private void bt_PostFacebook_Click(object sender, EventArgs e)
        {
            blladdMeeting.facebookPosster();
        }
    }
}
