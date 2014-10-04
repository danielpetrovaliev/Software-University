using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class Student : Person
    {
        public long UniqueClassNumber { get; set; }

        public Student(string name, int age, long uniqueClassNumber, string details = null)
            : base(name, age, details)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }
    }
}
