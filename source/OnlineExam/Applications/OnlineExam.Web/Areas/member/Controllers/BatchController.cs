using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Web.Areas.member.Controllers
{
    [Area("member")]
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
