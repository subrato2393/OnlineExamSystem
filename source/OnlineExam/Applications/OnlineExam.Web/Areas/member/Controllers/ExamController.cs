using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
