using CarHire.Core.Contracts;
using CarHire.Core.ViewModels.InsuranceType;
using CarHire.Infrastructure.Data;
using CarHire.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarHire.Core.Services
{
    public class InsuranceTypeService : IInsuranceTypeService
    {

        private readonly ApplicationDbContext context;

        public InsuranceTypeService(ApplicationDbContext _context)
        {
            context = _context;
        }


        public async Task CreateInsuranceTypeAsync(InsuranceTypeViewModel model)
        {
            var insurance = new InsuraneType()
            {
                Name = model.Name,
            };

            await context.InsuraneTypes.AddAsync(insurance);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var insuranceType = context.InsuraneTypes.FirstOrDefault(x => x.Id == id);

             context.InsuraneTypes.Remove(insuranceType);
            await context.SaveChangesAsync();
        }

        public async Task<InsuranceTypeViewModel> FindById(int id)
        {
            var insuranceType = await context.InsuraneTypes
                .Where(x => x.Id == id)
                .Select(i => new InsuranceTypeViewModel()
                {
                    Name=i.Name
                })
                .FirstOrDefaultAsync();

            return insuranceType;
        }

        public async Task<IEnumerable<InsuranceTypeViewModel>> GetAllAsync()
        {
            var insuranceTypes = await context.InsuraneTypes
                .ToListAsync();

            return insuranceTypes.Select(i => new InsuranceTypeViewModel()
            {
                Name = i.Name
            })
            .ToList();
        }
    }
}
