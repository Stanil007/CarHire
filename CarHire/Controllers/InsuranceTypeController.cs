using CarHire.Core.Contracts;
using CarHire.Core.ViewModels.InsuranceType;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.Controllers
{
    public class InsuranceTypeController : Controller
    {
        private readonly IInsuranceTypeService insuranceTypeService;

        public InsuranceTypeController(IInsuranceTypeService _insuranceTypeService)
        {
            insuranceTypeService = _insuranceTypeService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await insuranceTypeService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateInsuranceType()
        {
            var model = new InsuranceTypeViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInsuranceType(InsuranceTypeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await insuranceTypeService.CreateInsuranceTypeAsync(model);
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var insuranceType = await insuranceTypeService.FindById(id);

            await insuranceTypeService.Delete(id);

            return RedirectToAction(nameof(All));

        }
    }
}
