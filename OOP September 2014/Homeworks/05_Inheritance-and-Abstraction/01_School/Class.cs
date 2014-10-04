using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_School
{
    public class Class
    {
        public IList<Student> Students { get; set; }
        public IList<Teacher> Teachers { get; set; }
        public string UniqueTextIdentifier { get; set; }
        public string Details { get; set; }

        public Class(IList<Student> students, IList<Teacher> teachers,
            string uniqueTextIdentifier, string details = null)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.Details = details;
        }
    }
}
