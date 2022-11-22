using System.ComponentModel.DataAnnotations;

namespace CarHire.Core.ViewModels.Vehicle
{
    public class VehicleViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        [StringLength(10)]
        public string Color { get; set; }

        [Required]
        public int VehicleTypeId { get; set; }
    }
}
