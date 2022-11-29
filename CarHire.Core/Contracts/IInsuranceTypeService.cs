using CarHire.Core.ViewModels.InsuranceType;

namespace CarHire.Core.Contracts
{
    public interface IInsuranceTypeService
    {
        Task<IEnumerable<InsuranceTypeViewModel>> GetAllAsync();

        Task CreateInsuranceTypeAsync(InsuranceTypeViewModel model);

        Task Delete(int id);

        Task<InsuranceTypeViewModel> FindById(int id);
    }
}
