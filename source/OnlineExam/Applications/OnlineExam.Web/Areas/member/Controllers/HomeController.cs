using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Web.Areas.member.Controllers
{
    public class HomeController : Controller
    {
        [Area("member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
