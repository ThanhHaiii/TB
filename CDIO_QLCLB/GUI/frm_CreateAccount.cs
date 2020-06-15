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
    public partial class frm_CreateAccount : Form
    {
        BLL.BLL_CreateAccount bllcreateaccount;
        public frm_CreateAccount(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllcreateaccount = new BLL.BLL_CreateAccount(this);
            bllcreateaccount.loadMemberList();
        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            bllcreateaccount.createaccount();
        }
    }
}
