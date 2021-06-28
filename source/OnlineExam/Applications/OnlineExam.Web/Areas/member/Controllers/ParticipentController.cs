using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace OnlineExam.Web.Areas.member.Controllers
{
    [Area("member")]
    [Authorize(Policy = "OrganizationAccess")]
    public class ParticipentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddParticipent()
        {
            return View();
        }

        public IActionResult AssignParticipents() 
        {
            return View();
        }

    }
}
