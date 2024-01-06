using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("LopHocPhan")]
public class LopHocPhanEntity : BaseEntity
{
    public string MaSoHocPhan { get; set; }
    
    public int SoLuongSinhVien { get; set; }
    
    public Guid HocPhanId { get; set; }
    
    [ForeignKey("HocPhanId")]
    public virtual HocPhanEntity HocPhan { get; set; }
    
    public Guid HocKyId { get; set; }
    
    [ForeignKey("HocKyId")]
    public virtual HocKyEntity HocKy { get; set; }

    #region Mapper Properties

    public virtual ICollection<DiemEntity> DiemList { get; set; }
    public virtual ICollection<LopHocPhanSinhVienEntity> LopHocPhanSinhVienList { get; set; }
    public virtual ICollection<ThoiGianHocEntity> ThoiGianHocList { get; set; }

    #endregion
}
