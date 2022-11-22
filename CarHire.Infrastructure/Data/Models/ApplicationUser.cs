using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarHire.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int DriverCategoryId { get; set; }

        [ForeignKey(nameof(DriverCategoryId))]
        public DriverCategory DriverCategory { get; set; }

        public IEnumerable<Contract> Contracts { get; set; } = new List<Contract>();

    }
}
