using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("PhongSinhVien")]
public class PhongSinhVienEntity : BaseEntity
{
    [ForeignKey("Phong")]
    public Guid PhongId { get; set; }

    [ForeignKey("NguoiDung")]
    public Guid SinhVienId { get; set; }
}