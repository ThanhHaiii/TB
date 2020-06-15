using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_MissionTeam
    {
        GUI.frm_MissionTeam frmmissionteam;
        DAL.DAL_MissionTeam dalmission = new DAL.DAL_MissionTeam();
        GUI.uc_Mission[] uc_missionTeam = new GUI.uc_Mission[30];
        Label closeMission;
        int demPCTeam = 0,demPCMem = 0;
        GUI.uc_Mission[] uc_missionMem = new GUI.uc_Mission[30];
        GUI.uc_team teams;
        string teamID;

        public BLL_MissionTeam(GUI.frm_MissionTeam guimission)
        {
            frmmissionteam = guimission;
            loadTeamList();
        }
        
        private void loadTeamList()
        {
            frmmissionteam.pn_TeamList.Controls.Clear();
            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien + ' - ' + MSSV) as HoTen,IDNhom, TenNhom from Nhom,ThanhVien where Nhom.NhomTruong = ThanhVien.IDThanhVien and NgungHD is null";
            DataTable dtlist = dalmission.getData(sqlquery);
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

                frmmissionteam.pn_TeamList.Controls.Add(teams);
            }
        }

        private void loadTinh()
        {
            try
            {
                string sqlQuery = "select IDTinh, (Kieu + ' ' + TenTinh) as tenTinh from Tinh";
                DataTable dt = dalmission.getData(sqlQuery);
                frmmissionteam.cbb_TenTinh.DataSource = dt.Copy();
                frmmissionteam.cbb_TenTinh.DisplayMember = "tenTinh";
                frmmissionteam.cbb_TenTinh.ValueMember = "IDTinh";

                frmmissionteam.cbb_TinhMem.DataSource = dt.Copy();
                frmmissionteam.cbb_TinhMem.DisplayMember = "tenTinh";
                frmmissionteam.cbb_TinhMem.ValueMember = "IDTinh";
            }
            catch { }
        }

        public void loadHuyen(string iDTinh)
        {
            try
            {
                string sqlQuery = "select IDHuyen, (Kieu + ' ' + TenHuyen) as tenHuyen from Huyen where IDTinh = " + iDTinh;
                DataTable dt = dalmission.getData(sqlQuery);
                frmmissionteam.cbb_TenHuyen.DataSource = dt.Copy();
                frmmissionteam.cbb_TenHuyen.DisplayMember = "tenHuyen";
                frmmissionteam.cbb_TenHuyen.ValueMember = "IDHuyen";
            }
            catch { }
        }

        public void loadXa(string iDHuyen)
        {
            try
            {
                string sqlQuery = "select IDXa, (Kieu + ' ' + TenXa) as tenXa from Xa where IDHuyen = " + iDHuyen;
                DataTable dt = dalmission.getData(sqlQuery);
                frmmissionteam.cbb_TenXa.DataSource = dt.Copy();
                frmmissionteam.cbb_TenXa.DisplayMember = "tenXa";
                frmmissionteam.cbb_TenXa.ValueMember = "IDXa";
            }
            catch { }
        }

        public void loadHuyenMem(string iDTinh)
        {
            try
            {
                string sqlQuery = "select IDHuyen, (Kieu + ' ' + TenHuyen) as tenHuyen from Huyen where IDTinh = " + iDTinh;
                DataTable dt = dalmission.getData(sqlQuery);
                frmmissionteam.cbb_HuyenMem.DataSource = dt.Copy();
                frmmissionteam.cbb_HuyenMem.DisplayMember = "tenHuyen";
                frmmissionteam.cbb_HuyenMem.ValueMember = "IDHuyen";
            }
            catch { }
        }

        public void loadXaMem(string iDHuyen)
        {
            try
            {
                string sqlQuery = "select IDXa, (Kieu + ' ' + TenXa) as tenXa from Xa where IDHuyen = " + iDHuyen;
                DataTable dt = dalmission.getData(sqlQuery);
                frmmissionteam.cbb_XaMem.DataSource = dt.Copy();
                frmmissionteam.cbb_XaMem.DisplayMember = "tenXa";
                frmmissionteam.cbb_XaMem.ValueMember = "IDXa";
            }
            catch { }
        }

        private void loadMission()
        {
            string sqlquery = "select * from NhiemVu";
            DataTable dt = dalmission.getData(sqlquery);
            frmmissionteam.cbb_NVTeam.DataSource = dt.Copy();
            frmmissionteam.cbb_NVTeam.DisplayMember = "TenNhiemVu";
            frmmissionteam.cbb_NVTeam.ValueMember = "IDNhiemVu";

            frmmissionteam.cbb_NVMem.DataSource = dt.Copy();
            frmmissionteam.cbb_NVMem.DisplayMember = "TenNhiemVu";
            frmmissionteam.cbb_NVMem.ValueMember = "IDNhiemVu";
        }

        private void loadTVNhom(string idNhom)
        {
            string sqlquery = "select ThanhVien.IDThanhVien,(HoThanhVien + ' ' + TenThanhVien + '-' + right(MSSV,4)) as HoTen from ThanhVien_Nhom,ThanhVien where ThanhVien.IDThanhVien = ThanhVien_Nhom.IDThanhVien and IDNhom = " + idNhom;
            DataTable dt = dalmission.getData(sqlquery);
            frmmissionteam.cbb_ThanhVien.DataSource = dt.Copy();
            frmmissionteam.cbb_ThanhVien.DisplayMember = "HoTen";
            frmmissionteam.cbb_ThanhVien.ValueMember = "IDThanhVien";
        }

        private string getTeamName(string id)
        {
            string sqlquery = "select TenNhom from Nhom where IDNhom = " + id;
            return dalmission.getName(sqlquery);
        }

        public void loadCTNhiemVu(string id)
        {
            string sqlquery = "select NoiDung from NhiemVu where IDNhiemVu = " + id;
            frmmissionteam.tb_NVTeam.Text = dalmission.getName(sqlquery);
        }

        public void loadCTNhiemVuMem(string id)
        {
            try
            {
                string sqlquery = "select NoiDung from NhiemVu where IDNhiemVu = " + id;
                frmmissionteam.tb_NVMem.Text = dalmission.getName(sqlquery);
            }
            catch { }
        }

        private void teamClick(object sender, EventArgs e)
        {
            string id = ((GUI.uc_team)sender).Tag.ToString();
            teamID = id;
            loadMission();
            loadTinh();
            loadTVNhom(id);
            frmmissionteam.lb_TeamName.Text = getTeamName(id);
        }

        public void saveMissionTeam()
        {
            string idMission;
            if (checkMission(frmmissionteam.cbb_NVTeam.Text))
            {
                idMission = frmmissionteam.cbb_NVTeam.SelectedValue.ToString();
            }
            else
            {
                idMission = addNewMission(frmmissionteam.cbb_NVTeam.Text, frmmissionteam.tb_NVTeam.Text);
            }

            if (checknullAddressTeam())
            {
                string idDiaChi = addNewAddress(frmmissionteam.cbb_TenXa.SelectedValue.ToString(), frmmissionteam.cbb_TenHuyen.SelectedValue.ToString(),
                frmmissionteam.cbb_TenTinh.SelectedValue.ToString(), frmmissionteam.tb_DiaChiCuThe.Text).ToString();
                DateTime daymiss = frmmissionteam.dtp_NgayHoanThanhTeam.Value;
                string deadline = string.Format("{0:u}", daymiss);
                if (saveMission(0, teamID, idMission , idDiaChi, deadline.Substring(0, deadline.Length - 1)))
                {
                    uc_missionTeam[demPCTeam] = new GUI.uc_Mission();
                    uc_missionTeam[demPCTeam].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    uc_missionTeam[demPCTeam].Dock = System.Windows.Forms.DockStyle.Top;
                    uc_missionTeam[demPCTeam].Location = new System.Drawing.Point(0, 0);
                    uc_missionTeam[demPCTeam].Tag = demPCTeam;
                    uc_missionTeam[demPCTeam].Size = new System.Drawing.Size(frmmissionteam.pn_NhiemVu.Size.Width, 90);
                    uc_missionTeam[demPCTeam].lb_MissionName.Text = frmmissionteam.cbb_NVTeam.Text;
                    uc_missionTeam[demPCTeam].lb_Deadline.Text = "Deadline: " + frmmissionteam.dtp_NgayHoanThanhTeam.Value;

                    closeMission = new Label();
                    closeMission.Cursor = System.Windows.Forms.Cursors.Hand;
                    closeMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    closeMission.Image = global::CDIO_QLCLB.Properties.Resources.close;
                    closeMission.Location = new System.Drawing.Point(uc_missionTeam[demPCTeam].Size.Width -30, 7);
                    closeMission.Name = "lb_Close";
                    closeMission.Size = new System.Drawing.Size(20, 20);
                    closeMission.Tag = demPCTeam + "-" + idMission + "-" + idDiaChi;
                    closeMission.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    closeMission.Click += new EventHandler(lb_CloseClick);

                    uc_missionTeam[demPCTeam].Controls.Add(closeMission);
                    frmmissionteam.pn_NhiemVu.Controls.Add(uc_missionTeam[demPCTeam]);
                    demPCTeam++;
                }
            }
        }

        private void lb_CloseClick(object sender, EventArgs e)
        {
            string[] ma = ((Label)sender).Tag.ToString().Split('-');
            frmmissionteam.pn_NhiemVu.Controls.Remove(uc_missionTeam[int.Parse(ma[0])]);
            string sqlquery = "delete PhanCongNhom where IDPhanCong = " + ma[1];
            dalmission.addMission(sqlquery);
            sqlquery = "delete DiaChi where IDDiaChi = " + ma[2];
            dalmission.addMission(sqlquery);
            loadMission();
        }

        private int addNewAddress(string idXa,string idHuyen,string idTinh, string diaChiCuThe)
        {
            string sqlquery = "insert into DiaChi(IDTinh,IDHuyen,IDXa,DiaChiCuThe) values(" + idTinh + "," + idHuyen + "," + idXa + ",N'" + diaChiCuThe + "')";
            dalmission.addMission(sqlquery);
            sqlquery = "select max(IDDiaChi) from DiaChi";
            return int.Parse(dalmission.getName(sqlquery));
        }

        private bool checknullAddressTeam()
        {
            if (frmmissionteam.cbb_TenTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tỉnh!");
                return false;
            }

            if (frmmissionteam.cbb_TenHuyen.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn huyện!");
                return false;
            }

            if (frmmissionteam.cbb_TenXa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn xã!");
                return false;
            }

            if (frmmissionteam.tb_DiaChiCuThe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ cụ thể!");
                return false;
            }

            return true;
        }

        private bool saveMission(int type,string id,string idMission,string idAddress,string deadline)
        {
            if (type == 0)
            {
                string sqlquery = "insert into PhanCongNhom(IDNhom,IDNhiemVu,HanHoanThanh,NgayPhanCong,NguoiPhanCong,DiaChi) values(" + id + "," + idMission + ",'" + deadline.Substring(0,deadline.Length - 1)
                    + "',getdate()," + caseData.DataTam.DuLieu.ID + "," + idAddress + ")";
                if (dalmission.addMission(sqlquery) > 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                string sqlquery = "insert into PhanCongTV(IDThanhVien,IDNhiemVu,HanHoanThanh,NgayPhanCong,NguoiPhanCong,DiaChi) values(" + id + "," + idMission + ",'" + deadline
                    + "',getdate()," + caseData.DataTam.DuLieu.ID + "," + idAddress + ")";
                if (dalmission.addMission(sqlquery) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        private bool checkMission(string missionName)
        {
            string sqlquery = "select * from NhiemVu where TenNhiemVu like N'" + missionName + "'";
            if (dalmission.getData(sqlquery).Rows.Count < 1)
            {
                return false;
            }
            return true;
        }

        private string addNewMission(string missionName, string content)
        {
            string sqlquery = "insert into NhiemVu(TenNhiemVu,NoiDung,NgayTao,NguoiTao) values(N'" + missionName + "',N'" + content + "',getdate()," + caseData.DataTam.DuLieu.ID + ")";
            dalmission.addMission(sqlquery);
            sqlquery = "select MAX(IDNhiemVu) as IDNhiemVu from NhiemVu";
            return dalmission.getName(sqlquery);
        }

        private bool checkNullMember()
        {
            if(int.Parse(frmmissionteam.cbb_ThanhVien.SelectedValue.ToString()) < 0)
            {
                MessageBox.Show("Hãy chọn thành viên");
                return true;
            }

            if(int.Parse(frmmissionteam.cbb_XaMem.SelectedValue.ToString()) < 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return true;
            }

            if(frmmissionteam.tb_DCCuTheMem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ cụ thể");
                return true;
            }

            return false;

        }

        public void savaMissMember()
        {
            string idNhiemvu;
            if (!checkNullMember())
            {
                if (checkMission(frmmissionteam.cbb_NVMem.Text))
                {
                    idNhiemvu = frmmissionteam.cbb_NVMem.SelectedValue.ToString();
                }
                else
                {
                    idNhiemvu = addNewMission(frmmissionteam.cbb_NVMem.Text, frmmissionteam.tb_NVMem.Text);
                }

                int idDiaChi = addNewAddress(frmmissionteam.cbb_XaMem.SelectedValue.ToString(), frmmissionteam.cbb_HuyenMem.SelectedValue.ToString(), frmmissionteam.cbb_TinhMem.SelectedValue.ToString()
                    , frmmissionteam.tb_DCCuTheMem.Text);
                string idThanhVien = frmmissionteam.cbb_ThanhVien.SelectedValue.ToString();
                DateTime dateTime = frmmissionteam.dtp_HanHTMem.Value;
                string hanHoanThanh = String.Format("{0:u}", dateTime);
                hanHoanThanh = hanHoanThanh.Substring(0, hanHoanThanh.Length - 1);
                if (saveMission(1, idThanhVien, idNhiemvu, idDiaChi.ToString(), hanHoanThanh))
                {
                    uc_missionMem[demPCMem] = new GUI.uc_Mission();
                    uc_missionMem[demPCMem].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    uc_missionMem[demPCMem].Dock = System.Windows.Forms.DockStyle.Top;
                    uc_missionMem[demPCMem].Location = new System.Drawing.Point(0, 0);
                    uc_missionMem[demPCMem].Tag = demPCTeam;
                    uc_missionMem[demPCMem].Size = new System.Drawing.Size(frmmissionteam.pn_NVMember.Size.Width, 90);
                    uc_missionMem[demPCMem].lb_MissionName.Text = frmmissionteam.cbb_NVMem.Text;
                    uc_missionMem[demPCMem].lb_Deadline.Text = "Deadline: " + frmmissionteam.dtp_HanHTMem.Value;

                    closeMission = new Label();
                    closeMission.Cursor = System.Windows.Forms.Cursors.Hand;
                    closeMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    closeMission.Image = global::CDIO_QLCLB.Properties.Resources.close;
                    closeMission.Location = new System.Drawing.Point(uc_missionMem[demPCMem].Size.Width - 30, 7);
                    closeMission.Name = "lb_Close";
                    closeMission.Size = new System.Drawing.Size(20, 20);
                    closeMission.Tag = demPCTeam + "-" + idNhiemvu + "-" + idDiaChi;
                    closeMission.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    closeMission.Click += new EventHandler(lb_CloseClickMem);

                    uc_missionMem[demPCMem].Controls.Add(closeMission);
                    frmmissionteam.pn_NVMember.Controls.Add(uc_missionMem[demPCMem]);
                    demPCMem++;
                }
            }

        }

        private void lb_CloseClickMem(object sender, EventArgs e)
        {
            string[] ma = ((Label)sender).Tag.ToString().Split('-');
            frmmissionteam.pn_NVMember.Controls.Remove(uc_missionMem[int.Parse(ma[0])]);
            string sqlquery = "delete PhanCongTV where IDPhanCong = " + ma[1];
            dalmission.addMission(sqlquery);
            sqlquery = "delete DiaChi where IDDiaChi = " + ma[2];
            dalmission.addMission(sqlquery);
            loadMission();
        }
    }
}
