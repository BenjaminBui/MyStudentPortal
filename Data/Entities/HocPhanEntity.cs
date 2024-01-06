using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("HocPhan")]
public class HocPhanEntity : BaseEntity
{
    public string Ten { get; set; }

    public string MoTa { get; set; }

    public string MaHocPhan { get; set; }

    public int SoTinChi { get; set; }

    #region Mapper Properties

    public virtual ICollection<LopHocPhanEntity> LopHocPhanList { get; set; }
    public virtual ICollection<DiemEntity> DiemList { get; set; }
    public virtual ICollection<ChuongTrinhDaoTaoHocPhanEntity> ChuongTrinhDaoTaoHocPhanList { get; set; }
    public virtual ICollection<HocPhiEntity> HocPhiList { get; set; }

    #endregion
}