using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("LopHocPhan")]
public class LopHocPhanEntity : BaseEntity
{
    public string MaSoHocPhan { get; set; }
    
    public int SoLuongSinhVien { get; set; }
    
    [ForeignKey("HocPhan")]
    public Guid HocPhanId { get; set; }
    
    [ForeignKey("HocKy")]
    public Guid HocKyID { get; set; }
}
