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
            var model = new CourseModel();
            model.GetAllTags();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCourse(CourseModel model)
        {
            if (ModelState.IsValid)
            {
                await model.AddCourseInformation(User.Identity.Name);

                model.GetAllTags();

                return RedirectToAction("SearchCourse");
            }

            return RedirectToAction("SearchCourse");
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
