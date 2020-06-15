using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_MemberInfo
    {
        GUI.frm_MemberInfo frmMemberInfor;
        DAL.DAL_MemberInfo dalmember = new DAL.DAL_MemberInfo();
        objInProject.MemberList memberlist = new objInProject.MemberList();

        public BLL_MemberInfo(GUI.frm_MemberInfo signForm)
        {
            frmMemberInfor = signForm;
        }

        public void loadInfo()
        {
            string sqlMember = "select IDThanhVien,HoThanhVien + ' ' + TenThanhVien as HoTen, GioiTinh, NgaySinh,DiaChiCuThe,TenXa,TenHuyen,TenTinh,SDT,MSSV,Khoa,Lop,LinkFB,AnhDaiDien,TenChucVu from ChucVu,ThanhVien, DiaChi,Tinh,Huyen,Xa where ThanhVien.IDDiaChi = DiaChi.IDDiaChi and DiaChi.IDXa = Xa.IDXa and Xa.IDHuyen = Huyen.IDHuyen and Huyen.IDTinh = Tinh.IDTinh and ThanhVien.IDChucVu =  ChucVu.IDChucVu and MSSV =  '" + caseData.DataTam.DuLieu.idTemp + "';";
            DataTable dtInfo = dalmember.getTable(sqlMember);
            XuLyChuoi.checkLink checklink = new XuLyChuoi.checkLink();
            if (dtInfo.Rows.Count < 1)
            {
                caseData.txtRead txtread = new caseData.txtRead();
                logical.GgSheetAPI ggsheet = new logical.GgSheetAPI();
                string[] idTable = txtread.readfile(0);
                IList<IList<Object>> values = ggsheet.docfile(idTable[1], idTable[2]);
                int id = int.Parse(caseData.DataTam.DuLieu.idTemp);
                string sqlBirthDay = "SELECT * FROM [ThanhVien],[ChucVu] where ThanhVien.IDChucVu = ChucVu.IDChucVu and MSSV = '" + values[id][1].ToString() + "';";
                DataTable dt = dalmember.getTable(sqlBirthDay);
                List<XuLyChuoi.checkLink> link = checklink.DetectLink(values[id][10].ToString());
                frmMemberInfor.lb_HoTen.Text = (values[id][2].ToString() + " " + values[id][3].ToString()).ToUpper();
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["RoiCLB"].ToString() == "")
                    {
                        frmMemberInfor.lb_HoTen.Text += " - ĐÃ LÀ THÀNH VIÊN!";
                    }
                    else
                    {
                        frmMemberInfor.lb_HoTen.Text += " - ĐÃ RỜI CLB NGÀY: " + dt.Rows[0]["RoiCLB"].ToString();
                    }
                    try
                    {
                        XuLyAnh.MaHoaHinhAnh mhAnh = new XuLyAnh.MaHoaHinhAnh();
                        frmMemberInfor.pic_Avartar.Image = mhAnh.ChuoiSangAnh(dt.Rows[0]["AnhDaiDien"].ToString());
                    }
                    catch { }
                    frmMemberInfor.lb_HoTen.ForeColor = System.Drawing.Color.Red;
                    frmMemberInfor.tb_ChucVu.Text = dt.Rows[0]["TenChucVu"].ToString();
                }
                else
                {
                    frmMemberInfor.tb_ChucVu.Text = "Chưa xét duyệt";
                }
                frmMemberInfor.tb_mssv.Text = values[id][1].ToString();
                frmMemberInfor.tb_Sdt.Text = values[id][4].ToString();
                frmMemberInfor.tb_Khoa.Text = values[id][8].ToString();
                frmMemberInfor.tb_Lop.Text = values[id][9].ToString();
                frmMemberInfor.tb_DiaChi.Text = values[id][7].ToString();
                frmMemberInfor.dtp_NgaySinh.Text = values[id][6].ToString();
                frmMemberInfor.tb_Sdt.Text = values[id][4].ToString();
                if (link.Count > 0)
                {
                    frmMemberInfor.link_Facebook.Text = "Mở Facebook";
                    frmMemberInfor.link_Facebook.Links.Add(0, link[0].getContent().Length, link[0].getContent());
                    frmMemberInfor.link_Facebook.LinkClicked += new LinkLabelLinkClickedEventHandler(linkClick);
                }
                else
                {
                    frmMemberInfor.link_Facebook.Text = values[id][10].ToString();
                    frmMemberInfor.link_Facebook.Links.Add(0, 0);
                }
                if (values[id][5].ToString() == "Nam")
                {
                    frmMemberInfor.ra_Nam.Checked = true;
                }
                else
                {
                    frmMemberInfor.ra_nu.Checked = true;
                }
            }
            else
            {
                frmMemberInfor.lb_HoTen.Text = dtInfo.Rows[0]["HoTen"].ToString();
                frmMemberInfor.tb_mssv.Text = dtInfo.Rows[0]["MSSV"].ToString();
                frmMemberInfor.tb_Sdt.Text = dtInfo.Rows[0]["SDT"].ToString();
                frmMemberInfor.tb_Khoa.Text = dtInfo.Rows[0]["Khoa"].ToString();
                frmMemberInfor.tb_Lop.Text = dtInfo.Rows[0]["Lop"].ToString();
                frmMemberInfor.tb_DiaChi.Text = dtInfo.Rows[0]["DiaChiCuThe"].ToString() + " - " + dtInfo.Rows[0]["TenXa"].ToString() + " - " + dtInfo.Rows[0]["TenHuyen"].ToString() + " - " + dtInfo.Rows[0]["TenTinh"].ToString();
                DateTime ngay = Convert.ToDateTime(dtInfo.Rows[0]["NgaySinh"].ToString());
                frmMemberInfor.dtp_NgaySinh.Text = ngay.ToString("dd/MM/yyyy");
                frmMemberInfor.tb_Sdt.Text = dtInfo.Rows[0]["SDT"].ToString();
                frmMemberInfor.tb_ChucVu.Text = dtInfo.Rows[0]["TenChucVu"].ToString();
                List<XuLyChuoi.checkLink> link = checklink.DetectLink(dtInfo.Rows[0]["LinkFB"].ToString());
                if (link.Count > 0)
                {
                    frmMemberInfor.link_Facebook.Text = "Mở Facebook";
                    frmMemberInfor.link_Facebook.Links.Add(0, link[0].getContent().Length, link[0].getContent());
                    frmMemberInfor.link_Facebook.LinkClicked += new LinkLabelLinkClickedEventHandler(linkClick);
                }
                else
                {
                    frmMemberInfor.link_Facebook.Text = dtInfo.Rows[0]["LinkFB"].ToString();
                    frmMemberInfor.link_Facebook.Links.Add(0, 0);
                }
                if (Convert.ToBoolean(dtInfo.Rows[0]["GioiTinh"]))
                {
                    frmMemberInfor.ra_Nam.Checked = true;
                }
                else
                {
                    frmMemberInfor.ra_nu.Checked = true;
                }
                try
                {
                    XuLyAnh.MaHoaHinhAnh mhAnh = new XuLyAnh.MaHoaHinhAnh();
                    frmMemberInfor.pic_Avartar.Image = mhAnh.ChuoiSangAnh(dtInfo.Rows[0]["AnhDaiDien"].ToString());
                }
                catch { }
            }
        }

        public void pheDuyet()
        {
            caseData.txtRead txtread = new caseData.txtRead();
            logical.GgSheetAPI ggsheet = new logical.GgSheetAPI();
            string[] idTable = txtread.readfile(0);
            IList<IList<Object>> values = ggsheet.docfile(idTable[1], idTable[2]);
            int id = int.Parse(caseData.DataTam.DuLieu.idTemp);
            string sqlquery = "SELECT * FROM [ThanhVien],[ChucVu] where ThanhVien.IDChucVu = ChucVu.IDChucVu and MSSV = '" + values[id][1].ToString() + "';";
            DataTable dt = dalmember.getTable(sqlquery);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["RoiCLB"].ToString() == "")
                {
                    MessageBox.Show("Người này đang là thành viên của CLB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    deleteMember();
                }
                else
                {
                    DateTime ngay = Convert.ToDateTime(dt.Rows[0]["RoiCLB"].ToString());
                    if (MessageBox.Show("Thành viên này đã rời CLB ngày: " + string.Format("dd/MM/yyyy") + " bạn có muốn duyệt lại thành viên này?",
                        "Xác nhận phê duyệt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sqlUpdate = "update ThanhVien set RoiCLB = null,IDChucVu = 8 where MSSV = " + frmMemberInfor.tb_mssv.Text;
                        if (dalmember.updateTable(sqlUpdate) > 0)
                        {
                            frmMemberInfor.lb_PheDuyet.Show();
                            frmMemberInfor.lb_PheDuyet.BackColor = Color.FromArgb(120, Color.Black);
                            Thread.Sleep(2000);
                            frmMemberInfor.lb_PheDuyet.Hide();
                            logical.APIeSMS eSMS = new logical.APIeSMS();
                            XuLyChuoi.checkKyTu chkstr = new XuLyChuoi.checkKyTu();
                            string message = "Chúc mừng bạn <HoTen>, MSSV: <MSSV> đã chính thức trở thành CTV của CLB Tình nguyện Sinh viên Duy Tân. Mời bạn truy cập link: https://www.facebook.com/groups/CLBTinhNguyenSinhVienDuyTan để vào group của CLB nhằm theo dõi các thông báo mới nhất. CLB Tình nguyện Sinh viên Duy Tân xin cám ơn bạn vì đã tham gia cùng chúng tôi";
                            eSMS.SendSMS(frmMemberInfor.tb_Sdt.Text, chkstr.DetectChar(message, dt.Rows[0]["IDThanhVien"].ToString()));
                            sqlquery = "select IDThanhVien from ThanhVien where MSSV = " + frmMemberInfor.tb_mssv.Text;
                            caseData.DataTam.DuLieu.client.Send(Serialize("volunteeraddmember:" + dalmember.layID(sqlquery)));
                        }
                    }
                }
            }
            else
            {
                string idDiaChi = addAddress(frmMemberInfor.tb_DiaChi.Text);
                DateTime ngay = frmMemberInfor.dtp_NgaySinh.Value;
                string ngaySinh = string.Format("{0:u}" ,ngay).Substring(0,10);
                string gioitinh;
                if(values[int.Parse(caseData.DataTam.DuLieu.idTemp)][5].ToString() == "Nam")
                {
                    gioitinh = "true";
                }
                else
                {
                    gioitinh = "false";
                }
                string sqlQuery = "insert into ThanhVien(HoThanhVien,TenThanhVien,GioiTinh,NgaySinh,IDDiaChi,SDT,MSSV,Khoa,Lop,LinkFB,IDChucVu,NgayGiaNhap) values(N'" +
                    values[int.Parse(caseData.DataTam.DuLieu.idTemp)][2] + "',N'" + values[int.Parse(caseData.DataTam.DuLieu.idTemp)][3] + "', '" + gioitinh + "','" +
                    ngaySinh + "'," + idDiaChi + ",'" + frmMemberInfor.tb_Sdt.Text + "','" + frmMemberInfor.tb_mssv.Text + "',N'" + frmMemberInfor.tb_Khoa.Text + "',N'" +
                    frmMemberInfor.tb_Lop.Text + "',N'" + values[int.Parse(caseData.DataTam.DuLieu.idTemp)][10] + "',8,getdate())";
                if (dalmember.updateTable(sqlQuery) > 0)
                {
                    sqlQuery = "select max(IDThanhVien) from ThanhVien";
                    string idThanhVien = dalmember.layID(sqlQuery);
                    sqlQuery = "insert into DuyetThanhVien(IDThanhVien,NgayDuyet,NguoiDuyet) values(" + idThanhVien + ",getdate()," + caseData.DataTam.DuLieu.ID + ")";
                    dalmember.updateTable(sqlQuery);
                    frmMemberInfor.lb_PheDuyet.Show();
                    frmMemberInfor.lb_PheDuyet.BackColor = Color.FromArgb(120, Color.Black);
                    string message = "Chúc mừng bạn <HoTen>, MSSV: <MSSV> đã chính thức trở thành CTV của CLB Tình nguyện Sinh viên Duy Tân. Mời bạn truy cập link: https://www.facebook.com/groups/CLBTinhNguyenSinhVienDuyTan để vào group của CLB nhằm theo dõi các thông báo mới nhất. CLB Tình nguyện Sinh viên Duy Tân xin cám ơn bạn vì đã tham gia cùng chúng tôi";
                    
                    logical.APIeSMS eSMS = new logical.APIeSMS();
                    XuLyChuoi.checkKyTu chkstr = new XuLyChuoi.checkKyTu();
                    eSMS.SendSMS(frmMemberInfor.tb_Sdt.Text, chkstr.DetectChar(message, values[id][1].ToString()));
                    Thread.Sleep(3000);
                    deleteMember();
                    frmMemberInfor.lb_PheDuyet.Hide();
                    caseData.DataTam.DuLieu.client.Send(Serialize("volunteeraddmember:" + idThanhVien));
                    memberlist.addNewMember(idThanhVien, caseData.DataTam.DuLieu.mbList);
                }
            }
        }

        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        private string addAddress(string input)
        {
            string[] tach1 = input.Split('-');
            string[] tach2 = input.Split('/');
            string[] tach3 = input.Split(',');
            string iDXa, iDHuyen, iDTinh;

            DataTable dt;
            string sqlquery, kq;
            if (tach1.Length < 4)
            {
                if (tach1.Length > 2)
                {
                    sqlquery = "select IDXa from Xa,Huyen where TenXa = N'" + tach1[0].Trim() + "' and TenHuyen = N'" + tach1[1].Trim() + "' and Xa.IDHuyen = Huyen.IDHuyen;";
                    kq = dalmember.layID(sqlquery);
                    if (kq != null)
                    {
                        iDXa = kq;
                        sqlquery = "select Huyen.IDHuyen,Huyen.IDTinh from Huyen,Xa,Tinh where Huyen.IDHuyen = Xa.IDHuyen and Huyen.IDTinh = Tinh.IDTinh and IDXa = " + iDXa;
                        dt = dalmember.getTable(sqlquery);
                        iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                        iDTinh = dt.Rows[0]["IDTinh"].ToString();
                        sqlquery = "insert into DiaChi(IDTinh,IDHuyen,IDXa) values(" + iDTinh + "," + iDHuyen + "," + iDXa + ")";
                        dalmember.updateTable(sqlquery).ToString();
                        sqlquery = "select Max(IDDiaChi) from DiaChi";
                        return dalmember.layID(sqlquery).ToString();
                    }
                }
                else
                {
                    sqlquery = "select IDHuyen from Huyen where TenHuyen like N'" + tach1[0].Trim() + "'";
                    kq = dalmember.layID(sqlquery);
                    if (kq != null)
                    {
                        iDHuyen = kq;
                        sqlquery = "select * from Huyen where IDHuyen = " + iDHuyen;
                        dt = dalmember.getTable(sqlquery);
                        iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                        iDTinh = dt.Rows[0]["IDTinh"].ToString();
                        sqlquery = "insert into DiaChi(IDTinh,IDHuyen) values(" + iDTinh + "," + iDHuyen + ")";
                        dalmember.updateTable(sqlquery).ToString();
                        sqlquery = "select Max(IDDiaChi) from DiaChi";
                        return dalmember.layID(sqlquery).ToString();
                    }
                    else
                    {
                        sqlquery = "select IDTinh from Tinh where TenTinh like N'" + tach1[0].Trim() + "'";
                        kq = dalmember.layID(sqlquery);
                        if (kq != null)
                        {
                            sqlquery = "insert into DiaChi(IDTinh) values(" + kq + ")";
                            dalmember.updateTable(sqlquery).ToString();
                            sqlquery = "select Max(IDDiaChi) from DiaChi";
                            return dalmember.layID(sqlquery).ToString();
                        }
                    }
                }
            }
            sqlquery = "select IDXa from Xa,Huyen where TenXa = N'" + tach1[1].Trim() + "' and TenHuyen = N'" + tach1[2].Trim() + "' and Xa.IDHuyen = Huyen.IDHuyen;";
            kq = dalmember.layID(sqlquery);
            if (kq != null)
            {
                iDXa = kq;
                sqlquery = "select Huyen.IDHuyen,Huyen.IDTinh from Huyen,Xa,Tinh where Huyen.IDHuyen = Xa.IDHuyen and Huyen.IDTinh = Tinh.IDTinh and IDXa = " + iDXa;
                dt = dalmember.getTable(sqlquery);
                iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                iDTinh = dt.Rows[0]["IDTinh"].ToString();
                sqlquery = "insert into DiaChi(IDTinh,IDHuyen,IDXa,DiaChiCuThe) values(" + iDTinh + "," + iDHuyen + "," + iDXa + ",N'"+tach1[0]+"')";
                dalmember.updateTable(sqlquery).ToString();
                sqlquery = "select Max(IDDiaChi) from DiaChi";
                return dalmember.layID(sqlquery).ToString();
            }

            if (tach2.Length < 4)
            {
                if (tach2.Length > 2)
                {
                    sqlquery = "select IDXa from Xa,Huyen where TenXa = N'" + tach2[0].Trim() + "' and TenHuyen = N'" + tach2[1].Trim() + "' and Xa.IDHuyen = Huyen.IDHuyen;";
                    kq = dalmember.layID(sqlquery);
                    if (kq != null)
                    {
                        iDXa = kq;
                        sqlquery = "select Huyen.IDHuyen,Huyen.IDTinh from Huyen,Xa,Tinh where Huyen.IDHuyen = Xa.IDHuyen and Huyen.IDTinh = Tinh.IDTinh and IDXa = " + iDXa;
                        dt = dalmember.getTable(sqlquery);
                        iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                        iDTinh = dt.Rows[0]["IDTinh"].ToString();
                        sqlquery = "insert into DiaChi(IDTinh,IDHuyen,IDXa) values(" + iDTinh + "," + iDHuyen + "," + iDXa + ")";
                        dalmember.updateTable(sqlquery).ToString();
                        sqlquery = "select Max(IDDiaChi) from DiaChi";
                        return dalmember.layID(sqlquery).ToString();
                    }
                }
                else
                {
                    sqlquery = "select IDHuyen from Huyen where TenHuyen like N'" + tach2[0].Trim() + "'";
                    kq = dalmember.layID(sqlquery);
                    if (kq != null)
                    {
                        iDHuyen = kq;
                        sqlquery = "select * from Huyen where IDHuyen = " + iDHuyen;
                        dt = dalmember.getTable(sqlquery);
                        iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                        iDTinh = dt.Rows[0]["IDTinh"].ToString();
                        sqlquery = "insert into DiaChi(IDTinh,IDHuyen) values(" + iDTinh + "," + iDHuyen + ")";
                        dalmember.updateTable(sqlquery).ToString();
                        sqlquery = "select Max(IDDiaChi) from DiaChi";
                        return dalmember.layID(sqlquery).ToString();
                    }
                    else
                    {
                        sqlquery = "select IDTinh from Tinh where TenTinh like N'" + tach2[0].Trim() + "'";
                        kq = dalmember.layID(sqlquery);
                        if (kq != null)
                        {
                            sqlquery = "insert into DiaChi(IDTinh) values(" + kq + ")";
                            dalmember.updateTable(sqlquery).ToString();
                            sqlquery = "select Max(IDDiaChi) from DiaChi";
                            return dalmember.layID(sqlquery).ToString();
                        }
                    }
                }
            }
            sqlquery = "select IDXa from Xa,Huyen where TenXa = N'" + tach2[1].Trim() + "' and TenHuyen = N'" + tach2[2].Trim() + "' and Xa.IDHuyen = Huyen.IDHuyen;";
            kq = dalmember.layID(sqlquery);
            if (kq != null)
            {
                iDXa = kq;
                sqlquery = "select Huyen.IDHuyen,Huyen.IDTinh from Huyen,Xa,Tinh where Huyen.IDHuyen = Xa.IDHuyen and Huyen.IDTinh = Tinh.IDTinh and IDXa = " + iDXa;
                dt = dalmember.getTable(sqlquery);
                iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                iDTinh = dt.Rows[0]["IDTinh"].ToString();
                sqlquery = "insert into DiaChi(IDTinh,IDHuyen,IDXa,DiaChiCuThe) values(" + iDTinh + "," + iDHuyen + "," + iDXa + ",N'" + tach2[3] + "')";
                dalmember.updateTable(sqlquery).ToString();
                sqlquery = "select Max(IDDiaChi) from DiaChi";
                return dalmember.layID(sqlquery).ToString();
            }
            /*-------------------------------------------------------------*/
            if (tach3.Length < 4)
            {
                if (tach3.Length > 2)
                {
                    sqlquery = "select IDXa from Xa,Huyen where TenXa = N'" + tach3[0].Trim() + "' and TenHuyen = N'" + tach3[1].Trim() + "' and Xa.IDHuyen = Huyen.IDHuyen;";
                    kq = dalmember.layID(sqlquery);
                    if (kq != null)
                    {
                        iDXa = kq;
                        sqlquery = "select Huyen.IDHuyen,Huyen.IDTinh from Huyen,Xa,Tinh where Huyen.IDHuyen = Xa.IDHuyen and Huyen.IDTinh = Tinh.IDTinh and IDXa = " + iDXa;
                        dt = dalmember.getTable(sqlquery);
                        iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                        iDTinh = dt.Rows[0]["IDTinh"].ToString();
                        sqlquery = "insert into DiaChi(IDTinh,IDHuyen,IDXa) values(" + iDTinh + "," + iDHuyen + "," + iDXa + ")";
                        dalmember.updateTable(sqlquery).ToString();
                        sqlquery = "select Max(IDDiaChi) from DiaChi";
                        return dalmember.layID(sqlquery).ToString();
                    }
                }
                else
                {
                    sqlquery = "select IDHuyen from Huyen where TenHuyen like N'" + tach3[0].Trim() + "'";
                    kq = dalmember.layID(sqlquery);
                    if (kq != null)
                    {
                        iDHuyen = kq;
                        sqlquery = "select * from Huyen where IDHuyen = " + iDHuyen;
                        dt = dalmember.getTable(sqlquery);
                        iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                        iDTinh = dt.Rows[0]["IDTinh"].ToString();
                        sqlquery = "insert into DiaChi(IDTinh,IDHuyen) values(" + iDTinh + "," + iDHuyen + ")";
                        sqlquery = "select Max(IDDiaChi) from DiaChi";
                        return dalmember.updateTable(sqlquery).ToString();
                    }
                    else
                    {
                        sqlquery = "select IDTinh from Tinh where TenTinh like N'" + tach3[0].Trim() + "'";
                        kq = dalmember.layID(sqlquery);
                        if (kq != null)
                        {
                            sqlquery = "insert into DiaChi(IDTinh) values(" + kq + ")";
                            dalmember.updateTable(sqlquery).ToString();
                            sqlquery = "select Max(IDDiaChi) from DiaChi";
                            return dalmember.layID(sqlquery).ToString();
                        }
                    }
                }
            }
            sqlquery = "select IDXa from Xa,Huyen where TenXa = N'" + tach3[0].Trim() + "' and TenHuyen = N'" + tach3[1].Trim() + "' and Xa.IDHuyen = Huyen.IDHuyen;";
            kq = dalmember.layID(sqlquery);
            if (kq != null)
            {
                iDXa = kq;
                sqlquery = "select Huyen.IDHuyen,Huyen.IDTinh from Huyen,Xa,Tinh where Huyen.IDHuyen = Xa.IDHuyen and Huyen.IDTinh = Tinh.IDTinh and IDXa = " + iDXa;
                dt = dalmember.getTable(sqlquery);
                iDHuyen = dt.Rows[0]["IDHuyen"].ToString();
                iDTinh = dt.Rows[0]["IDTinh"].ToString();
                sqlquery = "insert into DiaChi(IDTinh,IDHuyen,IDXa,DiaChiCuThe) values(" + iDTinh + "," + iDHuyen + "," + iDXa + ",N'" + tach3[3].Trim() + "')";
                dalmember.updateTable(sqlquery).ToString();
                sqlquery = "select Max(IDDiaChi) from DiaChi";
                return dalmember.layID(sqlquery).ToString();
            }

            sqlquery = "insert into DiaChi(DiaChiCuThe) values(N'" + input + "')";
            dalmember.updateTable(sqlquery).ToString();
            sqlquery = "select Max(IDDiaChi) from DiaChi";
            return dalmember.layID(sqlquery).ToString();
        }

        public void deleteMember()
        {
            logical.GgSheetAPI ggsheet = new logical.GgSheetAPI();
            caseData.txtRead txtread = new caseData.txtRead();
            string[] idTable = txtread.readfile(0);
            int row = int.Parse(caseData.DataTam.DuLieu.idTemp) + 1;
            object rq = ggsheet.deleteData(idTable[1], idTable[2], row + ":" + row);
        }

        private void linkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }
    }
}
