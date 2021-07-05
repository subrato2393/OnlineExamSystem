using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExam.Web.Areas.member.Models;
using System.Threading.Tasks;

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

        [HttpPost]
        public async Task <IActionResult> AddCourse(CourseModel model)
        {
            await model.AddCourseInformation(User.Identity.Name);
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
