using CongThongTin.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CongThongTin.Data
{
    public class CongThongTinDbContext : DbContext
    {
        public CongThongTinDbContext(DbContextOptions options) : base(options) { 
        }

        public virtual DbSet<NguoiDungEntity> NguoiDung { get; set; }
        
        public virtual DbSet<ChuongTrinhDaoTaoEntity> ChuongTrinhDaoTao { get; set; }
        
        public virtual DbSet<ChuongTrinhDaoTaoHocPhanEntity> ChuongTrinhDaoTaoHocPhan { get; set; }
        
        public virtual DbSet<DemRenLuyenEntity> DemRenLuyen { get; set; }
        
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
        
        public virtual DbSet<ThoiKhoaBieuEntity> ThoiKhoaBieu { get; set; }
        
        public virtual DbSet<ThongBaoEntity> ThongBao { get; set; }
        
        public virtual DbSet<VaiTroEntity> VaiTro { get; set; }
    }
}
