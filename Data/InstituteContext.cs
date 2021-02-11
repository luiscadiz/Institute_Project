using System;
using Institute_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Institute_Project.Data
{
    public class InstituteContext : DbContext
    {

        //Dudaaa
        public InstituteContext(DbContextOptions<InstituteContext> options) 
            : base(options) { 

            }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=DESKTOP-E6E1U8H;Initial Catalog=Institute_Project;User ID=sa;Password=1969Arpanet");
        public DbSet<Student> Students {get; set;}
        public DbSet<Teacher> Teachers {get; set;}
        public DbSet<Course> Courses {get; set;}
        public DbSet<Inscription> Inscriptions {get; set;}
    }
    
}
