using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class TestSchool
    {
        static void Main(string[] args)
        {
            Student dani = new Student("Daniel", 19, 1233654789, "ambicious");
            Student vili = new Student("Vili", 19, 12323141231);

            IList<Student> students = new List<Student>() { dani, vili };

            Discipline math = new Discipline("mathemarics", 15, students, "hard...");

            Teacher minkova = new Teacher("Minkova", 45, new List<Discipline>() { math }, "very bad");

            Class september = new Class(students, new List<Teacher>() { minkova }, "September #2");

            School softUni = new School(new List<Class>() { september });

        }
    }
}
