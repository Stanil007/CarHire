using System.ComponentModel.DataAnnotations;

namespace CarHire.Infrastructure.Data.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Make { get; set; }

        [Required]
        [StringLength(20)]
        public string Model { get; set; }

        [Required]
        [StringLength(10)]
        public string Color { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public bool IsHired { get; set; } = false;

        [Required]
        public int VehicleTypeId { get; set; }

        public VehicleType VehicleType { get; set; }
    }
}
