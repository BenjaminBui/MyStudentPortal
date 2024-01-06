using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("PhongSinhVien")]
public class PhongSinhVienEntity : BaseEntity
{
    public Guid PhongId { get; set; }
    
    [ForeignKey("PhongId")] 
    public virtual PhongEntity Phong { get; set; }

    public Guid SinhVienId { get; set; }
    
    [ForeignKey("SinhVienId")] 
    public virtual NguoiDungEntity NguoiDung { get; set; }
}