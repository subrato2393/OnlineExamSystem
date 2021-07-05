using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Entities;

namespace OnlineExam.Web.Areas.member.Controllers
{
    [Area("member")]
    [Authorize(Policy = "OrganizationAccess")]
    public class CourseController : Controller
    {
        private readonly OrganizationDbContext _context;
        public CourseController(OrganizationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCourse() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
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
