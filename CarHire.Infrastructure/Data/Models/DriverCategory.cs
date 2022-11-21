using System.ComponentModel.DataAnnotations;

namespace CarHire.Infrastructure.Data.Models
{
    public class DriverCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
