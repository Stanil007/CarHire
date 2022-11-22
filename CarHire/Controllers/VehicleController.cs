using CarHire.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.Controllers
{
    [Authorize]
    public class VehicleController : Controller
    { 
        private readonly IVehicleService vehicleService;


    }
}
