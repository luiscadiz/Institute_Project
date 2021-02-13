using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  Institute_Project.Models
{    
    public class Teacher
    {
        [Key]
        public Guid ID {get; set;}

        [MaxLength(200)]
        public string Name {get ;set;}

        [MaxLength(200)]
        public string Surname {get; set;}
        public int Dni {get; set;}
        public DateTime BirthDate {get; set;}
        [MaxLength(200)]
        public string Address {get; set;}

        [MaxLength(50)]
        public string Phone {get; set;}

        [MaxLength(200)]
        public string Email {get; set;}
        // public List<Course> Courses {get; set;}
    }
}



