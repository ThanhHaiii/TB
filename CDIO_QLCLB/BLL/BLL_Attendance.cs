using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_Attendance
    {
        DAL.DAL_Attendance dal_Attendance = new DAL.DAL_Attendance();
        GUI.frm_Attendance frm_attendance;
        GUI.uc_Attendance[] uc_Attendances = new GUI.uc_Attendance[50];
        XuLyAnh.MaHoaHinhAnh convertImage = new XuLyAnh.MaHoaHinhAnh();
        GUI.uc_team teams;

        public BLL_Attendance(GUI.frm_Attendance frm)
        {
            frm_attendance = frm;
            loadTeamList();
        }

        private void loadTeamList()
        {
            frm_attendance.pn_TeamList.Controls.Clear();
            frm_attendance.lb_DSThanhVien.Text = "Danh sách thành viên";
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien) as HoTen,IDNhom, TenNhom from Nhom,ThanhVien where NgungHD is null and Nhom.NhomTruong = ThanhVien.IDThanhVien";
            DataTable dtlist = dal_Attendance.getData(sqlquery);
            for (int i = 0; i < dtlist.Rows.Count; i++)
            {
                teams = new GUI.uc_team();
                teams.Dock = System.Windows.Forms.DockStyle.Top;
                teams.Location = new System.Drawing.Point(0, 0);
                teams.Name = "uc_team1" + i;
                teams.Size = new System.Drawing.Size(310, 63);
                teams.Cursor = System.Windows.Forms.Cursors.Hand;
                teams.Tag = dtlist.Rows[i]["IDNhom"].ToString();
                teams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                teams.lb_TenNhomTuong.Text = "Nhóm trưởng: " + dtlist.Rows[i]["HoTen"].ToString();
                teams.lb_TenNhom.Text = dtlist.Rows[i]["TenNhom"].ToString();
                teams.TabIndex = 0;
                teams.Click += new EventHandler(teamClick);

                frm_attendance.pn_TeamList.Controls.Add(teams);
            }
        }

        private void teamClick(object sender, EventArgs e)
        {
            string idTeam = ((GUI.uc_team)sender).Tag.ToString();
            frm_attendance.bt_SelectAll.Tag = idTeam;
            frm_attendance.bt_Clear.Tag = idTeam;
            frm_attendance.bt_DDanh.Tag = idTeam;
            loadMemberList(idTeam);
            loadKeHoach();
        }

        private void loadMemberList(string idTeam)
        {
            objInProject.MemberList memberList = new objInProject.MemberList();
            string sqlquery = "select IDThanhVien from ThanhVien_Nhom where IDNhom = " + idTeam + " and NgungHD is null";
            DataTable dt = dal_Attendance.getData(sqlquery);
            List<objInProject.Member> list = memberList.seachMemberID(dt, caseData.DataTam.DuLieu.mbList);

            int x = 10, y = 10;
            int widthUC = frm_attendance.pn_MemberList.Size.Width / 2 - 20;
            frm_attendance.pn_MemberList.Controls.Clear();
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sqlquery = "select iif(datediff(hh,max(ThoiGian),getdate()) < 3,0,1) from DiemDanh where IDThanhVien = " + list[i].IdThanhVien 
                        + " and NhomDiemDanh = " + idTeam;
                    int daDiemDanh = int.Parse(dal_Attendance.getID(sqlquery));
                    uc_Attendances[i] = new GUI.uc_Attendance();
                    uc_Attendances[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    uc_Attendances[i].Location = new System.Drawing.Point(x, y);
                    uc_Attendances[i].Name = list[i].IdThanhVien;
                    uc_Attendances[i].Size = new System.Drawing.Size(widthUC, 85);
                    uc_Attendances[i].TabIndex = i;
                    uc_Attendances[i].lb_ChucVu.Text = list[i].TenChucVu;

                    uc_Attendances[i].lb_HoTen.Text = list[i].HoThanhVien + " " + list[i].TenThanhVien;
                    uc_Attendances[i].lb_MSSV.Text = list[i].Mssv;
                    if (list[i].Avatar != null)
                    {
                        uc_Attendances[i].pic_Avatar.Image = list[i].Avatar;
                    }

                    if(daDiemDanh == 0)
                    {
                        uc_Attendances[i].Enabled = false;
                    }
                    else
                    {
                        uc_Attendances[i].Enabled = true;
                    }

                    if ((i+1) % 2 != 0)
                    {
                        x = widthUC + 30;
                    }
                    else
                    {
                        x = 10;
                        y += 90;
                    }
                    frm_attendance.pn_MemberList.Controls.Add(uc_Attendances[i]);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
        }

        public void selectall(string idTeam)
        {
            string sqlquery = "select count(IDThanhVien) from ThanhVien_Nhom where NgungHD is null and IDNhom = " + idTeam;
            int soControll = int.Parse(dal_Attendance.getID(sqlquery).ToString());
            for(int i = 0; i< soControll; i++)
            {
                if (uc_Attendances[i].Enabled == true)
                {
                    uc_Attendances[i].ckb_Tick.Checked = true;
                }
            }
        }

        public void clearSelectAll(string idTeam)
        {
            string sqlquery = "select count(IDThanhVien) from ThanhVien_Nhom where NgungHD is null and IDNhom = " + idTeam;
            int soControll = int.Parse(dal_Attendance.getID(sqlquery).ToString());
            for (int i = 0; i < soControll; i++)
            {
                uc_Attendances[i].ckb_Tick.Checked = false;
            }
        }

        public void diemDanh(string idTeam)
        {
            string sqlquery = "select count(IDThanhVien) from ThanhVien_Nhom where NgungHD is null and IDNhom = " + idTeam;
            int soControll = int.Parse(dal_Attendance.getID(sqlquery).ToString());
            string idKeHoach = frm_attendance.cbb_keHoach.SelectedValue.ToString();
            int dem = 0;
            for (int i = 0; i < soControll; i++)
            {
                if(uc_Attendances[i].ckb_Tick.Checked == true)
                {
                    sqlquery = "insert into DiemDanh(IDThanhVien,ThoiGian,GhiChu,KeHoach,NhomDiemDanh) values(" + uc_Attendances[i].Name + ",getdate(),N'"
                        + frm_attendance.tb_GhiChu.Text + "'," + idKeHoach + "," + idTeam + ")";
                    dal_Attendance.diemDanh(sqlquery);
                    uc_Attendances[i].Enabled = false;
                    dem++;
                }
            }
            MessageBox.Show("Đã điểm danh: " + dem + "/" + soControll + " thành viên");
        }

        private void loadKeHoach()
        {
            string sqlquery = "select * from KeHoach where HoanThanhKH = 0";
            DataTable dt = dal_Attendance.getData(sqlquery);
            frm_attendance.cbb_keHoach.DataSource = dt.Copy();
            frm_attendance.cbb_keHoach.DisplayMember = "TieuDe";
            frm_attendance.cbb_keHoach.ValueMember = "IDKeHoach";
        }
    }
}
