using CDIO_QLCLB.logical;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CDIO_QLCLB.GUI
{
    // ten no se la Frm_Index
    // C# 
    public partial class frm_Home : Form
    {
        logical.GetToaDo td = new GetToaDo();
        BLL.BLL_Home bll_index;
        public frm_Home(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bll_index = new BLL.BLL_Home(this);
        }

        private void frm_Index_Load(object sender, EventArgs e)
        {
            bll_index.loadIndex();
            bll_index.loadPlan();
            bll_index.loadNotification();
            bll_index.loadSignUpMember();
            bll_index.loadThongKe();
        }

        private void tb_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pn_KHSapToi_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bt_LenLichHop_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadAddMeetings();
        }

        private void bt_ThemThanhVien_Click(object sender, EventArgs e)
        {
            caseData.DataTam.DuLieu.memberlist = false;
            caseData.DataTam.DuLieu.idTemp = "";
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadaddMember();
        }

        private void bt_QLNhom_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadTeamList();
        }

        private void bt_LapKH_Click(object sender, EventArgs e)
        {

        }

        private void bt_XuatQuy_Click(object sender, EventArgs e)
        {

        }

        private void bt_NhapQuy_Click(object sender, EventArgs e)
        {

        }

        private void uc_userInfo1_MouseClick(object sender, MouseEventArgs e)
        {
            caseData.DataTam.DuLieu.idTemp = caseData.DataTam.DuLieu.ID;
            caseData.DataTam.DuLieu.memberlist = false;
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadaddMember();
        }

        private void loadThoiTiet_Tick(object sender, EventArgs e)
        {
            try
            {
                td.openGPS();
                caseData.DataTam.DuLieu.toado = td.DoiToaDo(caseData.DataTam.DuLieu.kinhdo, caseData.DataTam.DuLieu.vido);
                loadThoiTiet.Stop();
                bll_index.loadWeather();
            }
            catch { }
        }

        private void loadWeather2h_Tick(object sender, EventArgs e)
        {
            try
            {
                td.openGPS();
                caseData.DataTam.DuLieu.toado = td.DoiToaDo(caseData.DataTam.DuLieu.kinhdo, caseData.DataTam.DuLieu.vido);
                loadThoiTiet.Stop();
                pn_ThoiTiet.Controls.Clear();
                bll_index.loadWeather();
            }
            catch { }
        }

        private void loadThongBao_Tick(object sender, EventArgs e)
        {
            pn_ThongBaoMoi.Controls.Clear();
            bll_index.loadNotification();
        }

        private void loadSignUp_Tick(object sender, EventArgs e)
        {
            pn_DKMoi.Controls.Clear();
            bll_index.loadSignUpMember();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            bll_index.logout();
        }
    }
}
