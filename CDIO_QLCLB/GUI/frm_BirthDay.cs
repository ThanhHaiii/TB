using System;
using System.Windows.Forms;

namespace CDIO_QLCLB.GUI
{
    public partial class frm_BirthDay : Form
    {
        BLL.BLL_BirthDay bllbirth;
        public frm_BirthDay(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllbirth = new BLL.BLL_BirthDay(this);
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
            caseData.DataTam.DuLieu.idTemp = "";
        }

        private void frm_BirthDay_Load(object sender, EventArgs e)
        {
            bllbirth.loadThanhVien();
        }

        private void cbb_Chen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectionIndex = tb_LoiNhan.SelectionStart;
            var insertText = " " + cbb_Chen.Text + " ";
            tb_LoiNhan.Text = tb_LoiNhan.Text.Insert(selectionIndex, insertText);
            tb_LoiNhan.SelectionStart = selectionIndex + insertText.Length;
        }

        private void bt_GuiTin_Click(object sender, EventArgs e)
        {
            bllbirth.sendSMS();
        }
    }
}
