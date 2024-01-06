using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("Phong")]
public class PhongEntity : BaseEntity
{
    public int SoLuongSinhVien { get; set; }

    public Guid KTXId { get; set; }

    [ForeignKey("KTXId")] 
    public virtual KyTucXaEntity KyTucXa { get; set; }

    #region Mapper Properties

    public virtual ICollection<PhongSinhVienEntity> PhongSinhVienList { get; set; }

    #endregion
}