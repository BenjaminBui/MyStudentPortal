using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("ThongBao")]
public class ThongBaoEntity : BaseEntity
{
    public string NoiDung { get; set; }
    
    [ForeignKey("SinhVien")]
    public Guid SinhVienId { get; set; }
}