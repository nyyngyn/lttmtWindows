using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFC2
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;"+"Database=QuanLySinhVien;"+"Trusted_Connection=true;TrustServerCertificate=true");
        }

        public async Task ThemSinhVienAsync(string fullName, double diem)
        {
            using (var context = new AppDbContext())
            {
                var student = new Student
                {
                    FullName = fullName,
                    Grade = diem
                };
                context.Students.Add(student);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<Student>> LayDanhSachSinhVienAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students.ToListAsync();
            }
        }
       public async T
    }
}
