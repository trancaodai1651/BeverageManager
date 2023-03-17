using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Beverage_Manager.Models
{
    public partial class DBQuanLyBanNuocGiaiKhat : DbContext
    {
        public DBQuanLyBanNuocGiaiKhat()
            : base("name=DBQuanLyBanNuocGiaiKhat")
        {
        }

        public virtual DbSet<CT_DONHANG> CT_DONHANG { get; set; }
        public virtual DbSet<CT_PNHAPKHO> CT_PNHAPKHO { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<DONVI> DONVIs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHAPKHO> NHAPKHOes { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<TONKHO> TONKHOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DONHANG>()
                .HasMany(e => e.CT_DONHANG)
                .WithOptional(e => e.DONHANG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DONVI>()
                .HasMany(e => e.SANPHAMs)
                .WithOptional(e => e.DONVI)
                .HasForeignKey(e => e.IDDV);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DONHANGs)
                .WithOptional(e => e.KHACHHANG)
                .HasForeignKey(e => e.IDKH);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.NHAPKHOes)
                .WithOptional(e => e.NHACUNGCAP)
                .HasForeignKey(e => e.IDNCC);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.DONHANGs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.IDNV);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHAPKHOes)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.IDNV);

            modelBuilder.Entity<NHAPKHO>()
                .HasMany(e => e.CT_PNHAPKHO)
                .WithOptional(e => e.NHAPKHO)
                .HasForeignKey(e => e.IDPNK);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CT_PNHAPKHO)
                .WithOptional(e => e.SANPHAM)
                .HasForeignKey(e => e.IDSP);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.TONKHOes)
                .WithOptional(e => e.SANPHAM)
                .HasForeignKey(e => e.IDSP)
                .WillCascadeOnDelete();
        }
    }
}
