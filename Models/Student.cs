using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  Institute_Project.Models
{    
    public class Student
    {
        [Key]
        public Guid Id {get; set;}
        [Required]
        public string Name {get ;set;}
        [Required]
        public string Surname {get; set;}
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate {get; set;}
        [Required]
        [MaxLength(10)]
        public int Enrollment {get; set;}
        [Required(ErrorMessage = "Debe ingresar el legajo")]
        public string Email {get; set;}
        // public List<Course> CourseStudent {get; set;}
        public string Location { get; set; }
    }
}

