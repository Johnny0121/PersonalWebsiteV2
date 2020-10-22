using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsiteV2.Controllers
{
    public class AcademicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Year4()
        {
            return View();
        }
    }
}
