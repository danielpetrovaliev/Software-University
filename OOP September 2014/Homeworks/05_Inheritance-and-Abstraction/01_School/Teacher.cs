using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class Teacher : Person
    {
        public IList<Discipline> Disciplines { get; set; }

        public Teacher(string name, int age, IList<Discipline> disciplines, string details = null) 
            : base(name, age, details)
        {
            this.Disciplines = disciplines;
        }
    }
}
