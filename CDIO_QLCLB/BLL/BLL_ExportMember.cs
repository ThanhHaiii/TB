using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_ExportMember
    {
        GUI.frm_ExportListMember frm_ExportList;
        DAL.DAL_ExportMember exportMember = new DAL.DAL_ExportMember();
        Export.ToExcel export = new Export.ToExcel();

        public BLL_ExportMember(GUI.frm_ExportListMember frm)
        {
            frm_ExportList = frm;
        }

        public void loadAllMember()
        {
            string sqlquery = "Select Row_number() over(order by ThanhVien.IDChucVu,TenThanhVien,HoThanhVien) STT, HoThanhVien,TenThanhVien,MSSV,iif(GioiTinh = 0,N'Nữ',N'Nam') as gioitinh,TenChucVu,Lop from ThanhVien,ChucVu where ThanhVien.IDChucVu = ChucVu.IDChucVu  and RoiCLB is null order by ThanhVien.IDChucVu,TenThanhVien,HoThanhVien";
            DataTable dt = exportMember.GetDataTable(sqlquery);
            frm_ExportList.dgv_List.DataSource = dt.Copy();
        }

        public void loadTVCT()
        {
            string sqlquery = "Select Row_number() over(order by ThanhVien.IDChucVu,TenThanhVien,HoThanhVien) STT, HoThanhVien,TenThanhVien,MSSV,iif(GioiTinh = 0,N'Nữ',N'Nam') as gioitinh,TenChucVu,Lop from ThanhVien,ChucVu where ThanhVien.IDChucVu = ChucVu.IDChucVu and ThanhVien.IDChucVu != 8 and RoiCLB is null order by ThanhVien.IDChucVu,TenThanhVien,HoThanhVien";
            DataTable dt = exportMember.GetDataTable(sqlquery);
            frm_ExportList.dgv_List.DataSource = dt.Copy();
        }

        public void loadCTV()
        {
            string sqlquery = "Select Row_number() over(order by ThanhVien.IDChucVu,TenThanhVien,HoThanhVien) STT, HoThanhVien,TenThanhVien,MSSV,iif(GioiTinh = 0,N'Nữ',N'Nam') as gioitinh,TenChucVu,Lop from ThanhVien,ChucVu where ThanhVien.IDChucVu = ChucVu.IDChucVu and ThanhVien.IDChucVu = 8 and RoiCLB is null order by ThanhVien.IDChucVu,TenThanhVien,HoThanhVien";
            DataTable dt = exportMember.GetDataTable(sqlquery);
            frm_ExportList.dgv_List.DataSource = dt.Copy();
        }

        public void exportExcel()
        {
            export.exportToExxcel(frm_ExportList.dgv_List, "DANH SÁCH THÀNH VIÊN CLB TÌNH NGUYỆN SINH VIÊN DUY TÂN", "DanhSach");
        }
    }
}
