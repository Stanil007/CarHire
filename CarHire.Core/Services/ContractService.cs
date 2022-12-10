using CarHire.Core.Contracts;
using CarHire.Core.ViewModels.ContractDTOs;
using CarHire.Infrastructure.Data;
using CarHire.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarHire.Core.Services
{
    public class ContractService : IContractService
    {
        private readonly ApplicationDbContext context;

        public ContractService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task CreateContractAsync(ContractViewModel model)
        {
            var contract = new Contract()
            {
                StartDate = DateTime.Parse(model.StartDate),
                FinishDate = DateTime.Parse(model.FinishDate),
                ApplicationUsersId = model.ApplicationUsersId,
                VehicleId = model.VehicleId,
                InsuranceId = model.InsuranceId
            };

            await context.Contracts.AddAsync(contract);
            await context.SaveChangesAsync();
        }

        public async Task Edit(int contractId, ContractViewModel model)
        {
            var contract = await context.Contracts.FirstOrDefaultAsync(x => x.Id == contractId);

            contract.StartDate = DateTime.Parse(model.StartDate);
            contract.FinishDate = DateTime.Parse(model.FinishDate);
            contract.ApplicationUsersId = model.ApplicationUsersId;
            contract.VehicleId = model.VehicleId;
            contract.InsuranceId = model.InsuranceId;

            await context.SaveChangesAsync();
        }

        public async Task<ContractViewModel> FindById(int id)
        {
            var contract = await context.Contracts
                .Where(x => x.Id == id)
                .Select(x => new ContractViewModel
                {
                    StartDate = x.StartDate.ToString(),
                    FinishDate = x.FinishDate.ToString(),
                    ApplicationUsersId = x.ApplicationUsersId,
                    VehicleId = x.VehicleId,
                    InsuranceId = x.InsuranceId
                })
                .FirstOrDefaultAsync();

            return contract;
        }

        public async Task<IEnumerable<ContractViewModel>> GetAllAsync()
        {
            var contracts = await context.Contracts.ToListAsync();

            return  contracts.Select(x => new ContractViewModel
            {
                StartDate = x.StartDate.ToString(),
                FinishDate = x.FinishDate.ToString(),
                ApplicationUsersId = x.ApplicationUsersId,
                VehicleId = x.VehicleId,
                InsuranceId = x.InsuranceId
            })
                .ToList();
        }
    }
}
