using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarHire.Infrastructure.Data.Models
{
    public class VehicleType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public int VehicleCategoryId { get; set; }

        [ForeignKey(nameof(VehicleCategoryId))]
        public VehicleCategory VehicleCategory { get; set; }
    }
}
