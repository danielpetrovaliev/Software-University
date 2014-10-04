using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class School
    {
        public IList<Class> Classes { get; set; }

        public School(IList<Class> classes)
        {
            this.Classes = classes;
        }
    }
}
