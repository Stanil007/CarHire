using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Core.ViewModels.Vehicle
{
    public class VehicleDetailsViewModel
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public decimal PricePerDay { get; set; }

        public string ImageUrl { get; set; }

        public int VehicleTypeId { get; set; }

        public bool IsHired { get; set; }
    }
}
