namespace QLVLXD.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VLXDDbContext : DbContext
    {
        public VLXDDbContext()
            : base("name=VLXD")
        {
        }

        public virtual DbSet<CHITIETPN> CHITIETPNs { get; set; }
        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIHANGHOA> LOAIHANGHOAs { get; set; }
        public virtual DbSet<NHACC> NHACCs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CHITIETPNs)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CTHOADONs)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CTHOADONs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIHANGHOA>()
                .HasMany(e => e.HANGHOAs)
                .WithOptional(e => e.LOAIHANGHOA)
                .HasForeignKey(e => e.LOAIHANG);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.NVLAP);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUNHAPs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.NVLAP);

            modelBuilder.Entity<PHIEUNHAP>()
                .HasMany(e => e.CHITIETPNs)
                .WithRequired(e => e.PHIEUNHAP)
                .WillCascadeOnDelete(false);
        }
    }
}
