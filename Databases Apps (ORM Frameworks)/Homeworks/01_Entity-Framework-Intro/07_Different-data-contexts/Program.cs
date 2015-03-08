using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Create_DbContext_for_the_SoftUni_database;

namespace _07_Different_data_contexts
{
    class Program
    {
        static void Main(string[] args)
        {
            var softUniEntities = new SoftUniEntities();
            var concurrencySoftUniEntities = new SoftUniEntities();

            var guy = softUniEntities.Employees.FirstOrDefault(e => e.FirstName == "Roberto");
            var guy2 = concurrencySoftUniEntities.Employees.FirstOrDefault(e => e.FirstName == "Roberto");
            guy.FirstName = "Gosho";
            guy2.FirstName = "Pesho";
            softUniEntities.SaveChanges();
            concurrencySoftUniEntities.SaveChanges();
        }
    }
}
