using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_ModifyTeam
    {
        DAL.DAL_ModifyTeam dalmodifyteam = new DAL.DAL_ModifyTeam();
        GUI.frm_ModifyTeam frmmodifyteam;

        GUI.uc_team teams;
        string teamID;
        public BLL_ModifyTeam(GUI.frm_ModifyTeam modifilygui)
        {
            frmmodifyteam = modifilygui;
            loadTeamList();
        }

        private void loadTeamList()
        {
            frmmodifyteam.pn_TeamList.Controls.Clear();
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' + MSSV) as HoTen,IDNhom, TenNhom from Nhom,ThanhVien where Nhom.NhomTruong = ThanhVien.IDThanhVien and NgungHD is null";
            DataTable dtlist = dalmodifyteam.loadData(sqlquery);
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

                frmmodifyteam.pn_TeamList.Controls.Add(teams);
            }
        }

        private void loadcbbleader()
        {
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' +  MSSV) as HoTen, IDThanhVien from ThanhVien where RoiCLB is null";
            DataTable dtThanhVien = dalmodifyteam.loadData(sqlquery);
            frmmodifyteam.cbb_AddNhomTruong.DataSource = dtThanhVien.Copy();
            frmmodifyteam.cbb_AddNhomTruong.DisplayMember = "HoTen";
            frmmodifyteam.cbb_AddNhomTruong.ValueMember = "IDThanhVien";
        }

        private void loadcbbThanhVien(string idNhom)
        {
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' +  MSSV) as HoTen, IDThanhVien from ThanhVien, ChucVu where ThanhVien.IDChucVu = ChucVu.IDChucVu and IDThanhVien not in (select IDThanhVien from ThanhVien_Nhom where IDNhom = " + idNhom + " and NgungHD is null) and RoiCLB is null";
            DataTable dtThanhVien = dalmodifyteam.loadData(sqlquery);
            frmmodifyteam.cbb_AddListMember.DataSource = dtThanhVien.Copy();
            frmmodifyteam.cbb_AddListMember.DisplayMember = "HoTen";
            frmmodifyteam.cbb_AddListMember.ValueMember = "IDThanhVien";
        }

        private void loadTeaminfo(string id)
        {
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' + MSSV) as HoTen,IDNhom, TenNhom from Nhom,ThanhVien where Nhom.NhomTruong = ThanhVien.IDThanhVien and IDNhom = " + id;
            DataTable dt = dalmodifyteam.loadData(sqlquery);
            frmmodifyteam.tb_AddTenNhom.Text = dt.Rows[0]["TenNhom"].ToString();
        }

        private void loadLeader(string idNhom)
        {
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' + MSSV) as HoTen,IDNhom, TenNhom from Nhom,ThanhVien where Nhom.NhomTruong = ThanhVien.IDThanhVien and IDNhom = " + idNhom;
            DataTable dt = dalmodifyteam.loadData(sqlquery);
            frmmodifyteam.cbb_AddNhomTruong.SelectedIndex = frmmodifyteam.cbb_AddNhomTruong.FindString(dt.Rows[0]["HoTen"].ToString());
        }

        private void loadTVNhom(string idNhom)
        {
            string sqlquery = "select ThanhVien.IDThanhVien,HoThanhVien,TenThanhVien,MSSV,iif(GioiTinh = 1, N'Nam',N'Nữ') as gioitinh from ThanhVien_Nhom inner join ThanhVien on ThanhVien.IDThanhVien = ThanhVien_Nhom.IDThanhVien and NgungHD is null and ThanhVien_Nhom.IDNhom = " + idNhom + " left join PhanCongTV on ThanhVien_Nhom.IDThanhVien = PhanCongTV.IDThanhVien left join NhiemVu on NhiemVu.IDNhiemVu = PhanCongTV.IDNhiemVu";
            DataTable dtTV = dalmodifyteam.loadData(sqlquery);
            frmmodifyteam.dtg_AddThanhVien.DataSource = dtTV;
        }

        public void addmember()
        {
            if (frmmodifyteam.cbb_AddListMember.SelectedIndex > -1)
            {
                string sqlquery = "insert into ThanhVien_Nhom(IDNhom,IDThanhVien,NgayVaoNhom) values(" + teamID + "," + frmmodifyteam.cbb_AddListMember.SelectedValue + ",getdate())";
                if (dalmodifyteam.modify(sqlquery) > 0)
                {
                    loadTVNhom(teamID);
                    loadcbbThanhVien(teamID);
                }
            }
        }

        public void update()
        {
            string sqlquery = "update Nhom set NhomTruong = " + frmmodifyteam.cbb_AddNhomTruong.SelectedValue + ", TenNhom = N'" +
                frmmodifyteam.tb_AddTenNhom.Text + "' where IDNhom = " + teamID;
            if (dalmodifyteam.modify(sqlquery) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }

        public void xoaThanhVien()
        {
            if (frmmodifyteam.dtg_AddThanhVien.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa những thành viên đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < frmmodifyteam.dtg_AddThanhVien.SelectedRows.Count; i++)
                    {
                        string idThanhVien = frmmodifyteam.dtg_AddThanhVien.SelectedRows[i].Cells[0].Value.ToString();
                        string sqlquery = "update ThanhVien_Nhom set NgungHD = getdate() where IDThanhVien = " + idThanhVien + " and IDNhom = " + teamID;
                        dalmodifyteam.modify(sqlquery);
                        frmmodifyteam.dtg_AddThanhVien.Rows.RemoveAt(frmmodifyteam.dtg_AddThanhVien.SelectedRows[i].Index);
                    }
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn thành viên muốn xóa");
            }
        }

        private void teamClick(object sender, EventArgs e)
        {
            teamID = ((GUI.uc_team)sender).Tag.ToString();
            loadcbbleader();
            loadcbbThanhVien(teamID);
            loadLeader(teamID);
            loadTeaminfo(teamID);
            loadTVNhom(teamID);
        }
    }
}
