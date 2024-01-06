using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("Phong")]
public class PhongEntity : BaseEntity
{
    public int SoLuongSinhVien { get; set; }

    [ForeignKey("KyTucXa")]
    public Guid KTXId { get; set; }
}