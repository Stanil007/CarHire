using System.ComponentModel.DataAnnotations;

namespace CarHire.Core.ViewModels.ContractDTOs
{
    public class ContractViewModel
    {
        [Required]
        public string StartDate { get; set; }

        [Required]
        public string FinishDate { get; set; }

        [Required]
        public string ApplicationUsersId { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [Required]
        public int InsuranceId { get; set; }
    }
}
