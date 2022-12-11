using CarHire.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<VehicleType> VehicleType { get; set; } = new List<VehicleType>();

        [Required]
        [StringLength(250)]
        public string ImageUrl { get; set; }


        [Required]
        [Precision(7, 2)]
        [Range(20, 99999)]
        public decimal PricePerDay { get; set; }
    }
}
