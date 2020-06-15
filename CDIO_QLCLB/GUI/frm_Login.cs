using System.Windows.Forms;

namespace CDIO_QLCLB.GUI
{
    public partial class frm_Login : Form
    {
        BLL.BLL_Login blllogin;
        public frm_Login()
        {
            InitializeComponent();
            blllogin = new BLL.BLL_Login(this);
        }

        private void bt_Login_Click(object sender, System.EventArgs e)
        {
            blllogin.login();
        }
    }
}
