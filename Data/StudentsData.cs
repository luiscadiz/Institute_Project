using System;
using System.Collections.Generic;
using Institute_Project.Models;
using System.Threading.Tasks;
using System.Linq;

namespace Institute_Project.Data
{
    public class StudentsData
    {
        public List<Student> Data = new List<Student>();

        public StudentsData()
        {
            Data.Add(new Student() {ID = Guid.Parse("e4bf0aba-649e-4874-bd72-f5824fc03924"), Name = "Luis", Surname ="Cadiz", BirthDate = new DateTime(1994,4,15), Enrollment = 1111, Email = "example@gmail.com"});
            Data.Add(new Student() {ID = Guid.Parse("78364d70-4444-4739-9946-0a8475a49a40"), Name = "Carlos", Surname ="Cadiz", BirthDate = new DateTime(1999,9,21), Enrollment = 2222, Email = "example@gmail.com"});
            Data.Add(new Student() {ID = Guid.Parse("f6457e81-1c18-4374-a3ee-36a262d6f269"), Name = "Milton", Surname ="Cadiz", BirthDate = new DateTime(2001,9,3), Enrollment = 3333, Email = "example@gmail.com"});
            Data.Add(new Student() {ID = Guid.Parse("24dd0462-58ee-4717-b416-b610165929c2"), Name = "Melanie", Surname ="Cadiz", BirthDate = new DateTime(2005,4,15), Enrollment = 4444, Email = "example@gmail.com"});
            // Data.Add(new Student() {Id = Guid.Parse("f4bf0aba-649e-4474-bd72-f5824fc03924"), Name = "Camila", Surname ="Cadiz", BirthDate = new DateTime(2009,11,10), Enrollment = 555, Email = "example@gmail.com"});
        }
    }
}