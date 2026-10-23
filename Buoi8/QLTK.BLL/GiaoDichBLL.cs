using QLTK.DAL;
using QLTK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTK.BLL
{
    public class GiaoDichBLL
    {
        private readonly GiaoDichDAL _gdDAL = new GiaoDichDAL();
        private readonly TaiKhoanBLL _tkBLL = new TaiKhoanBLL();

        public List<GiaoDich> GetAllGiaoDich()
        {
            return _gdDAL.GetAll();
        }

        public List<GiaoDich> GetGiaoDichGuiTien()
        {
            return _gdDAL.GetAll().Where(g => g.SoTien > 0).ToList();
        }

        // Xử lý logic Thêm mới giao dịch kèm ràng buộc[cite: 4]
        public string AddGiaoDich(string stk, string loaiGD, int soTien, string noiDung)
        {
            // 1. Kiểm tra số tiền bắt buộc nhập từ [1 - 100000000][cite: 4]
            if (soTien < 1 || soTien > 100000000)
            {
                return "Vui lòng nhập số tiền từ 1-100000000!";
            }

            int thucTeSoTien = soTien;

            // 2. Nếu là "Rút tiền", kiểm tra số dư cuối kỳ[cite: 4]
            if (loaiGD == "Rút tiền")
            {
                thucTeSoTien = -soTien; // Lưu số âm trong CSDL[cite: 4]
                decimal soDuHienTai = _tkBLL.GetSoDuCuoiKy(stk);
                if (soTien > soDuHienTai)
                {
                    return "Tài khoản không đủ số tiền để rút!";
                }
            }

            var gd = new GiaoDich
            {
                STK = stk,
                SoTien = thucTeSoTien,
                NoiDung = noiDung
            };

            bool result = _gdDAL.Add(gd);
            return result ? "Thêm mới giao dịch thành công!" : "Thêm giao dịch thất bại!";
        }
    }
}
