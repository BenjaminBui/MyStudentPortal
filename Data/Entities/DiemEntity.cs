using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("Diem")]
public class DiemEntity : BaseEntity
{
    public int Diem { get; set; }

    [ForeignKey("HocPhan")]
    public Guid HocPhanId { get; set; }
    
    [ForeignKey("SinhVien")]
    public Guid SinhVienId { get; set; }

    [ForeignKey("LopHocPhan")]
    public Guid LopHocPhanId { get; set; }
}