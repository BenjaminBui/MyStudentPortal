using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("ChuongTrinhDaoTao")]
public class ChuongTrinhDaoTaoEntity : BaseEntity
{
    public string Ten { get; set; }
}