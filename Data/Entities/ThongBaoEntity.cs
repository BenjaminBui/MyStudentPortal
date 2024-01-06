using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("ThongBao")]
public class ThongBaoEntity : BaseEntity
{
    public string NoiDung { get; set; }
    
    public Guid NguoiDungId { get; set; }
    
    [ForeignKey("NguoiDungId")] 
    public virtual NguoiDungEntity NguoiDung { get; set; }
}