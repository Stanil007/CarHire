using CarHire.Core.Contracts;
using CarHire.Core.ViewModels.Vehicle;
using CarHire.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.Controllers
{
   // [Authorize]

    // Fill the categories collection

    public class VehicleController : Controller
    { 
        private readonly IVehicleService vehicleService;

        public VehicleController(IVehicleService _vehicleService)
        {
            vehicleService = _vehicleService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var vehicles = await vehicleService.GetAllAsync();

            return View(vehicles);
        }

        [HttpGet]
        public async Task <IActionResult> CreateVehicle()
        {
            var model = new VehicleViewModel()
            {
                VehicleType = await vehicleService.GetVehicleTypesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle(VehicleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await vehicleService.CreateVehicleAsync(model);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await vehicleService.FindById(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditVehicleViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (id != model.Id)
            {
                return RedirectToPage("/Home/Index");
            }

            await vehicleService.EditAsync(id, model);
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var vehicle = await vehicleService.FindById(id);

            await vehicleService.Delete(id);

            return RedirectToAction(nameof(All));

        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await vehicleService.FindById(id);

            return View(model);
        }
    }
}
