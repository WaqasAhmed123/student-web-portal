using Microsoft.AspNetCore.Mvc;

namespace StudentPortalWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public Task<IActionResult> Register()
        {

        }
    }
}
