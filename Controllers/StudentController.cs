using Microsoft.AspNetCore.Mvc;

namespace aspnet_register_and_login.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
