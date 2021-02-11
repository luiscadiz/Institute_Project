using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  Institute_Project.Models
{    
    public class Student
    {
        [Key]
        public Guid ID {get; set;}

        [MaxLength(200)]
        [Required]
        public string Name {get ;set;}

        [MaxLength(200)]
        [Required]
        public string Surname {get; set;}

        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate {get; set;}

        [Required]
        public int Enrollment {get; set;}

        [MaxLength(200)]
        [Required(ErrorMessage = "Debe ingresar el legajo")]
        public string Email {get; set;}
        // public List<Course> CourseStudent {get; set;}

        [MaxLength(200)]
        public string Location { get; set; }
    }
}

