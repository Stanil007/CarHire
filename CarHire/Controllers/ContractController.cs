using CarHire.Core.Contracts;
using CarHire.Core.Services;
using CarHire.Core.ViewModels.ContractDTOs;
using CarHire.Core.ViewModels.DiverCategory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarHire.Controllers
{

    [Authorize]
    public class ContractController : Controller
    {
        private readonly IContractService contractService;

        public ContractController(IContractService _contractService)
        {
           contractService = _contractService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await contractService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateContract()
        {
            var model = new ContractViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContract(ContractViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await contractService.CreateContractAsync(model);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var contract = await contractService.FindById(id);

            var model = new ContractViewModel()
            {
                StartDate = contract.StartDate,
                FinishDate = contract.FinishDate,
                ApplicationUsersId = contract.ApplicationUsersId,
                VehicleId = contract.VehicleId,
                InsuranceId = contract.InsuranceId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ContractViewModel model)
        {
            if (ModelState.IsValid == false)
            {

                return View(model);
            }

            await contractService.Edit(id, model);

            return RedirectToAction(nameof(All));
        }
    }
}
