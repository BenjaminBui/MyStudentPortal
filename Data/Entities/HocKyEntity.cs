using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("HocKy")]
public class HocKyEntity : BaseEntity
{
    public string Ten { get; set; }

    public DateTime ThoiGianBatDau { get; set; }

    public DateTime ThoiGianKetThuc { get; set; }

    #region Mapper Properties

    public virtual ICollection<LopHocPhanEntity> LopHocPhanList { get; set; }
    public virtual ICollection<DiemRenLuyenEntity> DiemRenLuyenList { get; set; }
    public virtual ICollection<HocPhiEntity> HocPhiList { get; set; }

    #endregion
}