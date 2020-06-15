using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.GUI
{
    public partial class uc_userInfo : UserControl
    {
        BLL.BLL_UserConTrol bllusercontrol;
        public uc_userInfo()
        {
            bllusercontrol = new BLL.BLL_UserConTrol(this);
            InitializeComponent();
        }

        private void uc_userInfo_Load(object sender, EventArgs e)
        {
            bllusercontrol.loadInfo();
        }

        private void lb_MSSV_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lb_ChucVu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_HoTen_Click(object sender, EventArgs e)
        {

        }

        private void pic_Avatar_Click(object sender, EventArgs e)
        {

        }
    }
}
