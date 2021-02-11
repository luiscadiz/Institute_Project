using System;
using System.ComponentModel.DataAnnotations;

namespace Institute_Project.Models
{
    public class Course
    {
        [Key]
        public Guid Id {get; set;}
        public string NameSubject {get; set;} 
    }
}