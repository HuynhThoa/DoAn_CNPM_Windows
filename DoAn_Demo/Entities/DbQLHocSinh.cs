using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_Demo.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BangXepLoai> BangXepLoais { get; set; }
        public virtual DbSet<CTBangDiem> CTBangDiems { get; set; }
        public virtual DbSet<DanhSachLop> DanhSachLops { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<LoaiLop> LoaiLops { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangXepLoai>()
                .HasMany(e => e.CTBangDiems)
                .WithRequired(e => e.BangXepLoai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BangXepLoai>()
                .HasMany(e => e.DanhSachLops)
                .WithOptional(e => e.BangXepLoai)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DanhSachLop>()
                .Property(e => e.IDLopHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .HasMany(e => e.DanhSachLops)
                .WithRequired(e => e.HocSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.IDLopHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.DanhSachLops)
                .WithRequired(e => e.LopHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.CTBangDiems)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);
        }
    }
}
