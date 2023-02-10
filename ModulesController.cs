using Microsoft.AspNetCore.Mvc;

namespace Test_web_1.Controllers
{
    public class ModulesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Modules_1() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }
        public IActionResult Modules_2() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }
        public IActionResult Modules_3() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }
        public IActionResult Modules_4() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }
        public IActionResult Modules_5() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }

    }
}
