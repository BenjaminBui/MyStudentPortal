using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("Diem")]
public class DiemEntity : BaseEntity
{
    public int Diem { get; set; }

    public Guid HocPhanId { get; set; }
    
    [ForeignKey("HocPhanId")]
    public virtual HocPhanEntity HocPhan { get; set; }
    
    public Guid SinhVienId { get; set; }
    
    [ForeignKey("SinhVienId")]
    public virtual NguoiDungEntity NguoiDung { get; set; }

    public Guid LopHocPhanId { get; set; }

    [ForeignKey("LopHocPhanId")]
    public virtual LopHocPhanEntity LopHocPhan { get; set; }
}