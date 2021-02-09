using System;
using System.Collections.Generic;


namespace  Institute_Project.Models
{    
    public class Teacher
    {
        public Guid Id {get; set;}
        public string Name {get ;set;}
        public string Surname {get; set;}
        public int Dni {get; set;}
        public DateTime BirthDate {get; set;}
        public string Address {get; set;}
        public string Phone {get; set;}
        public string Email {get; set;}
        public List<Course> Courses {get; set;}
    }
}



