using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Core.ViewModels.InsuranceType
{
    public class InsuranceTypeViewModel
    {

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
