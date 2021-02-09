using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Institute_Project.Models;

namespace Institute_Project.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult CreateStudent()
        {
            return View();
        }

        public IActionResult SaveStudent(string name, string surname, DateTime birthdate, int enrollmentnumber, string email)
        {
            Student newStudent = new Student();
            newStudent.Name = name;
            newStudent.Surname = surname;
            newStudent.BirthDate = birthdate;
            newStudent.EnrollmentNumber = enrollmentnumber;
            newStudent.Email = email;

            return View(newStudent);

        }
    }
}