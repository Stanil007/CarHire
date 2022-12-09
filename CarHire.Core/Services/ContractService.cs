using CarHire.Core.Contracts;
using CarHire.Core.ViewModels.ContractDTOs;
using CarHire.Infrastructure.Data;

namespace CarHire.Core.Services
{
    public class ContractService : IContractService
    {
        private readonly ApplicationDbContext context;

        public ContractService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public Task CreateContractAsync(CreateContractViewViewModel model)
        {

        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ContractViewModel> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllContractViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
