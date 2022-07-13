using Microsoft.AspNetCore.Mvc;

namespace MVCFirstApp.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        public EmployeeController()
        {
        }
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
