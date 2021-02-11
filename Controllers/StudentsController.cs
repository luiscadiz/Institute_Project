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
        private InstituteContext _Context;

        public StudentsController(InstituteContext context)
        {
            _Context = context;
        }

        public IActionResult Index() 
        {
            IEnumerable<Student> students = _Context.Students;
            return View(students);
        }
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveStudent([Bind("Name,Surname,BirthDate,Enrollment,Email")] Student student)
        {
            student.ID = Guid.NewGuid();
            _Context.Students.Add(student);
            _Context.SaveChanges();
            return View("Details", student);
        }


        public IActionResult Edit(Guid id)
        {
            Student EditStudent = _Context.Students.Find(id);
            // Student EditStudent = studentData.Data.Find(c => c.ID == id);
            return View(EditStudent);
        }

        [HttpPost]
        public IActionResult Edit([Bind("ID,Name,Surname,BirthDate,Enrollment,Email")] Student newStudent)
        {
            _Context.Students.Update(newStudent);
            _Context.SaveChanges();
            return View("Details", newStudent);
        }
    }
}