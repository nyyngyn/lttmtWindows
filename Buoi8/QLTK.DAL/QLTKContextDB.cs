using Microsoft.EntityFrameworkCore;
using QLTK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTK.DAL
{
    public class QLTKContextDB : DbContext
    {
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<GiaoDich> GiaoDichs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Chuỗi kết nối tới cơ sở dữ liệu TestQLTK
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TestQLTK;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Nạp dữ liệu mẫu bảng TaiKhoan
            modelBuilder.Entity<TaiKhoan>().HasData(
                new TaiKhoan { STK = "1111111746", TenNH = "VCB - Ngân hàng TMCP Ngoại thương Việt Nam", SoDuDauKy = 200 },
                new TaiKhoan { STK = "1111111812", TenNH = "VietinBank-Ngân hàng TMCP Công Thương Việt Nam", SoDuDauKy = 100 }
            );

            // Nạp dữ liệu mẫu bảng GiaoDich[cite: 4]
            modelBuilder.Entity<GiaoDich>().HasData(
                new GiaoDich { Id = 1, SoTien = 100, NoiDung = "Ủng hộ miền trung", STK = "1111111746" },
                new GiaoDich { Id = 2, SoTien = -50, NoiDung = "Rút chi tiền đợt 1", STK = "1111111746" },
                new GiaoDich { Id = 3, SoTien = 120, NoiDung = "ủng hộ miền trung", STK = "1111111746" },
                new GiaoDich { Id = 4, SoTien = 80, NoiDung = "ủng hộ miền trung 812", STK = "1111111812" },
                new GiaoDich { Id = 5, SoTien = 180, NoiDung = "ủng hộ miền trung tk812", STK = "1111111812" }
            );
        }
    }
}
