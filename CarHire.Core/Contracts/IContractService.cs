using CarHire.Core.ViewModels.ContractDTOs;

namespace CarHire.Core.Contracts
{
    public interface IContractService
    {
        Task<IEnumerable<ContractViewModel>> GetAllAsync();

        Task CreateContractAsync(ContractViewModel model);

        Task Edit(int id, ContractViewModel model);

        Task<ContractViewModel> FindById(int id);
    }
}
