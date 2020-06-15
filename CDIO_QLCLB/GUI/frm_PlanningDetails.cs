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
    public partial class frm_PlanningDetails : Form
    {
        BLL.BLL_PlanningDetails bllPlanning;
        public frm_PlanningDetails(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            bllPlanning = new BLL.BLL_PlanningDetails(this);
        }

        private void frm_PlanningDetails_Load(object sender, EventArgs e)
        {
            bllPlanning.loadPlanning();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
            caseData.DataTam.DuLieu.idTemp = "";
        }
    }
}
