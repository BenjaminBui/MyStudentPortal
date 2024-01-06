using CongThongTin.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CongThongTin.Data
{
    public class CongThongTinDbContext : DbContext
    {
        public CongThongTinDbContext()
        {
        }

        public CongThongTinDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<NguoiDungEntity> NguoiDung { get; set; }

        public virtual DbSet<ChuongTrinhDaoTaoEntity> ChuongTrinhDaoTao { get; set; }

        public virtual DbSet<ChuongTrinhDaoTaoHocPhanEntity> ChuongTrinhDaoTaoHocPhan { get; set; }

        public virtual DbSet<DiemRenLuyenEntity> DemRenLuyen { get; set; }

        public virtual DbSet<DiemEntity> Diem { get; set; }

        public virtual DbSet<HocKyEntity> HocKy { get; set; }

        public virtual DbSet<HocPhanEntity> HocPhan { get; set; }

        public virtual DbSet<HocPhiEntity> HocPhi { get; set; }

        public virtual DbSet<KyTucXaEntity> KyTucXa { get; set; }

        public virtual DbSet<LichThiEntity> LichThi { get; set; }

        public virtual DbSet<LopHocPhanEntity> LopHocPhan { get; set; }

        public virtual DbSet<LopHocPhanSinhVienEntity> LopHocPhanSinhVien { get; set; }

        public virtual DbSet<PhongEntity> Phong { get; set; }

        public virtual DbSet<PhongSinhVienEntity> PhongSinhVien { get; set; }

        public virtual DbSet<ThoiGianHocEntity> ThoiKhoaBieu { get; set; }

        public virtual DbSet<ThongBaoEntity> ThongBao { get; set; }

        public virtual DbSet<VaiTroEntity> VaiTro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureModels(modelBuilder);
        }

        public static void ConfigureModels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHocPhanEntity>()
                .HasOne(x => x.HocPhan)
                .WithMany(z => z.LopHocPhanList)
                .HasForeignKey(x => x.HocPhanId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<LopHocPhanEntity>()
                .HasOne(x => x.HocKy)
                .WithMany(z => z.LopHocPhanList)
                .HasForeignKey(x => x.HocKyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DiemEntity>()
                .HasOne(x => x.LopHocPhan)
                .WithMany(z => z.DiemList)
                .HasForeignKey(x => x.LopHocPhanId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            
            modelBuilder.Entity<DiemEntity>()
                .HasOne(x => x.NguoiDung)
                .WithMany(z => z.DiemList)
                .HasForeignKey(x => x.SinhVienId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<DiemEntity>()
                .HasOne(x => x.HocPhan)
                .WithMany(z => z.DiemList)
                .HasForeignKey(x => x.HocPhanId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LopHocPhanEntity>()
                .HasOne(x => x.HocPhan)
                .WithMany(z => z.LopHocPhanList)
                .HasForeignKey(x => x.HocPhanId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<LopHocPhanEntity>()
                .HasOne(x => x.HocKy)
                .WithMany(z => z.LopHocPhanList)
                .HasForeignKey(x => x.HocKyId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<ChuongTrinhDaoTaoHocPhanEntity>()
                .HasOne(x => x.HocPhan)
                .WithMany(z => z.ChuongTrinhDaoTaoHocPhanList)
                .HasForeignKey(x => x.HocPhanId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<ChuongTrinhDaoTaoHocPhanEntity>()
                .HasOne(x => x.ChuongTrinhDaoTao)
                .WithMany(z => z.ChuongTrinhDaoTaoHocPhanList)
                .HasForeignKey(x => x.ChuongTrinhDaoTaoId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<DiemRenLuyenEntity>()
                .HasOne(x => x.HocKy)
                .WithMany(z => z.DiemRenLuyenList)
                .HasForeignKey(x => x.HocKyId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<HocPhiEntity>()
                .HasOne(x => x.HocKy)
                .WithMany(z => z.HocPhiList)
                .HasForeignKey(x => x.HocKyId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<HocPhiEntity>()
                .HasOne(x => x.HocPhan)
                .WithMany(z => z.HocPhiList)
                .HasForeignKey(x => x.HocPhanId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<HocPhiEntity>()
                .HasOne(x => x.NguoiDung)
                .WithMany(z => z.HocPhiList)
                .HasForeignKey(x => x.SinhVienId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<LopHocPhanSinhVienEntity>()
                .HasOne(x => x.LopHocPhan)
                .WithMany(z => z.LopHocPhanSinhVienList)
                .HasForeignKey(x => x.LopHocPhanId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<LopHocPhanSinhVienEntity>()
                .HasOne(x => x.NguoiDung)
                .WithMany(z => z.LopHocPhanSinhVienList)
                .HasForeignKey(x => x.SinhVienId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<NguoiDungEntity>()
                .HasOne(x => x.ChuongTrinhDaoTao)
                .WithMany(z => z.NguoiDungList)
                .HasForeignKey(x => x.ChuongTrinhDaoTaoId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<NguoiDungEntity>()
                .HasOne(x => x.VaiTro)
                .WithMany(z => z.NguoiDungList)
                .HasForeignKey(x => x.VaiTroId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<PhongEntity>()
                .HasOne(x => x.KyTucXa)
                .WithMany(z => z.PhongList)
                .HasForeignKey(x => x.KTXId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<PhongSinhVienEntity>()
                .HasOne(x => x.NguoiDung)
                .WithMany(z => z.PhongSinhVienList)
                .HasForeignKey(x => x.SinhVienId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<PhongSinhVienEntity>()
                .HasOne(x => x.Phong)
                .WithMany(z => z.PhongSinhVienList)
                .HasForeignKey(x => x.PhongId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<ThoiGianHocEntity>()
                .HasOne(x => x.LopHocPhan)
                .WithMany(z => z.ThoiGianHocList)
                .HasForeignKey(x => x.LopHocPhanId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<ThoiGianHocEntity>()
                .HasOne(x => x.NguoiDung)
                .WithMany(z => z.ThoiGianHocList)
                .HasForeignKey(x => x.GiangVienId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<ThongBaoEntity>()
                .HasOne(x => x.NguoiDung)
                .WithMany(z => z.ThongBaoList)
                .HasForeignKey(x => x.NguoiDungId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}