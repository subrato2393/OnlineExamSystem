using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineExam.Web.Areas.member.Controllers
{
    [Area("member")]
    [Authorize(Policy = "OrganizationAccess")]
    public class BatchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 

        public IActionResult AddBatch()
        {
            return View();
        }

        public IActionResult EditBatch()
        {
            return View();
        }

        public IActionResult AssignTrainers()
        {
            return View();
        }
    }
}
