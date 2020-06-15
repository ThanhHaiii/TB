using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_TeamManager
    {
        DAL.DAL_TeamList dalteam = new DAL.DAL_TeamList();
        GUI.frm_TeamManager frmtemlist;
        string linkfb, idteam;

        GUI.uc_team teams;
        GUI.uc_NhiemVuTeam nhiemVu;
        public BLL_TeamManager(GUI.frm_TeamManager teamfrm)
        {
            frmtemlist = teamfrm;
            loadTeamList();
        }

        private void loadTeamList()
        {
            frmtemlist.pn_TeamList.Controls.Clear();
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien) as HoTen,IDNhom, TenNhom from Nhom,ThanhVien where NgungHD is null and Nhom.NhomTruong = ThanhVien.IDThanhVien";
            DataTable dtlist = dalteam.getDatabase(sqlquery);
            for(int i = 0; i < dtlist.Rows.Count; i++)
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

                frmtemlist.pn_TeamList.Controls.Add(teams);
            }
            frmtemlist.pn_InfoTeam.Hide();
            frmtemlist.lb_TeamName.Hide();
        }

        private void loadTeamInfo(string idTeam)
        {
            frmtemlist.pn_InfoTeam.Show();
            frmtemlist.lb_TeamName.Show();
            string sqlLeader = "select (HoThanhVien + ' ' +TenThanhVien) as HoTen,SDT,LinkFB,NgayLapNhom,TenNhom from Nhom,ThanhVien where ThanhVien.IDThanhVien = Nhom.NhomTruong and NgungHD is null and IDNhom = " + idTeam;
            string sqlsoTV = "select COUNT(IDThanhVien) as SLTV from ThanhVien_Nhom where NgungHD is null and IDNhom = " + idTeam;
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
            string sqlQuery = "select Nhom.IDNhom IDPhanCong,TenNhiemVu,(HoThanhVien + ' ' + TenThanhVien) as HoTen, NgayPhanCong,HanHoanThanh,DiaChiCuThe,TenXa,TenHuyen,TenTinh from Nhom left join PhanCongNhom on Nhom.IDNhom = PhanCongNhom.IDNhom left join ThanhVien on PhanCongNhom.NguoiPhanCong = ThanhVien.IDThanhVien left join NhiemVu on PhanCongNhom.IDNhiemVu = NhiemVu.IDNhiemVu left join DiaChi on PhanCongNhom.DiaChi = DiaChi.IDDiaChi left join Tinh on DiaChi.IDTinh = Tinh.IDTinh left join Huyen on Huyen.IDHuyen = DiaChi.IDHuyen left join Xa on Xa.IDXa = DiaChi.IDXa where Nhom.IDNhom = " + idNhom;
            DataTable dtNV = dalteam.getDatabase(sqlQuery);
            frmtemlist.pn_NhiemVu.Controls.Clear();
            for (int i = 0; i < dtNV.Rows.Count; i++)
            {
                try
                {
                    nhiemVu = new GUI.uc_NhiemVuTeam();
                    nhiemVu.BackColor = System.Drawing.Color.WhiteSmoke;
                    nhiemVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    nhiemVu.Dock = System.Windows.Forms.DockStyle.Top;
                    nhiemVu.Location = new System.Drawing.Point(0, 0);
                    nhiemVu.Name = "uc_NhiemVuTeam" + i;
                    nhiemVu.lb_NguoiRaNV.Text = "Người ra nhiệm vụ: " + dtNV.Rows[i]["HoTen"].ToString();
                    nhiemVu.lb_TenNV.Text = dtNV.Rows[i]["TenNhiemVu"].ToString();
                    nhiemVu.lb_location.Text = "Địa chỉ thực hiện: " + dtNV.Rows[i]["DiaChiCuThe"].ToString() + " - " + dtNV.Rows[i]["TenXa"].ToString() + " - " +
                        dtNV.Rows[i]["TenHuyen"].ToString() + " - " + dtNV.Rows[i]["TenTinh"].ToString();
                    DateTime datestart = DateTime.Parse(dtNV.Rows[i]["NgayPhanCong"].ToString());
                    nhiemVu.lb_TimeStart.Text = "Ngày ra nhiệm vụ: " + string.Format("{0:dd/MM/yyyy}", datestart);
                    DateTime dateend = DateTime.Parse(dtNV.Rows[i]["HanHoanThanh"].ToString());
                    nhiemVu.lb_TimeEnd.Text = "Hạn hoàn thành: " + string.Format("{0:dd/MM/yyyy}", dateend);
                    nhiemVu.Cursor = System.Windows.Forms.Cursors.Hand;
                    nhiemVu.TabIndex = 0;

                    frmtemlist.pn_NhiemVu.Controls.Add(nhiemVu);
                }
                catch {
                    
                }
            }
        }

        private void loadTVNhom(string idNhom)
        {
            string sqlquery = "select ThanhVien.IDThanhVien,HoThanhVien,TenThanhVien,MSSV,TenNhiemVu,iif(DiemNhiemVu is NULL,N'Chưa hoàn thành nhiệm vụ', N'Đã hoàn thành nhiệm vụ') as HoanThanhNV from ThanhVien_Nhom inner join ThanhVien on ThanhVien.IDThanhVien = ThanhVien_Nhom.IDThanhVien and ThanhVien_Nhom.NgungHD is null and ThanhVien_Nhom.IDNhom = " + idNhom + " left join PhanCongTV on ThanhVien_Nhom.IDThanhVien = PhanCongTV.IDThanhVien left join NhiemVu on NhiemVu.IDNhiemVu = PhanCongTV.IDNhiemVu";
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
    }
}
