using CarHire.Core.Contracts;
using CarHire.Core.ViewModels.Vehicle;
using CarHire.Infrastructure.Data;
using CarHire.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarHire.Core.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDbContext context;

        public VehicleService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<AllVehicleViewModel>> GetAllAsync()
        {
            var vehicles = await context.Vehicles
                 .ToListAsync();

            return vehicles.Select(v => new AllVehicleViewModel
            {
                Make = v.Make,
                Model = v.Model,
                ImageUrl = v.ImageUrl,
                PricePerDay = v.PricePerDay
            });
        }

        public async Task CreateVehicleAsync(VehicleViewModel model)
        {
            var vehicle = new Vehicle()
            {
                Make = model.Make,
                Model = model.Model,
                Color = model.Color,
                VehicleTypeId = model.VehicleTypeId,
                ImageUrl = model.ImageUrl,
                PricePerDay = model.PricePerDay
            };

            await context.Vehicles.AddAsync(vehicle);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var vehicle = await context.Vehicles
                .FirstOrDefaultAsync(v => v.Id == id);

            context.Vehicles.Remove(vehicle);
            await context.SaveChangesAsync();
        }

        public async Task<EditVehicleViewModel> Details(int id)
        {
            return await context.Vehicles
                .Where(v => v.Id == id)
                .Select(v => new EditVehicleViewModel()
                {  
                    Make = v.Make,
                    Model = v.Model,
                    Color = v.Color,
                    VehicleTypeId = v.VehicleTypeId,
                    IsHired= v.IsHired,
                    ImageUrl = v.ImageUrl,
                    PricePerDay = v.PricePerDay
                })
                .FirstAsync();
        }

        public async Task EditAsync(int id , EditVehicleViewModel model)
        {
            var vehicle = await context.Vehicles
                .FirstOrDefaultAsync(v => v.Id == id);

            vehicle.Make = model.Make;
            vehicle.Model = model.Model;
            vehicle.Color = model.Color;
            vehicle.VehicleTypeId = model.VehicleTypeId;
            vehicle.PricePerDay = model.PricePerDay;
            vehicle.ImageUrl = model.ImageUrl;

            await context.SaveChangesAsync();
        }

        public async Task<EditVehicleViewModel> FindById(int id)
        {
            var vehicle = await context.Vehicles
                .Where(v => v.Id == id)
                .Select(v => new EditVehicleViewModel()
                {
                    Make = v.Make,
                    Model = v.Model,
                    Color = v.Color,
                    VehicleTypeId = v.VehicleTypeId,
                    PricePerDay = v.PricePerDay,
                    ImageUrl = v.ImageUrl
                })
                .FirstOrDefaultAsync();

            return vehicle;
        }
    }
}
