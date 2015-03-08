using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Scaffolding.EntityFramework;
using _01_Create_DbContext_for_the_SoftUni_database;

namespace _03_Write_a_method_that_find_employees
{
    public class EmployeeContext
    {
        public static void FindEmployeesWithProjects(int projectStartDateYear)
        {
            var softUniEntities = new SoftUniEntities();

            var employees = softUniEntities.Employees
                .Where(e => e.Projects
                    .Any(p => p.StartDate.Year == projectStartDateYear))
                    .OrderBy(e => e.FirstName)
                    .ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + ": ");
                foreach (var project in employee.Projects)
                {
                    Console.WriteLine(" Project: " + project.Name + " " + project.StartDate.ToString("dd-MM-yyyy"));
                }
                Console.WriteLine();
            }
        }
    }
}