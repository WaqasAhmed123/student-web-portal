using Microsoft.AspNetCore.Mvc;

namespace StudentPortalWeb.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
