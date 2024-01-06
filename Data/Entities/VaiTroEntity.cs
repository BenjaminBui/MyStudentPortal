using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("VaiTro")]
public class VaiTroEntity : BaseEntity
{
    public string Ten { get; set; }

    #region Mapper Properties

    public virtual ICollection<NguoiDungEntity> NguoiDungList { get; set; }

    #endregion
}