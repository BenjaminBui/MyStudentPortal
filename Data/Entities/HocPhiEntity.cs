using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("HocPhi")]
public class HocPhiEntity : BaseEntity
{
    public bool DaThanhToan { get; set; }
    
    [ForeignKey("NguoiDung")] 
    public Guid SinhVienId { get; set; }
    
    [ForeignKey("HocKy")] 
    public Guid HocKyId { get; set; }
    
    [ForeignKey("HocPhan")] 
    public Guid HocPhanId { get; set; }
}