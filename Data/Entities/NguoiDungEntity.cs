using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("NguoiDung")]
public class NguoiDungEntity : BaseEntity
{
    public string MSDD { get; set; }
    
    public string Email { get; set; }

    public string HashMatKhau { get; set; }

    public string Ten { get; set; }

    public string DiaChi { get; set; }

    public string SDT { get; set; }

    public int GioiTinh { get; set; }

    public Guid? ChuongTrinhDaoTaoId { get; set; }
    
    [ForeignKey("ChuongTrinhDaoTaoId")]
    public virtual ChuongTrinhDaoTaoEntity ChuongTrinhDaoTao { get; set; }
    
    public Guid VaiTroId { get; set; }

    [ForeignKey("VaiTroId")] 
    public virtual VaiTroEntity VaiTro { get; set; }

    #region Mapper Properties

    public virtual ICollection<DiemEntity> DiemList { get; set; }
    public virtual ICollection<HocPhiEntity> HocPhiList { get; set; }
    public virtual ICollection<LopHocPhanSinhVienEntity> LopHocPhanSinhVienList { get; set; }
    public virtual ICollection<PhongSinhVienEntity> PhongSinhVienList { get; set; }
    public virtual ICollection<ThoiGianHocEntity> ThoiGianHocList { get; set; }
    public virtual ICollection<ThongBaoEntity> ThongBaoList { get; set; }

    #endregion
}