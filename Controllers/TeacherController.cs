using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Institute_Project.Models;

namespace Institute_Project.Controllers
{
    public class TeacherController : Controller
    {
        public TeacherController()
        {
        }

        public IActionResult CreateTeacher()
        {
            return View();
        }
        // public IActionResult SaveTeacher(string name, string surname, DateTime birthdate, string email)
        // {
        //     return 
        // }
    }
}