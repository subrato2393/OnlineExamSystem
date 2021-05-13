using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
