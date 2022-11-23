using CarHire.Core.ViewModels.DiverCategory;

namespace CarHire.Core.Contracts
{
    public interface IDriverCategoryService
    {
        Task<IEnumerable<DriverCategoryViewModel>> GetAllAsync();

        Task CreateDriverCategoryAsync(DriverCategoryViewModel model);

        Task Delete(int id);

        Task<DriverCategoryViewModel> FindById(int id);
    }
}
