using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("HocPhan")]
public class HocPhanEntity : BaseEntity
{
    public string Ten { get; set; }

    public string MoTa { get; set; }

    public string MaHocPhan { get; set; }

    public int SoTinChi { get; set; }
}