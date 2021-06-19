using Microsoft.AspNetCore.Mvc;


namespace OnlineExam.Web.Areas.member.Controllers
{
    [Area("member")]
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateExam()
        {
            return View();
        }
    }
}
