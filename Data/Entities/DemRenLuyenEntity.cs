using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("DiemRenLuyen")]
public class DemRenLuyenEntity : BaseEntity
{
    public int Diem { get; set; }
    
    [ForeignKey("HocKy")]
    public Guid HocKyId { get; set; }
}
