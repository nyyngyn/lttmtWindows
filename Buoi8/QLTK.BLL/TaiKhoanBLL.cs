using QLTK.DAL;
using QLTK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTK.BLL
{
    public class TaiKhoanBLL
    {
        private readonly TaiKhoanDAL _tkDAL = new TaiKhoanDAL();
        private readonly GiaoDichDAL _gdDAL = new GiaoDichDAL();

        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return _tkDAL.GetAll();
        }

        // Tính số dư cuối kỳ = Số dư đầu kỳ + Tổng giao dịch gửi - Tổng giao dịch rút[cite: 4]
        public decimal GetSoDuCuoiKy(string stk)
        {
            var tk = _tkDAL.GetAll().FirstOrDefault(t => t.STK == stk);
            if (tk == null) return 0;

            var tongGiaoDich = _gdDAL.GetAll().Where(g => g.STK == stk).Sum(g => g.SoTien);
            return tk.SoDuDauKy + tongGiaoDich;
        }
    }
}
