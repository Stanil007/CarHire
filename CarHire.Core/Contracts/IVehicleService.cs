using CarHire.Core.ViewModels.Vehicle;

namespace CarHire.Core.Contracts
{
    public interface IVehicleService
    {
        Task<VehicleDetailsViewModel> Details(int id);

        Task<IEnumerable<AllVehicleViewModel>> GetAllAsync();

        Task CreateVehicleAsync(VehicleViewModel model);

        Task EditAsync(int id, VehicleViewModel model);

        Task Delete(int id);

        Task<VehicleViewModel> FindById(int id);
    }
}
