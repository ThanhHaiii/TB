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
    public partial class frm_ThongBao : Form
    {
        BLL.BLL_ThongBao bllThongBao;
        public frm_ThongBao(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllThongBao = new BLL.BLL_ThongBao(this);
        }

        private void frm_ThongBao_Load(object sender, EventArgs e)
        {
            bllThongBao.loadForm();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
            caseData.DataTam.DuLieu.idTemp = "";
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            bllThongBao.saveThongBao();
        }

        private void bt_GuiThongBao_Click(object sender, EventArgs e)
        {
            bllThongBao.sendThongBao();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đang thao thác xóa thông báo : " + tb_TieuDe.Text + 
                 "\nViệc xóa sẽ làm mất dữ liệu thông báo.\nBạn có chắc chắn tiếp tục?", "Xóa ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllThongBao.XoaTT();
            }
        }
    }
}
