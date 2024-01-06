using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace CongThongTin.Data.Entities;

[Table("LopHocPhanSinhVien")]
public class LopHocPhanSinhVienEntity : BaseEntity
{
    [ForeignKey("NguoiDung")]
    public Guid SinhVienId { get; set; }
    
    [ForeignKey("LopHocPhan")]
    public Guid LopHocPhanId { get; set; }
}