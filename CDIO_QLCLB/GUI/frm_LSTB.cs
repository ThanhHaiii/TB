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
    public partial class frm_LSTB : Form
    {
        BLL.BLL_LSTB bllls;
        public frm_LSTB(Form formParent)
        {
            InitializeComponent();
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllls = new BLL.BLL_LSTB(this);
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();

        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            bllls.search();
            tb_Search.Text = "";

        }

        private void frm_LSTB_Load(object sender, EventArgs e)
        {
            bllls.loadTT();
        }
    }
}
