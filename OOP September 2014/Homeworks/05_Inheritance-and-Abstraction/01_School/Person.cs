using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Details { get; set; }

        public Person(string name, int age, string details = null)
        {
            this.Name = name;
            this.Age = age;
            this.Details = details;
        }
    }
}
