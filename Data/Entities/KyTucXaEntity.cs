using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Data.Entities;

[Table("KyTucXa")]
public class KyTucXaEntity : BaseEntity
{
    public string MaKTX { get; set; }   
}