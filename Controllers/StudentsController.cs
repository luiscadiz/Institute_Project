using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Institute_Project.Models;
using Microsoft.AspNetCore.Http;
using Institute_Project.Data;

namespace Institute_Project.Controllers
{
    public class StudentsController : Controller
    {
        private StudentsData studentData;

        public StudentsController(){ }

        public IActionResult Index()
        {
            return View(studentData.Data);
        }
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveStudent([Bind("Name,Surname,BirthDate,Enrollment,Email")] Student student)
        {
            student.Id = Guid.NewGuid();
            return View("Details", student);
        }


        public IActionResult Edit(Guid id)
        {
            Student EditStudent = studentData.Data.Find(c => c.Id == id);
            return View(EditStudent);
        }

        [HttpPost]
        public IActionResult Edit([Bind("Name,Surname,BirthDate,Enrollment,Email")] Student newStudent)
        {
            return View("Details", newStudent);
        }
    }
}