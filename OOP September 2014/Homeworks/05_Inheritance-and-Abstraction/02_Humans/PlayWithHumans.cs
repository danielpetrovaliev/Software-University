using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Humans
{
    public class PlayWithHumans
    {
        static void Main()
        {
            Worker nakov = new Worker("Svetlin", "Nakov", 2000, 8);
            Student student = new Student("Svircho", "Minkov", "14002203");
            
            Console.WriteLine(nakov);
            Console.WriteLine("Money per hour: " + nakov.MoneyPerHour());
            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine();

            List<Student> students = new List<Student>()
            {
                new Student("Svetlin", "Nakov", "14000223"),
                new Student("Svir4o", "Svirkov", "1488988"),
                new Student("Pesho", "Peshev", "14879878"),
                new Student("Man4o", "Man4ev", "141244512"),
                new Student("Kir4o", "Kir4ov", "1423213"),
                new Student("Gosho", "Goshev", "145516714"),
                new Student("Goshko", "Gan4ev", "14548834"),
                new Student("Min4o", "Svirkov", "14127854"),
                new Student("Stoqn", "Ganchev", "140234685"),
                new Student("Karamfil", "Rozev", "14002345")
            };

            Console.WriteLine("Students ordered by factualy number in ascending order: \n");
            students.OrderBy(s => s.FactualyNumber)
                .ToList().ForEach(s => Console.WriteLine(s.ToString()));

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Svetlin", "Nakov", 200000, 24),
                new Worker("Svir4o", "Svirkov", 100, 8),
                new Worker("Pesho", "Peshev", 5000, 8),
                new Worker("Man4o", "Man4ev", 500, 10),
                new Worker("Kir4o", "Kir4ov", 200, 6),
                new Worker("Gosho", "Goshev", 300, 10),
                new Worker("Goshko", "Gan4ev", 1000, 7),
                new Worker("Min4o", "Svirkov", 800, 8),
                new Worker("Stoqn", "Ganchev", 2500, 3),
                new Worker("Karamfil", "Rozev", 3000, 1)
            };

            Console.WriteLine();
            Console.WriteLine("Workers ordered by payment per hour in descending order: \n");
            workers.OrderByDescending(w => w.MoneyPerHour())
                .ToList().ForEach(w => Console.WriteLine(w.ToString()));

            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);

            Console.WriteLine();
            Console.WriteLine("Merged list of students and workers order by first name:s \n");
            mergedList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList()
                .ForEach(h => Console.WriteLine(h.ToString()));
        }
    }
}
