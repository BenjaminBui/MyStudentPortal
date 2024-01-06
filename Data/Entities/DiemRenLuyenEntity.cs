using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("DiemRenLuyen")]
public class DiemRenLuyenEntity : BaseEntity
{
    public int Diem { get; set; }
    
    public Guid HocKyId { get; set; }

    [ForeignKey("HocKyId")]
    public virtual HocKyEntity HocKy { get; set; }
}
