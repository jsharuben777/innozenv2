using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test_web_1.Models;
using Test_web_1.Services.Business;

namespace Test_web_1.Controllers
{
    public class HomeController : Controller //it looks for Home Folder 
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }

        public IActionResult test() //This is for TESTING THE LOGIN VERIFICATION AND VALIDATION , TO CROSSCHECK WITH SSMS DATA TO LIMIT ACCESS OF USERS INTO INNOZEN
        {
            return View(); //it returns the view page
        }
        public IActionResult test2() //This is for TESTING THE LOGIN VERIFICATION AND VALIDATION , TO CROSSCHECK WITH SSMS DATA TO LIMIT ACCESS OF USERS INTO INNOZEN
        {
            return View(); //it returns the view page
        }
        public string postData(Registration registration)
        {


            return "Results: Username = " + registration.Username +" , "+ "Password =" + registration.Password;

        }
        public ActionResult Authenticate(Registration registration)
        {
            SecurityServices securityServices = new SecurityServices();
            Boolean success = securityServices.Authenticate(registration);

            if (success)
            {
                return View ("Videopage1");

            }
            else
            {
                return View ("User_login_fail");
            }
        }

        public ActionResult Authenticate_admin (Admin admin)
        {
            SecurityServices securityServices = new SecurityServices();
            Boolean success = securityServices.Authenticate_admin(admin);

            if (success)
            {
                return View("Admin_homepage");

            }
            else
            {
                return View("Admin_login_fail");
            }
        }

        public IActionResult Index1() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }
        public IActionResult TestPg1() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {


            return View(); // it returns the view page
        }
        public IActionResult User_login() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult User_login_fail() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Videopage1() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Ideaspage() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page3
        }
        public IActionResult Infoportal() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_1() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_1_1() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_1_2() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_1_3() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_1_4() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_2() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_2_1() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_2_2() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_2_3() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_2_4() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_2_5() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_2_6() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }  
        public IActionResult Infoportal_2_2_7() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_3() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_2_4() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_3() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }

        public IActionResult Infoportal_3_1() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {
            return View(); // it returns the view page
        }
        public IActionResult Infoportal_4() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }

        public IActionResult Infoportal_5() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_5_1() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_5_2() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_5_3() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_5_4() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_6() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_7() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_8() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_9() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Infoportal_10() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }

        public IActionResult Admin_homepage() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Admin_login() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Admin_login_fail() //This is a user_login METHOD , it looks for user_login page in Home folder
        {

            return View(); // it returns the view page
        }
        public IActionResult Admin_registerdata() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }
        public IActionResult Sidebarmenu2() //This is a INDEX METHOD , so it looks for index page in Home Folder
        {
            return View(); //it returns the view page
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Empideas() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {
            return View(); // it returns the view page
        }
        public IActionResult Quizpage() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {
            return View(); // it returns the view page
        }
        public IActionResult Quizpage_1() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {
            return View(); // it returns the view page
        }
        public IActionResult Quizpage_2() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {
            return View(); // it returns the view page
        }
        public IActionResult Quizpage_3() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {
            return View(); // it returns the view page
        }
        public IActionResult Quizpage_4() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {
            return View(); // it returns the view page
        }
        public IActionResult Language() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {
            return View(); // it returns the view page
        }
      

    }
}