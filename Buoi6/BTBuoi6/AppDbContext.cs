using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTBuoi6
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(
            "Server=.\\SQLEXPRESS;" +
            "Database=QUANLYSINHVIEN;" +
            "Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
        public async Task ThemSinhVienAsync(string hoTen, double diem)
        {
            using (var context = new AppDbContext())
            {
                Student svMoi = new Student
                {
                    FullName = hoTen,
                    Grade = diem
                };
                context.Students.Add(svMoi);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<Student>> LayDanhSachAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students.ToListAsync();
            }
        }
        public async Task<List<Student>> LocSinhVienDatAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students
                .Where(sv => sv.Grade >= 5)
                .OrderByDescending(sv => sv.Grade)
                .ToListAsync();
            }
        }
        public async Task SuaSinhVienAsync(int id, string hoTenMoi,double diemMoi)
        {
            using (var context = new AppDbContext())
            {
                Student sv = await context.Students.FindAsync(id);
                if (sv != null)
                {
                    sv.FullName = hoTenMoi;
                    sv.Grade = diemMoi;
                    await context.SaveChangesAsync();
                }
            }
        }
        public async Task XoaSinhVienAsync(int id)
        {
            using (var context = new AppDbContext())
            {
                Student sv = await
                context.Students.FindAsync(id);
                if (sv != null)
                {
                    context.Students.Remove(sv);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
