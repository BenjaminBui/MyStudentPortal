using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("ChuongTrinhDaoTaoHocPhan")]
public class ChuongTrinhDaoTaoHocPhanEntity : BaseEntity
{
    public Guid ChuongTrinhDaoTaoId { get; set; }
    
    [ForeignKey("ChuongTrinhDaoTaoId")]
    public virtual ChuongTrinhDaoTaoEntity ChuongTrinhDaoTao { get; set; }

    public Guid HocPhanId { get; set; }
    
    [ForeignKey("HocPhanId")]
    public virtual HocPhanEntity HocPhan { get; set; }
}