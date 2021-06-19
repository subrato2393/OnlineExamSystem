using Microsoft.AspNetCore.Mvc;


namespace OnlineExam.Web.Areas.member.Controllers
{
    [Area("member")]
    public class OrganizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult AddOrganization()
        {
            return View(); 
        }
    }
}
