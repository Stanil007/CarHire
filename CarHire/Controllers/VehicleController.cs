using Microsoft.AspNetCore.Mvc;

namespace CarHire.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
