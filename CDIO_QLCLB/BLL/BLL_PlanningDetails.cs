using System;
using System.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_PlanningDetails
    {
        GUI.frm_PlanningDetails frmPlaning;
        DAL.DAL_PlanningDetails dalPlanning = new DAL.DAL_PlanningDetails();
        public BLL_PlanningDetails(GUI.frm_PlanningDetails form)
        {
            frmPlaning = form;
        }

        public void loadPlanning()
        {
            string sqlQuyery = "select IDKeHoach,TieuDe,NoiDung,NgayRaKH,VanBanKemTheo,LinkTaiLieu,TenTinh,TenHuyen,TenXa,DiaChiCuThe,KeHoach.NguoiRaKH,HoThanhVien + ' ' + TenThanhVien as HoTen from KeHoach, ThanhVien,DiaChi,Xa,Huyen,Tinh,DiaDiem where KeHoach.IDKeHoach = " +
                caseData.DataTam.DuLieu.idTemp + " and KeHoach.NguoiRaKH = ThanhVien.IDThanhVien and DiaChi.IDDiaChi = KeHoach.IDDiaChi and KeHoach.IDDiaDiem = DiaDiem.IDDiaDiem and DiaChi.IDXa = Xa.IDXa and DiaChi.IDHuyen = Huyen.IDHuyen and Tinh.IDTinh = DiaChi.IDTinh";
            DataTable dt = dalPlanning.getDataPlan(sqlQuyery);
            frmPlaning.lb_TieuDe.Text = dt.Rows[0]["TieuDe"].ToString();
            DateTime ngay = Convert.ToDateTime(dt.Rows[0]["NgayRaKH"].ToString());
            frmPlaning.lb_DateTime.Text = "Ngày ra kế hoạch: " + ngay.ToString("dd/MM/yyyy hh:mm tt");
            frmPlaning.lb_FullName.Text = "Người ra kế hoạch: " + dt.Rows[0]["HoTen"].ToString();
            if (dt.Rows[0]["DiaChiCuThe"].ToString() != "")
            {
                frmPlaning.lb_Location.Text = "Địa chỉ: " + dt.Rows[0]["DiaChiCuThe"].ToString() + " - " + dt.Rows[0]["TenXa"].ToString() + " - " + dt.Rows[0]["TenHuyen"].ToString() + " - " + dt.Rows[0]["TenTinh"].ToString();
            }
            else
            {
                frmPlaning.lb_Location.Text = "Địa chỉ: " +  dt.Rows[0]["TenXa"].ToString() + " - " + dt.Rows[0]["TenHuyen"].ToString() + " - " + dt.Rows[0]["TenTinh"].ToString();
            }
            if (dt.Rows[0]["VanBanKemTheo"].ToString()!="")
            {
                frmPlaning.linklb_Documen.Text = dt.Rows[0]["VanBanKemTheo"].ToString();
                frmPlaning.linklb_Documen.Links.Add(0, (dt.Rows[0]["VanBanKemTheo"].ToString().Length), dt.Rows[0]["LinkTaiLieu"].ToString());
                frmPlaning.linklb_Documen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LinkedLabelClicked);
            }else
            {
                frmPlaning.linklb_Documen.Text = "Không có tài liệu đính kèm";
                frmPlaning.linklb_Documen.Links.Clear();
            }
            frmPlaning.tb_MainContent.Text = dt.Rows[0]["NoiDung"].ToString();
        }

        private void LinkedLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPlaning.linklb_Documen.LinkVisited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }
    }
}
