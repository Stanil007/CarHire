using System.ComponentModel.DataAnnotations;

namespace CarHire.Infrastructure.Data.Models
{
    public class VehicleCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public IEnumerable<VehicleType> VehicleTypes { get; set; } = new List<VehicleType>();
    }
}
