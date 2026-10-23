using QLTK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTK.DAL
{
    public class TaiKhoanDAL
    {
        private readonly QLTKContextDB _context = new QLTKContextDB();

        public List<TaiKhoan> GetAll()
        {
            return _context.TaiKhoans.ToList();
        }
    }
}
