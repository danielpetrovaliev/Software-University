using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Animals
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Sharo", 3, Gender.Male),
                new Dog("Lasi", 7, Gender.Female),
                new Dog("Pesho", 4, Gender.Male),
                new Frog("Minka", 1, Gender.Female),
                new Frog("Ginka", 2, Gender.Female),
                new Kitten("Mariika", 1),
                new Kitten("Siska", 2),
                new Tomcat("Tom", 6),
                new Cat("Lasko", 10, Gender.Male),
                new Cat("Genka", 12, Gender.Female)
            };

            // Get average age and group them by type
            var averageAge =
                from animal in animals
                group animal by animal.GetType() into g
                select new { GroupName = g.Key.Name, AverageAge = g.Average(a => a.Age) };

            averageAge.ToList().ForEach(a => Console.WriteLine(a.GroupName + " ----> " + a.AverageAge));
        }
    }
}
