using QLTK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTK.DAL
{
    public class GiaoDichDAL
    {
        private readonly QLTKContextDB _context = new QLTKContextDB();

        public List<GiaoDich> GetAll()
        {
            return _context.GiaoDichs.ToList();
        }

        public bool Add(GiaoDich gd)
        {
            try
            {
                _context.GiaoDichs.Add(gd);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
