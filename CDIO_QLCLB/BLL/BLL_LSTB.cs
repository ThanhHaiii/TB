using CDIO_QLCLB.objInProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_LSTB
    {
        GUI.frm_LSTB frmLSThongBao;
        DAL.DAL_LSTB dalLSTB = new DAL.DAL_LSTB();
        GUI.uc_tt[] uctt = new GUI.uc_tt[1000];

        public BLL_LSTB(GUI.frm_LSTB frm)
        {
            frmLSThongBao = frm;
        }
        public void loadTT()
        {
            frmLSThongBao.pn_List.Controls.Clear();
            int dem = 0;
            int x = 10, y = 10;
            int soLuongTrongHang = frmLSThongBao.pn_List.Size.Width / 400;
            uctt[dem] = new GUI.uc_tt();
            if (caseData.DataTam.DuLieu.mbList != null)
            {
                foreach (Member mb in caseData.DataTam.DuLieu.mbList)
                {
                    uctt[dem].Size = new System.Drawing.Size(300, 110);
                    uctt[dem].Location = new System.Drawing.Point(x, y);
                    uctt[dem].BackColor = System.Drawing.Color.WhiteSmoke;
                    uctt[dem].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    uctt[dem].lb_nguoidang.Text = mb.HoThanhVien + " " + mb.TenThanhVien;
                    uctt[dem].Cursor = System.Windows.Forms.Cursors.Hand;
                    if (frmLSThongBao.pn_List.Size.Width - (uctt[dem].Location.X + 250) > 310)
                    {
                        x += 310;
                    }
                    else
                    {
                        x = 10;
                        y += 120;
                    }

                    frmLSThongBao.pn_List.Controls.Add(uctt[dem]);
                    dem++;
                }
            }
            else
            {
                MessageBox.Show("Đang tải CSDL, Vui lòng chờ trong giây lát", "Tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool checkNum()
        {
            try
            {
                long i = long.Parse(frmLSThongBao.tb_Search.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void search()
        {

            frmLSThongBao.pn_List.Controls.Clear();
            if (frmLSThongBao.tb_Search.Text == "")
            {
                loadTT();
            }

        }
    }

}

