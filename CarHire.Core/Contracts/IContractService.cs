using CarHire.Core.ViewModels.ContractDTOs;

namespace CarHire.Core.Contracts
{
    public interface IContractService
    {
        Task<IEnumerable<AllContractViewModel>> GetAllAsync();

        Task CreateContractAsync(CreateContractViewViewModel model);

        Task Delete(int id);

        Task<ContractViewModel> FindById(int id);
    }
}
