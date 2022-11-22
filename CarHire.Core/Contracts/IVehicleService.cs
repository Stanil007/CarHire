using CarHire.Core.ViewModels.Vehicle;

namespace CarHire.Core.Contracts
{
    public interface IVehicleService
    {
        Task<VehicleViewModel> Details(string id);

        Task<IEnumerable<VehicleViewModel>> All();

        Task CreateAsync(VehicleViewModel model);

        Task EditAsync(VehicleViewModel model);

        Task Delete(string id);
    }
}
