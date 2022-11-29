using CarHire.Core.Contracts;
using CarHire.Core.Services;
using CarHire.Core.ViewModels.DiverCategory;
using CarHire.Core.ViewModels.Vehicle;
using CarHire.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.Controllers
{
    [Authorize]
    public class DriverCategoryController : Controller
    {
        private readonly IDriverCategoryService driverCategoryService;

        public DriverCategoryController(IDriverCategoryService _driverCategoryService)
        {
            driverCategoryService = _driverCategoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
           var model = await driverCategoryService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateDriverCategory()
        {
            var model = new DriverCategoryViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDriverCategory(DriverCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await driverCategoryService.CreateDriverCategoryAsync(model);
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await driverCategoryService.FindById(id);

            await driverCategoryService.Delete(id);

            return RedirectToAction(nameof(All));

        }
    }
}
