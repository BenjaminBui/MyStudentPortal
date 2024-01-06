using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("ChuongTrinhDaoTaoHocPhan")]
public class ChuongTrinhDaoTaoHocPhanEntity : BaseEntity
{
    [ForeignKey("ChuongTrinhDaoTao")]
    public Guid ChuongTrinhDaoTaoId { get; set; }
    
    [ForeignKey("HocPhan")]
    public Guid HocPhanId { get; set; }
}