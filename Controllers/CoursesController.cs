using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Institute_Project.Models;

namespace Institute_Project.Controllers
{
    public class CoursesController : Controller
    {
        public CoursesController()
        {
        }

        public IActionResult CreateCourse()
        {
            return View();
        }
    }
}