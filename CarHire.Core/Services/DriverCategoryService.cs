using CarHire.Core.Contracts;
using CarHire.Core.ViewModels.DiverCategory;
using CarHire.Infrastructure.Data;
using CarHire.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarHire.Core.Services
{
    public class DriverCategoryService : IDriverCategoryService
    {
        private readonly ApplicationDbContext context;

        public DriverCategoryService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task CreateDriverCategoryAsync(DriverCategoryViewModel model)
        {
            var category = new DriverCategory()
            {
                Name = model.Name
            };

            await context.DriverCategories.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var driverCategory = context.DriverCategories.FirstOrDefault(c => c.Id == id);

            context.DriverCategories.Remove(driverCategory);
            await context.SaveChangesAsync();
        }

        public async Task<DriverCategoryViewModel> FindById(int id)
        {
            var category = await context.DriverCategories
                .Where(c => c.Id == id)
                .Select(c => new DriverCategoryViewModel
                {
                    Name = c.Name,
                })
                .FirstOrDefaultAsync();

            return category;
        }

        public async Task<IEnumerable<DriverCategoryViewModel>> GetAllAsync()
        {
            var categories = await context.DriverCategories
                .ToListAsync();

            return categories.Select(c => new DriverCategoryViewModel()
            {
                Name=c.Name
            });
        }
    }
}
