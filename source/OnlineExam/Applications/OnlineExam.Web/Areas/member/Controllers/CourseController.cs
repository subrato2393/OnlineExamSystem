using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineExam.Web.Areas.member.Controllers
{
    [Area("member")]
    [Authorize(Policy = "OrganizationAccess")]
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCourse() 
        {
            return View();
        }

        public IActionResult EditCourse()
        {
            return View();
        }

        public IActionResult SearchCourse() 
        {
            return View();
        }

        public IActionResult AssignTrainers() 
        {
            return View();
        }
    }
}
