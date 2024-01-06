using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("NguoiDung")]
public class NguoiDungEntity : BaseEntity
{
    public string MSDD { get; set; }
    
    public string Email { get; set; }

    public string HashMatKhau { get; set; }

    public string Ten { get; set; }

    public string DiaChi { get; set; }

    public string SDT { get; set; }

    public int GioiTinh { get; set; }

    [ForeignKey("ChuongTrinhDaoTao")]
    public Guid? ChuongTrinhDaoTaoId { get; set; }
    
    [ForeignKey("VaiTro")]
    public Guid VaiTro { get; set; }
}