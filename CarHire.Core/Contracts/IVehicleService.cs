using CarHire.Core.ViewModels.Vehicle;
using CarHire.Infrastructure.Data.Models;

namespace CarHire.Core.Contracts
{
    public interface IVehicleService
    {
        Task<EditVehicleViewModel> Details(int id);

        Task<IEnumerable<AllVehicleViewModel>> GetAllAsync();

        Task CreateVehicleAsync(VehicleViewModel model);

        Task EditAsync(int id, EditVehicleViewModel model);

        Task Delete(int id);

        Task<EditVehicleViewModel> FindById(int id);

        Task<IEnumerable<VehicleType>> GetVehicleTypesAsync();
    }
}
