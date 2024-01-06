using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace CongThongTin.Data.Entities;

[Table("LopHocPhanSinhVien")]
public class LopHocPhanSinhVienEntity : BaseEntity
{
    public Guid SinhVienId { get; set; }
    
    [ForeignKey("SinhVienId")]
    public virtual NguoiDungEntity NguoiDung { get; set; }
    
    public Guid LopHocPhanId { get; set; }
    
    [ForeignKey("LopHocPhanId")]
    public virtual LopHocPhanEntity LopHocPhan { get; set; }
}