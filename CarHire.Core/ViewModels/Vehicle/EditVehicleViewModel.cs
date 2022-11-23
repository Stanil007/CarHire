using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Core.ViewModels.Vehicle
{
    public class EditVehicleViewModel
    {
        public int Id { get; set; }

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

        [Required]
        [StringLength(250)]
        public string ImageUrl { get; set; }

        public bool IsHired { get; set; }

        [Required]
        [Precision(7, 2)]
        [Range(20, 99999)]
        public decimal PricePerDay { get; set; }
    }
}
