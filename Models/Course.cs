using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Institute_Project.Models
{
    public class Course
    {
        [Key]
        public Guid ID {get; set;}
        [MaxLength(200)]
        public string Subject {get; set;} 
        public Teacher Teacher {get; set;}

        public List<Inscription> Inscriptions {get; set;}
    }
}