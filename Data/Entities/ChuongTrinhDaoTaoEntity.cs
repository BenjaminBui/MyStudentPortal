using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("ChuongTrinhDaoTao")]
public class ChuongTrinhDaoTaoEntity : BaseEntity
{
    public string Ten { get; set; }

    #region Mapper Properties

    public virtual ICollection<ChuongTrinhDaoTaoHocPhanEntity> ChuongTrinhDaoTaoHocPhanList { get; set; }
    public virtual ICollection<NguoiDungEntity> NguoiDungList { get; set; }

    #endregion
}