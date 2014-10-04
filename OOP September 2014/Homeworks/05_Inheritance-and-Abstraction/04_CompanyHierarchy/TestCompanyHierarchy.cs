using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy
{
    class TestCompanyHierarchy
    {
        static void Main(string[] args)
        {

            List<Project> softUniProjects = new List<Project>()
            {
                new Project("Judge system", new DateTime(2014, 03, 01), "system for automated testing", State.Closed),
                new Project("Web site", new DateTime(2013, 10, 15), "Software University website", State.Open)
            };

            Employee vladoG = new Developer("Vladimir", "Georgiev", "8802020000", 3000, Department.Production, softUniProjects);
            Employee vladoV = new Developer("Vladislav", "Karamfilov", "8002021420", 3000, Department.Production, softUniProjects);

            List<Sale> sales = new List<Sale>()
            {
                new Sale("First level", new DateTime(2014, 05, 01), 380),
                new Sale("Second level", new DateTime(2014, 09, 05), 380)
            };

            Employee petya = new SalesEmployee("Petya", "Grozdarska", "9001011000", 1500, Department.Marketing, sales);


            Person nakov = new Maneger("Svetlin", "Nakov", "5410060014", 10000, Department.Marketing, new List<Employee>() { vladoG, vladoV, petya });

            Console.WriteLine(nakov);

            Person daniel = new Customer("Daniel", "Petrovaliev", "9500001456", 830);
            Console.WriteLine();
            Console.WriteLine(daniel);
        }
    }
}
