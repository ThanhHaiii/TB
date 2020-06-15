using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data;

namespace CDIO_QLCLB.Export
{
    class ToExcel
    {

        DAL.SQLClass sql = new DAL.SQLClass();

        public void exportToExxcel(DataGridView data, string titleName, string sheetName)
        {
            DateTime dtime = DateTime.Now;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks workbooks;
            Microsoft.Office.Interop.Excel.Sheets sheets;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            excel.Visible = true;
            excel.DisplayAlerts = false;
            excel.Application.SheetsInNewWorkbook = 1;

            workbooks = excel.Workbooks;
            workbook = (Microsoft.Office.Interop.Excel.Workbook)(excel.Workbooks.Add(Type.Missing));
            sheets = workbook.Worksheets;
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(1);
            worksheet.Name = sheetName;

            //Tạo tiêu ngữ
            Microsoft.Office.Interop.Excel.Range unitName = worksheet.get_Range("A1", "C1");
            unitName.MergeCells = true;
            unitName.Value2 = "ĐOÀN TRƯỜNG ĐH DUY TÂN";
            unitName.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            unitName.Font.Name = "Times New Roman";
            unitName.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range groupName = worksheet.get_Range("A2", "C2");
            groupName.MergeCells = true;
            groupName.Value2 = "CLB TÌNH NGUYỆN SV DUY TÂN";
            groupName.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            groupName.Font.Bold = true;
            groupName.Font.Name = "Times New Roman";
            groupName.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range unitName2 = worksheet.get_Range("E1", "G1");
            unitName2.MergeCells = true;
            unitName2.Value2 = "ĐOÀN TNCS HỒ CHÍ MINH";
            unitName2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            unitName2.Font.Bold = true;
            unitName2.Font.Name = "Times New Roman";
            unitName2.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range datetime = worksheet.get_Range("E3", "G3");
            datetime.MergeCells = true;
            datetime.Value2 = "Đà Nẵng, ngày " + dtime.Day + " tháng " + dtime.Month + " năm " + dtime.Year;
            datetime.Font.Italic = true;
            datetime.Font.Underline = true;
            datetime.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            datetime.Font.Name = "Times New Roman";
            datetime.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range title = worksheet.get_Range("A5", "G5");
            title.MergeCells = true;
            title.Value2 = titleName;
            title.Font.Bold = true;
            title.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            title.Font.Name = "Times New Roman";
            title.Font.Size = "13";

            string[] idColum = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                "AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ",
                                "BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ"};
            int i;
            //Tạo Tiêu đề các cột
            for (i = 0; i < data.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range hrader = worksheet.get_Range(idColum[i] + "7", idColum[i] + "7");
                hrader.Value2 = data.Columns[i].HeaderText;
            }

            Microsoft.Office.Interop.Excel.Range rowHead = worksheet.get_Range("A7", idColum[i - 1] + "7");
            rowHead.Font.Bold = true;
            //kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            for (int r = 0; r < data.Rows.Count; r++)
            {
                for (int c = 0; c < data.Columns.Count; c++)
                {
                    Microsoft.Office.Interop.Excel.Range datacell = worksheet.get_Range(idColum[c] + (r + 8), idColum[c] + (r + 8));
                    datacell.Value2 = data.Rows[r].Cells[c].Value;
                    datacell.Font.Name = "Times New Roman";
                    datacell.Font.Size = "13";
                }
            }

            ////Thiết lập vùng điền dữ liệu

            int rowStart = 8;
            int columnStart = 1;
            int rowEnd = rowStart + data.Rows.Count - 1;
            int columnEnd = data.Columns.Count;

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowStart, columnStart];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowEnd - 1, columnEnd];

            //// Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = worksheet.get_Range(c1, c2);

            //// Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            worksheet.Columns["A:" + idColum[i]].AutoFit();

            //Tạo chữ ký
            Microsoft.Office.Interop.Excel.Range tmCLB = worksheet.get_Range(idColum[data.Columns.Count - 3] + (rowEnd + 3), idColum[data.Columns.Count - 1] + (rowEnd + 3));
            tmCLB.MergeCells = true;
            tmCLB.Value2 = "TM. CLB TÌNH NGUYỆN SINH VIÊN DUY TÂN";
            tmCLB.Font.Bold = true;
            tmCLB.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            tmCLB.Font.Name = "Times New Roman";
            tmCLB.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range chuNhiem = worksheet.get_Range(idColum[data.Columns.Count - 3] + (rowEnd + 4), idColum[data.Columns.Count - 1] + (rowEnd + 4));
            chuNhiem.MergeCells = true;
            chuNhiem.Value2 = "Chủ nhiệm";
            chuNhiem.Font.Bold = true;
            chuNhiem.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            chuNhiem.Font.Name = "Times New Roman";
            chuNhiem.Font.Size = "13";

            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien) from ThanhVien where RoiCLB is null and IDChucVu = 1";
            string tenChuNhiem = sql.layMotCell(sqlquery).ToString();
            Microsoft.Office.Interop.Excel.Range name = worksheet.get_Range(idColum[data.Columns.Count - 3] + (rowEnd + 8), idColum[data.Columns.Count - 1] + (rowEnd + 8));
            name.MergeCells = true;
            name.Value2 = tenChuNhiem;
            name.Font.Bold = true;
            name.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            name.Font.Name = "Times New Roman";
            name.Font.Size = "13";
        }

        public void exportComfirmationMember(string idMember)
        {
            System.Data.DataTable table = sql.exportComfirmationMember(idMember);

            DateTime dtime = DateTime.Now;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks workbooks;
            Microsoft.Office.Interop.Excel.Sheets sheets;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            excel.Visible = true;
            excel.DisplayAlerts = false;
            excel.Application.SheetsInNewWorkbook = 1;

            workbooks = excel.Workbooks;
            workbook = (Microsoft.Office.Interop.Excel.Workbook)(excel.Workbooks.Add(Type.Missing));
            sheets = workbook.Worksheets;
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(1);
            worksheet.Name = "GiayXacNhan";

            //Tạo tiêu ngữ
            Microsoft.Office.Interop.Excel.Range unitName = worksheet.get_Range("A1", "C1");
            unitName.MergeCells = true;
            unitName.Value2 = "ĐOÀN TRƯỜNG ĐH DUY TÂN";
            unitName.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            unitName.Font.Name = "Times New Roman";
            unitName.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range groupName = worksheet.get_Range("A2", "C2");
            groupName.MergeCells = true;
            groupName.Value2 = "CLB TÌNH NGUYỆN SV DUY TÂN";
            groupName.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            groupName.Font.Bold = true;
            groupName.Font.Name = "Times New Roman";
            groupName.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range unitName2 = worksheet.get_Range("E1", "G1");
            unitName2.MergeCells = true;
            unitName2.Value2 = "ĐOÀN TNCS HỒ CHÍ MINH";
            unitName2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            unitName2.Font.Bold = true;
            unitName2.Font.Name = "Times New Roman";
            unitName2.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range datetime = worksheet.get_Range("E3", "G3");
            datetime.MergeCells = true;
            datetime.Value2 = "Đà Nẵng, ngày " + dtime.Day + " tháng " + dtime.Month + " năm " + dtime.Year;
            datetime.Font.Italic = true;
            datetime.Font.Underline = true;
            datetime.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            datetime.Font.Name = "Times New Roman";
            datetime.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range title = worksheet.get_Range("A5", "G5");
            title.MergeCells = true;
            title.Value2 = "GIẤY XÁC NHẬN THÀNH VIÊN";
            title.Font.Bold = true;
            title.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            title.Font.Name = "Times New Roman";
            title.Font.Size = "16";

            Microsoft.Office.Interop.Excel.Range row1 = worksheet.get_Range("A7", "G7");
            row1.MergeCells = true;
            row1.Value2 = "Ban chủ nhiệm CLB Tình nguyện Sinh viên Duy Tân xác nhận:";
            row1.Font.Bold = true;
            row1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row1.RowHeight = 25;
            row1.Font.Name = "Times New Roman";
            row1.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row2Colum1 = worksheet.get_Range("A8", "A8");
            row2Colum1.Value2 = "Họ và tên:";
            row2Colum1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row2Colum1.RowHeight = 21;
            row2Colum1.Font.Name = "Times New Roman";
            row2Colum1.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row2Colum2 = worksheet.get_Range("B8", "C8");
            row2Colum2.Value2 = table.Rows[0]["HoTen"].ToString();
            row2Colum2.MergeCells = true;
            row2Colum2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row2Colum2.RowHeight = 21;
            row2Colum2.Font.Name = "Times New Roman";
            row2Colum2.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row2Colum3 = worksheet.get_Range("D8", "D8");
            row2Colum3.Value2 = "MSSV:";
            row2Colum3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row2Colum3.RowHeight = 21;
            row2Colum3.Font.Name = "Times New Roman";
            row2Colum3.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row2Colum4 = worksheet.get_Range("E8", "G8");
            row2Colum4.Value2 = table.Rows[0]["MSSV"].ToString();
            row2Colum4.MergeCells = true;
            row2Colum4.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row2Colum4.RowHeight = 21;
            row2Colum4.Font.Name = "Times New Roman";
            row2Colum4.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row3Colum1 = worksheet.get_Range("A9", "A9");
            row3Colum1.Value2 = "Ngày sinh:";
            row3Colum1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row3Colum1.RowHeight = 21;
            row3Colum1.Font.Name = "Times New Roman";
            row3Colum1.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row3Colum2 = worksheet.get_Range("B9", "C9");
            row3Colum2.Value2 = table.Rows[0]["ngaySinh"].ToString();
            row3Colum2.MergeCells = true;
            row3Colum2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row3Colum2.RowHeight = 21;
            row3Colum2.Font.Name = "Times New Roman";
            row3Colum2.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row4Colum1 = worksheet.get_Range("A10", "A10");
            row4Colum1.Value2 = "Lớp:";
            row4Colum1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row4Colum1.RowHeight = 21;
            row4Colum1.Font.Name = "Times New Roman";
            row4Colum1.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row4Colum2 = worksheet.get_Range("B10", "C10");
            row4Colum2.Value2 = table.Rows[0]["Lop"].ToString();
            row4Colum2.MergeCells = true;
            row4Colum2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row4Colum2.RowHeight = 21;
            row4Colum2.Font.Name = "Times New Roman";
            row4Colum2.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row4Colum3 = worksheet.get_Range("D10", "D10");
            row4Colum3.Value2 = "Khoa:";
            row4Colum3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row4Colum3.RowHeight = 21;
            row4Colum3.Font.Name = "Times New Roman";
            row4Colum3.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row4Colum4 = worksheet.get_Range("E10", "G10");
            row4Colum4.Value2 = table.Rows[0]["Khoa"].ToString();
            row4Colum4.MergeCells = true;
            row4Colum4.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row4Colum4.RowHeight = 21;
            row4Colum4.Font.Name = "Times New Roman";
            row4Colum4.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row5Colum1 = worksheet.get_Range("A11", "A11");
            row5Colum1.Value2 = "Ngày gia nhập:";
            row5Colum1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row5Colum1.RowHeight = 21;
            row5Colum1.ColumnWidth = 14;
            row5Colum1.Font.Name = "Times New Roman";
            row5Colum1.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row5Colum2 = worksheet.get_Range("B11", "C11");
            row5Colum2.Value2 = table.Rows[0]["ngayGiaNhap"].ToString();
            row5Colum2.MergeCells = true;
            row5Colum2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row5Colum2.RowHeight = 21;
            row5Colum2.ColumnWidth = 11;
            row5Colum2.Font.Name = "Times New Roman";
            row5Colum2.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row5Colum3 = worksheet.get_Range("D11", "D11");
            row5Colum3.Value2 = "Chức vụ:";
            row5Colum3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row5Colum3.RowHeight = 21;
            row5Colum3.ColumnWidth = 14;
            row5Colum3.Font.Name = "Times New Roman";
            row5Colum3.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row5Colum4 = worksheet.get_Range("E11", "G11");
            row5Colum4.Value2 = table.Rows[0]["TenChucVu"].ToString();
            row5Colum4.MergeCells = true;
            row5Colum4.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row5Colum4.RowHeight = 21;
            row5Colum4.ColumnWidth = 11;
            row5Colum4.Font.Name = "Times New Roman";
            row5Colum4.Font.Size = "13";

            //Tạo chữ ký
            Microsoft.Office.Interop.Excel.Range tmCLB = worksheet.get_Range("D15", "G15");
            tmCLB.MergeCells = true;
            tmCLB.Value2 = "TM. CLB TÌNH NGUYỆN SINH VIÊN DUY TÂN";
            tmCLB.Font.Bold = true;
            tmCLB.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            tmCLB.Font.Name = "Times New Roman";
            tmCLB.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range chuNhiem = worksheet.get_Range("D16", "G16");
            chuNhiem.MergeCells = true;
            chuNhiem.Value2 = "Chủ nhiệm";
            chuNhiem.Font.Bold = true;
            chuNhiem.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            chuNhiem.Font.Name = "Times New Roman";
            chuNhiem.Font.Size = "13";

            string sqlquery = "select (HoThanhVien + ' ' + TenThanhVien) from ThanhVien where RoiCLB is null and IDChucVu = 1";
            string tenChuNhiem = sql.layMotCell(sqlquery).ToString();
            Microsoft.Office.Interop.Excel.Range name = worksheet.get_Range("D20", "G20");
            name.MergeCells = true;
            name.Value2 = tenChuNhiem;
            name.Font.Bold = true;
            name.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            name.Font.Name = "Times New Roman";
            name.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range row12 = worksheet.get_Range("A12", "G12");
            row12.MergeCells = true;
            row12.WrapText = true;
            row12.Value2 = "Là thành viên của CLB Tình nguyện Sinh viên Duy Tân. Trong thời gian hoạt động đã có nhiều đóng góp tích cực, tham gia hoạt động đầy đủ.";
            row12.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row12.RowHeight = 39;
            row12.Font.Name = "Times New Roman";
            row12.Font.Size = "13";
        }
    }
}
