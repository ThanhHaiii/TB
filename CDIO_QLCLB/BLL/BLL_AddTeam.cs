using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_AddTeam
    {
        DAL.DAL_AddTeam daladdteam = new DAL.DAL_AddTeam();
        GUI.frm_AddTeam frmaddteam;
        bool create = false;
        string idTeam;

        public BLL_AddTeam(GUI.frm_AddTeam addteamform)
        {
            frmaddteam = addteamform;
            loadLeader();
        }

        private void loadLeader()
        {
            string sqlQuery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' + MSSV) as HoTen, IDThanhVien from ThanhVien where IDThanhVien not in (select NhomTruong from Nhom)";
            DataTable dt = daladdteam.loadData(sqlQuery);
            frmaddteam.cbb_AddNhomTruong.DataSource = dt.Copy();
            frmaddteam.cbb_AddNhomTruong.DisplayMember = "HoTen";
            frmaddteam.cbb_AddNhomTruong.ValueMember = "IDThanhVien";
            frmaddteam.cbb_AddListMember.DataSource = dt.Copy();
            frmaddteam.cbb_AddListMember.DisplayMember = "HoTen";
            frmaddteam.cbb_AddListMember.ValueMember = "IDThanhVien";
        }

        private bool checkNull()
        {
            if (frmaddteam.tb_AddTenNhom.Text == "")
            {
                MessageBox.Show("Tên nhóm không được để trống");
                frmaddteam.tb_AddTenNhom.Focus();
                return false;
            }
            if(frmaddteam.cbb_AddNhomTruong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhóm trưởng");
                return false;
            }
            return true;
        }

        public void createTeam()
        {
            string sqlquery;
            if (checkNull())
            {
                idTeam = daladdteam.addTeam(frmaddteam.tb_AddTenNhom.Text, frmaddteam.cbb_AddNhomTruong.SelectedValue.ToString());
            }

            if (frmaddteam.dtg_AddThanhVien.Rows.Count > 0)
            {
                for(int i = 0;i < frmaddteam.dtg_AddThanhVien.Rows.Count; i++)
                {
                    try
                    {
                        sqlquery = "insert into ThanhVien_Nhom(IDNhom,IDThanhVien,NgayVaoNhom) values(" + idTeam + ","
                        + frmaddteam.dtg_AddThanhVien.Rows[i].Cells[0].Value.ToString() + ",getdate())";
                        daladdteam.addData(sqlquery);
                    }
                    catch
                    {

                    }
                }
            }
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(frmaddteam.MdiParent as frm_MainForm);
            bllmain.loadTeamList();
            create = true;
        }

        public void xoaThanhVien()
        {
            if (frmaddteam.dtg_AddThanhVien.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa những thành viên đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < frmaddteam.dtg_AddThanhVien.SelectedRows.Count; i++)
                    {
                        string idThanhVien = frmaddteam.dtg_AddThanhVien.SelectedRows[i].Cells[0].Value.ToString();
                        string sqlquery = "update ThanhVien_Nhom set NgungHD = getdate where IDThanhVien = " + idThanhVien + " and IDNhom = " + idTeam;
                        daladdteam.addData(sqlquery);
                        frmaddteam.dtg_AddThanhVien.Rows.RemoveAt(frmaddteam.dtg_AddThanhVien.SelectedRows[i].Index);
                    }
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn thành viên muốn xóa");
            }
        }

        public void addMember()
        {
            if (create)
            {
                if (frmaddteam.cbb_AddListMember.SelectedIndex > -1)
                {
                    string sqlquery = "insert into ThanhVien_Nhom(IDNhom,IDThanhVien,NgayVaoNhom) values(" + idTeam + "," + frmaddteam.cbb_AddListMember.SelectedValue + ",getdate())";
                    if (daladdteam.addData(sqlquery) > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loadTVNhom(idTeam);
                        loadcbbThanhVien(idTeam);
                    }
                }
            }
            else
            {
                string sqlquery = "select HoThanhVien,TenThanhVien, MSSV,IDThanhVien, iif(GioiTinh = 1, N'Nam',N'Nữ') as gioitinh from ThanhVien where IDThanhVien = " + frmaddteam.cbb_AddListMember.SelectedValue;
                DataTable dt = daladdteam.loadData(sqlquery);
                DataGridViewRow row = (DataGridViewRow)frmaddteam.dtg_AddThanhVien.Rows[0].Clone();
                row.Cells[0].Value = dt.Rows[0]["IDThanhVien"].ToString();
                row.Cells[1].Value = dt.Rows[0]["HoThanhVien"].ToString();
                row.Cells[2].Value = dt.Rows[0]["TenThanhVien"].ToString();
                row.Cells[3].Value = dt.Rows[0]["MSSV"].ToString();
                row.Cells[4].Value = dt.Rows[0]["gioitinh"].ToString();
                frmaddteam.dtg_AddThanhVien.Rows.Add(row);
            }
        }

        private void loadcbbThanhVien(string idNhom)
        {//Không hợp lý ở chỗ không load lên được những thành viên đã từng rời nhóm trước đây cần sửa lại
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' +  MSSV) as HoTen, IDThanhVien from ThanhVien, ChucVu where RoiCLB is null and ThanhVien.IDChucVu = ChucVu.IDChucVu and IDThanhVien not in (select NhomTruong from Nhom)";
            DataTable dtThanhVien = daladdteam.loadData(sqlquery);
            frmaddteam.cbb_AddListMember.DataSource = dtThanhVien.Copy();
            frmaddteam.cbb_AddListMember.DisplayMember = "HoTen";
            frmaddteam.cbb_AddListMember.ValueMember = "IDThanhVien";
        }

        private void loadTVNhom(string idNhom)
        {
            string sqlquery = "select ThanhVien.IDThanhVien,HoThanhVien,TenThanhVien,MSSV,TenNhiemVu,iif(DiemNhiemVu is NULL,N'Chưa hoàn thành nhiệm vụ', N'Đã hoàn thành nhiệm vụ') as HoanThanhNV from ThanhVien_Nhom inner join ThanhVien on ThanhVien.IDThanhVien = ThanhVien_Nhom.IDThanhVien and ThanhVien_Nhom.NgungHD is null and ThanhVien_Nhom.IDNhom = " + idTeam + " left join PhanCongTV on ThanhVien_Nhom.IDThanhVien = PhanCongTV.IDThanhVien left join NhiemVu on NhiemVu.IDNhiemVu = PhanCongTV.IDNhiemVu";
            DataTable dtTV = daladdteam.loadData(sqlquery);
            frmaddteam.dtg_AddThanhVien.DataSource = dtTV;
        }
    }
}
