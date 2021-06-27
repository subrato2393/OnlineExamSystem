using Microsoft.AspNetCore.Mvc;

namespace OnlineExam.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult OrganizationLogin()
        {
            return View();
        } 

        public IActionResult OrganizationSignUp()
        {
            return View();
        }


    }
}
