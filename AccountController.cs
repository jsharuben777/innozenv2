using Microsoft.AspNetCore.Mvc;

namespace Test_web_1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Signout()
        {
            return View();
        }
    }
}
