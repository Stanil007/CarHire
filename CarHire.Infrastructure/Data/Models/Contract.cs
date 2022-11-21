using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarHire.Infrastructure.Data.Models 
{ 
    public class Contract
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime FinishDate { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        [Required]
        public string ApplicationUsersId { get; set; }

        [ForeignKey(nameof(ApplicationUsersId))]
        public ApplicationUser ApplicationUsers { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [ForeignKey(nameof(VehicleId))]
        public Vehicle Vehicle { get; set; }

        [Required]
        public int InsuranceId { get; set; }

        [ForeignKey(nameof(InsuranceId))]
        public InsuraneType InsuraneType { get; set; }
    }
}
