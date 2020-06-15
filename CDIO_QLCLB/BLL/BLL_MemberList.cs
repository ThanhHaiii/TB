using CDIO_QLCLB.objInProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_MemberList
    {
        GUI.frm_MemberList frmMemberlist;
        DAL.DAL_MemberList dalmemberlist = new DAL.DAL_MemberList();
        GUI.uc_member[] ucmember = new GUI.uc_member[1000];
        objInProject.MemberList memberList = new objInProject.MemberList();

        public BLL_MemberList(GUI.frm_MemberList frm)
        {
            frmMemberlist = frm;
        }

        public void loadMemberlist()
        {
            frmMemberlist.pn_List.Controls.Clear();
            string sLTVCT = dalmemberlist.getTotal("select count(IDThanhVien) from ThanhVien where IDChucVu != 8 and RoiCLB is null");
            string slCTV = dalmemberlist.getTotal("select count(IDThanhVien) from ThanhVien where IDChucVu = 8 and RoiCLB is null");
            int dem = 0;
            frmMemberlist.lb_SoLuongTVCT.Text = "Thành viên chính thức: " + sLTVCT;
            frmMemberlist.lb_CTV.Text = "Cộng tác viên: " + slCTV;

            int x = 10, y = 10;
            int soLuongTrongHang = frmMemberlist.pn_List.Size.Width / 400;
            if (caseData.DataTam.DuLieu.mbList != null)
            {
                foreach (Member mb in caseData.DataTam.DuLieu.mbList)
                {
                    ucmember[dem] = new GUI.uc_member();
                    ucmember[dem].Size = new System.Drawing.Size(300, 110);
                    ucmember[dem].Location = new System.Drawing.Point(x, y);
                    ucmember[dem].BackColor = System.Drawing.Color.WhiteSmoke;
                    ucmember[dem].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    ucmember[dem].lb_HoTen.Text = mb.HoThanhVien + " " + mb.TenThanhVien;
                    ucmember[dem].lb_ChucVu.Text = mb.TenChucVu;
                    ucmember[dem].lb_MSSV.Text = mb.Mssv;
                    if (mb.Avatar != null)
                        ucmember[dem].pic_Avatar.Image = mb.Avatar;
                    ucmember[dem].Tag = mb.IdThanhVien;
                    ucmember[dem].Cursor = System.Windows.Forms.Cursors.Hand;
                    ucmember[dem].Click += new EventHandler(usermember_Click);
                    if (frmMemberlist.pn_List.Size.Width - (ucmember[dem].Location.X + 250) > 310)
                    {
                        x += 310;
                    }
                    else
                    {
                        x = 10;
                        y += 120;
                    }

                    frmMemberlist.pn_List.Controls.Add(ucmember[dem]);
                    dem++;
                }
            }
            else
            {
                MessageBox.Show("Đang tải CSDL, Vui lòng chờ trong giây lát", "Tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void usermember_Click(object sender, EventArgs e)
        {
            caseData.DataTam.DuLieu.idTemp = ((GUI.uc_member)sender).Tag.ToString();
            caseData.DataTam.DuLieu.memberlist = true;
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(frmMemberlist.MdiParent as frm_MainForm);
            bllmain.loadaddMember();
        }

        private bool checkNum()
        {
            try
            {
                long i = long.Parse(frmMemberlist.tb_Search.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void search()
        {

            frmMemberlist.pn_List.Controls.Clear();
            if (frmMemberlist.tb_Search.Text == "")
            {
                frmMemberlist.lb_SoBanGhi.Hide();
                loadMemberlist();
            }
            else
            {
                int x = 10, y = 10, dem = 0;
                int soLuongTrongHang = frmMemberlist.pn_List.Size.Width / 400;
                List<Member> seachList = memberList.seachMember(frmMemberlist.tb_Search.Text,caseData.DataTam.DuLieu.mbList);
                foreach (Member mb in seachList)
                {
                    ucmember[dem] = new GUI.uc_member();
                    ucmember[dem].Size = new System.Drawing.Size(300, 110);
                    ucmember[dem].Location = new System.Drawing.Point(x, y);
                    ucmember[dem].BackColor = System.Drawing.Color.WhiteSmoke;
                    ucmember[dem].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    ucmember[dem].lb_HoTen.Text = mb.HoThanhVien + " " + mb.TenThanhVien;
                    ucmember[dem].lb_ChucVu.Text = mb.TenChucVu;
                    ucmember[dem].lb_MSSV.Text = mb.Mssv;
                    if (mb.Avatar != null)
                        ucmember[dem].pic_Avatar.Image = mb.Avatar;
                    ucmember[dem].Tag = mb.IdThanhVien;
                    ucmember[dem].Cursor = System.Windows.Forms.Cursors.Hand;
                    ucmember[dem].Click += new EventHandler(usermember_Click);
                    if (frmMemberlist.pn_List.Size.Width - (ucmember[dem].Location.X + 300) > 310)
                    {
                        x += 310;
                    }
                    else
                    {
                        x = 10;
                        y += 120;
                    }
                    frmMemberlist.pn_List.Controls.Add(ucmember[dem]);
                    dem++;
                }
                frmMemberlist.lb_SoBanGhi.Text = "Số bản ghi tìm được: " + dem;
                frmMemberlist.lb_SoBanGhi.Show();
            }
        }
    }
}
