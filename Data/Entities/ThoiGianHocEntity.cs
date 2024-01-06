using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("ThoiKhoaBieu")]
public class ThoiGianHocEntity : BaseEntity
{
    public DateTime NgayHoc { get; set; }
    
    public DateTime ThoiGianBatDau { get; set; }
    
    public DateTime ThoiGianKetThuc { get; set; }
    
    public Guid GiangVienId  { get; set; }
    
    [ForeignKey("GiangVienId")] 
    public virtual NguoiDungEntity NguoiDung { get; set; }
    
    public Guid LopHocPhanId { get; set; }
    
    [ForeignKey("LopHocPhanId")] 
    public virtual LopHocPhanEntity LopHocPhan { get; set; }
}