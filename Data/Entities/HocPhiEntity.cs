using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("HocPhi")]
public class HocPhiEntity : BaseEntity
{
    public bool DaThanhToan { get; set; }
    
    public Guid SinhVienId { get; set; }
    
    [ForeignKey("SinhVienId")] 
    public virtual NguoiDungEntity NguoiDung { get; set; }
    
    public Guid HocKyId { get; set; }
    
    [ForeignKey("HocKyId")] 
    public virtual HocKyEntity HocKy { get; set; }
    
    public Guid HocPhanId { get; set; }
    
    [ForeignKey("HocPhanId")] 
    public virtual HocPhanEntity HocPhan { get; set; }
}