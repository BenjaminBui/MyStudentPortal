using System.ComponentModel.DataAnnotations;

namespace CongThongTin.Data
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedById { get; set; }
        public bool IsDeleted { get; set; }
    }
}
