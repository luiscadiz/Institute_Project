using System;
using System.Collections.Generic;

namespace  Institute_Project.Models
{    
    public class Student
    {
        public Guid Id {get; set;}
        public string Name {get ;set;}
        public string Surname {get; set;}
        public int Dni {get; set;}
        public DateTime BirthDate {get; set;}
        public string Address {get; set;}
        public string Phone {get; set;}
        public int EnrollmentNumber {get; set;}
        public string Email {get; set;}
        public List<Course> CourseStudent {get; set;}
    }
}

