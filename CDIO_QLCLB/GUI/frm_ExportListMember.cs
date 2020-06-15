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
    public partial class frm_ExportListMember : Form
    {
        BLL.BLL_ExportMember bLL_Export;
        public frm_ExportListMember()
        {
            InitializeComponent();
            bLL_Export = new BLL.BLL_ExportMember(this);
        }

        private void bt_Export_Click(object sender, EventArgs e)
        {
            bLL_Export.exportExcel();
        }

        private void rdb_All_CheckedChanged(object sender, EventArgs e)
        {
            bLL_Export.loadAllMember();
        }

        private void rdb_TVCT_CheckedChanged(object sender, EventArgs e)
        {
            bLL_Export.loadTVCT();
        }

        private void rdb_CTV_CheckedChanged(object sender, EventArgs e)
        {
            bLL_Export.loadCTV();
        }
    }
}
