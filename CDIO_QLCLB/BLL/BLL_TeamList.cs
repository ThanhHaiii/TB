using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_TeamList
    {
        DAL.DAL_TeamList dalteam = new DAL.DAL_TeamList();
        GUI.frm_TeamList frmtemlist;
        string linkfb, idteam;

        GUI.uc_team[] teams = new GUI.uc_team[500];
        GUI.uc_NhiemVuTeam[] nhiemVu = new GUI.uc_NhiemVuTeam[10000];
        public BLL_TeamList(GUI.frm_TeamList teamfrm)
        {
            frmtemlist = teamfrm;
            loadTeamList();
        }

        private void loadcbbThanhVien(string idNhom)
        {
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' +  MSSV) as HoTen, IDThanhVien from ThanhVien, ChucVu where ThanhVien.IDChucVu = ChucVu.IDChucVu and IDThanhVien not in (select IDThanhVien from ThanhVien_Nhom where IDNhom = " + idNhom + " and ConHoatDong = 1)";
            DataTable dtThanhVien = dalteam.getDatabase(sqlquery);
            frmtemlist.cb_ThemTV.DataSource = dtThanhVien.Copy();
            frmtemlist.cb_ThemTV.DisplayMember = "HoTen";
            frmtemlist.cb_ThemTV.ValueMember = "IDThanhVien";
        }

        private void loadTeamList()
        {
            frmtemlist.pn_TeamList.Controls.Clear();
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien) as HoTen,IDNhom, TenNhom from Nhom,ThanhVien where Nhom.NhomTruong = ThanhVien.IDThanhVien";
            DataTable dtlist = dalteam.getDatabase(sqlquery);
            for(int i = 0; i < dtlist.Rows.Count; i++)
            {
                teams[i] = new GUI.uc_team();
                teams[i].Dock = System.Windows.Forms.DockStyle.Top;
                teams[i].Location = new System.Drawing.Point(0, 0);
                teams[i].Name = "uc_team1";
                teams[i].Size = new System.Drawing.Size(310, 63);
                teams[i].Cursor = System.Windows.Forms.Cursors.Hand;
                teams[i].Tag = dtlist.Rows[i]["IDNhom"].ToString();
                teams[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                teams[i].lb_TenNhomTuong.Text = "Nhóm trưởng: " + dtlist.Rows[i]["HoTen"].ToString();
                teams[i].lb_TenNhom.Text = dtlist.Rows[i]["TenNhom"].ToString();
                teams[i].TabIndex = 0;
                teams[i].Click += new EventHandler(teamClick);

                frmtemlist.pn_TeamList.Controls.Add(teams[i]);
            }
            frmtemlist.pn_InfoTeam.Hide();
            frmtemlist.lb_TeamName.Hide();
        }

        private void loadTeamInfo(string idTeam)
        {
            frmtemlist.pn_InfoTeam.Show();
            frmtemlist.lb_TeamName.Show();
            loadcbbThanhVien(idTeam);
            string sqlLeader = "select (HoThanhVien + ' ' +TenThanhVien) as HoTen,SDT,LinkFB,NgayLapNhom,TenNhom from Nhom,ThanhVien where ThanhVien.IDThanhVien = Nhom.NhomTruong and IDNhom = " + idTeam;
            string sqlsoTV = "select COUNT(IDThanhVien) as SLTV from ThanhVien_Nhom where IDNhom = " + idTeam;
            string sqlDiem = "select sum(DiemNhiemVu) AS Diem from PhanCongNhom where IDNhom = " + idTeam + " group by IDNhom,DiemNhiemVu";
            frmtemlist.lb_SoThanhVien.Text = "Số thành viên: " + dalteam.getCell(sqlsoTV);
            frmtemlist.lb_Ranking.Text = "Điểm hoạt động: " + dalteam.getCell(sqlDiem);
            DataTable dt = dalteam.getDatabase(sqlLeader);

            frmtemlist.lb_NhomTruong.Text = "Nhóm trưởng: " + dt.Rows[0]["HoTen"].ToString();
            frmtemlist.lb_SDTNhomTruong.Text = "SĐT nhóm trưởng: " + dt.Rows[0]["SDT"].ToString();
            DateTime ngayLap = DateTime.Parse(dt.Rows[0]["NgayLapNhom"].ToString());
            frmtemlist.lb_NgayLapNhom.Text = "Ngày lập nhóm: " + string.Format("{0:dd/MM/yyyy}", ngayLap);
            frmtemlist.lb_TeamName.Text = dt.Rows[0]["TenNhom"].ToString();
            linkfb = dt.Rows[0]["LinkFB"].ToString();
        }

        public void clickfb()
        {
            System.Diagnostics.Process.Start(linkfb);
        }

        private void loadPhanCong(string idNhom)
        {
            string sqlQuery = "select Top(10000) IDPhanCong,TenNhiemVu,(HoThanhVien + ' ' + TenThanhVien) as HoTen, NgayPhanCong,HanHoanThanh,DiaChiCuThe,TenXa,TenHuyen,TenTinh from PhanCongNhom left join NhiemVu on NhiemVu.IDNhiemVu = PhanCongNhom.IDNhiemVu and PhanCongNhom.IDNhom = " + idNhom + " left join ThanhVien on ThanhVien.IDThanhVien = PhanCongNhom.NguoiPhanCong left join DiaChi on PhanCongNhom.DiaChi = DiaChi.IDDiaChi left join Xa on DiaChi.IDXa = Xa.IDXa left join Huyen on Xa.IDHuyen = Huyen.IDHuyen left join Tinh on Huyen.IDTinh = Tinh.IDTinh order by NgayPhanCong";
            DataTable dtNV = dalteam.getDatabase(sqlQuery);
            frmtemlist.pn_NhiemVu.Controls.Clear();
            for (int i = 0; i < dtNV.Rows.Count; i++)
            {
                nhiemVu[i] = new GUI.uc_NhiemVuTeam();
                nhiemVu[i].BackColor = System.Drawing.Color.WhiteSmoke;
                nhiemVu[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                nhiemVu[i].Dock = System.Windows.Forms.DockStyle.Top;
                nhiemVu[i].Location = new System.Drawing.Point(0, 0);
                nhiemVu[i].Name = "uc_NhiemVuTeam" + i;
                nhiemVu[i].lb_NguoiRaNV.Text = "Người ra nhiệm vụ: " + dtNV.Rows[i]["HoTen"].ToString();
                nhiemVu[i].lb_TenNV.Text = dtNV.Rows[i]["TenNhiemVu"].ToString();
                nhiemVu[i].lb_location.Text = "Địa chỉ thực hiện: " + dtNV.Rows[i]["DiaChiCuThe"].ToString() + " - " + dtNV.Rows[i]["TenXa"].ToString() + " - " +
                    dtNV.Rows[i]["TenHuyen"].ToString() + " - " + dtNV.Rows[i]["TenTinh"].ToString();
                DateTime datestart = DateTime.Parse(dtNV.Rows[i]["NgayPhanCong"].ToString());
                nhiemVu[i].lb_TimeStart.Text = "Ngày ra nhiệm vụ: " + string.Format("{0:dd/MM/yyyy}", datestart);
                DateTime dateend = DateTime.Parse(dtNV.Rows[i]["HanHoanThanh"].ToString());
                nhiemVu[i].lb_TimeEnd.Text = "Hạn hoàn thành: " + string.Format("{0:dd/MM/yyyy}", dateend);
                nhiemVu[i].Cursor = System.Windows.Forms.Cursors.Hand;
                nhiemVu[i].TabIndex = 0;

                frmtemlist.pn_NhiemVu.Controls.Add(nhiemVu[i]);
            }
        }

        private void loadTVNhom(string idNhom)
        {
            string sqlquery = "select ThanhVien.IDThanhVien,HoThanhVien,TenThanhVien,MSSV,TenNhiemVu,iif(DiemNhiemVu is NULL,N'Chưa hoàn thành nhiệm vụ', N'Đã hoàn thành nhiệm vụ') as HoanThanhNV from ThanhVien_Nhom inner join ThanhVien on ThanhVien.IDThanhVien = ThanhVien_Nhom.IDThanhVien and ThanhVien_Nhom.ConHoatDong != 0 and ThanhVien_Nhom.IDNhom = " + idNhom + " left join PhanCongTV on ThanhVien_Nhom.IDThanhVien = PhanCongTV.IDThanhVien left join NhiemVu on NhiemVu.IDNhiemVu = PhanCongTV.IDNhiemVu";
            DataTable dtTV = dalteam.getDatabase(sqlquery);
            frmtemlist.dgv_DSTV.DataSource = dtTV;
        }

        private void teamClick(object sender, EventArgs e)
        {
            string idTeam = ((GUI.uc_team)sender).Tag.ToString();
            loadTeamInfo(idTeam);
            loadTVNhom(idTeam);
            loadPhanCong(idTeam);
            idteam = idTeam;
        }

        public void xoaThanhVien()
        {
            if(frmtemlist.dgv_DSTV.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa những thành viên đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < frmtemlist.dgv_DSTV.SelectedRows.Count; i++)
                    {
                        string idThanhVien = frmtemlist.dgv_DSTV.SelectedRows[i].Cells[0].Value.ToString();
                        string sqlquery = "update ThanhVien_Nhom set ConHoatDong = 0 where IDThanhVien = " + idThanhVien;
                        dalteam.deleteMemberTeam(sqlquery);
                        frmtemlist.dgv_DSTV.Rows.RemoveAt(frmtemlist.dgv_DSTV.SelectedRows[i].Index);
                    }
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn thành viên muốn xóa");
            }
        }

        public void addmember()
        {
            if(frmtemlist.cb_ThemTV.SelectedIndex >-1)
            {
                string sqlquery = "insert into ThanhVien_Nhom(IDNhom,IDThanhVien,NgayVaoNhom,ConHoatDong) values(" + idteam + "," + frmtemlist.cb_ThemTV.SelectedValue + ",getdate(),1)";
                if (dalteam.deleteMemberTeam(sqlquery) > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loadTVNhom(idteam);
                }
            }
        }
    }
}
