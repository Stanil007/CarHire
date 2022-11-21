using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Infrastructure.Data.Models
{
    public class InsuraneType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }
    }
}
