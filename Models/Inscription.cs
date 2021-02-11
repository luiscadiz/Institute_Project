using System;
using System.ComponentModel.DataAnnotations;

namespace Institute_Project.Models
{
    public class Inscription
    {
        [Key]
        public Guid ID {get; set;}

        public Course Course{get; set;}
        public Student Student {get; set;}
    }
}