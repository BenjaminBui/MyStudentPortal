using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("LichThi")]
public class LichThiEntity : BaseEntity
{
    public Guid LopHocPhanId { get; set; }

    public DateTime NgayThi { get; set; }

    public TimeSpan GioBatDau { get; set; }
    
    public TimeSpan GioKetThuc { get; set; }
    
}