using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("ThoiKhoaBieu")]
public class ThoiKhoaBieuEntity : BaseEntity
{
    public DateTime NgayHoc { get; set; }
    
    public DateTime ThoiGianBatDau { get; set; }
    
    public DateTime ThoiGianKetThuc { get; set; }
    
    [ForeignKey("NguoiDung")]
    public Guid GiangVienId  { get; set; }
    
    [ForeignKey("LopHocPhan")]
    public Guid LopHocPhanId { get; set; }
}