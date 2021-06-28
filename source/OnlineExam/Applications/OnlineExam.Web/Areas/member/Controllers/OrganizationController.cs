using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace OnlineExam.Web.Areas.member.Controllers
{
    [Area("member")]
    [Authorize(Policy = "OrganizationAccess")]
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
