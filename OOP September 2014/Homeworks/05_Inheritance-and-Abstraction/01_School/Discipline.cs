using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_School
{
    public class Discipline
    {
        public string Name { get; set; }
        public int NumberOfDisciplines { get; set; }
        public IList<Student> Students { get; set; }
        public string Details { get; set; }

        public Discipline(string name, int numberOfDisciplines, IList<Student> students,
            string details)
        {
            this.Name = name;
            this.NumberOfDisciplines = numberOfDisciplines;
            this.Students = students;
            this.Details = details;
        }
    }
}
