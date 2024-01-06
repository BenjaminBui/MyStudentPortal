using System.ComponentModel.DataAnnotations;

namespace CongThongTin.Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime TaoLuc { get; set; }
        public Guid TaoBoi { get; set; }
        public DateTime CapNhatLuc { get; set; }
        public Guid CapNhatBoi { get; set; }
        public bool DaXoa { get; set; }
    }
}
