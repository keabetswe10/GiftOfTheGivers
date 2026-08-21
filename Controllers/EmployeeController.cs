using Microsoft.AspNetCore.Mvc;

namespace GiftOfTheGivers.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult PostUpdate()
        {
            return View();
        }

        public IActionResult Volunteers()
        {
            return View();
        }   
    }
}
