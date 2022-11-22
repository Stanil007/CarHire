using CarHire.Core.Contracts;
using CarHire.Core.ViewModels.Vehicle;
using CarHire.Infrastructure.Data.Models;
using CarHire.Infrastructure.Data.Common;

namespace CarHire.Core.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository repo;

        public VehicleService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<IEnumerable<VehicleViewModel>> All()
        {
            return await repo.AllReadonly<Vehicle>();
        }

        public Task CreateAsync(VehicleViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleViewModel> Details(string id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(VehicleViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
