using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using QLTK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTK.BLL
{
    public class ExcelExportHelper
    {
        public void ExportSaoKe(string filePath, TaiKhoan tk, List<GiaoDich> dsGiaoDich, decimal soDuCuoiKy)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("SaoKe"); // Đặt tên sheet là "SaoKe"[cite: 4]

                // Dòng 1 & 2: Tên ngân hàng và số tài khoản (gộp ô, chữ đậm, cỡ chữ lớn hơn)[cite: 4]
                worksheet.Cell("A1").Value = tk.TenNH;
                worksheet.Range("A1:D1").Merge();
                worksheet.Cell("A1").Style.Font.Bold = true;
                worksheet.Cell("A1").Style.Font.FontSize = 14;

                worksheet.Cell("A2").Value = "Tài khoản: " + tk.STK;
                worksheet.Range("A2:D2").Merge();
                worksheet.Cell("A2").Style.Font.Bold = true;
                worksheet.Cell("A2").Style.Font.FontSize = 12;

                // Tiêu đề bảng ở dòng 4
                worksheet.Cell("A4").Value = "Id";
                worksheet.Cell("B4").Value = "Loại GD";
                worksheet.Cell("C4").Value = "Số tiền";
                worksheet.Cell("D4").Value = "Nội dung";

                var headerRange = worksheet.Range("A4:D4");
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.LightGray; // Màu nền tiêu đề

                // Đổ dữ liệu từ dòng 5
                int row = 5;
                foreach (var gd in dsGiaoDich)
                {
                    worksheet.Cell(row, 1).Value = gd.Id;
                    worksheet.Cell(row, 2).Value = gd.SoTien > 0 ? "Nhận tiền" : "Rút tiền";
                    worksheet.Cell(row, 3).Value = gd.SoTien; // Lấy đúng giá trị trong bảng GiaoDich (rút là số âm)[cite: 4]
                    worksheet.Cell(row, 3).Style.NumberFormat.Format = "#,##0"; // Định dạng phân cách hàng nghìn[cite: 4]
                    worksheet.Cell(row, 4).Value = gd.NoiDung;
                    row++;
                }

                // Dòng tổng kết Số dư cuối kỳ ở cuối bảng[cite: 4]
                worksheet.Cell(row, 3).Value = "Số dư cuối kỳ:";
                worksheet.Cell(row, 3).Style.Font.Bold = true;
                worksheet.Cell(row, 4).Value = soDuCuoiKy;
                worksheet.Cell(row, 4).Style.Font.Bold = true;
                worksheet.Cell(row, 4).Style.NumberFormat.Format = "#,##0";

                // Kẻ viền cho toàn bộ bảng[cite: 4]
                var tableRange = worksheet.Range(4, 1, row, 4);
                tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                // Tự động giãn cột vừa nội dung[cite: 4]
                worksheet.Columns().AdjustToContents();

                // Lưu file[cite: 4]
                workbook.SaveAs(filePath);
            }
        }
    }
}
