using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using _01_Create_DbContext_for_the_SoftUni_database;

namespace _09_Add_new_Project_with_Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var softUniEntities = new SoftUniEntities())
            {
                using (var dbContextTransaction = softUniEntities.Database.BeginTransaction())
                {
                    try
                    {
                        var employees = new List<Employee>
                        {

                            new Employee
                            {
                                FirstName = "Gosho",
                                Address = new Address
                                {
                                    AddressText = "str. Georgi rakovski 21",
                                    Town = new Town
                                    {
                                        Name = "Kaspichan2"
                                    }
                                },
                                LastName = "Goshev",
                                MiddleName = "Goshev",
                                DepartmentID = softUniEntities
                                    .Departments
                                    .FirstOrDefault(d => d.Name == "Engineering")
                                    .DepartmentID,
                                JobTitle = "Momche za vsichko",
                                HireDate = DateTime.Now
                            }
                        };

                        var project = new Project
                        {
                            // Uncomment this to add project to database.
                            // Name = "Test Project",
                            Description = "My best project",
                            Employees = employees,
                            StartDate = DateTime.Now
                        };

                        softUniEntities.Projects.Add(project);

                        softUniEntities.SaveChanges();
                        dbContextTransaction.Commit();
                        Console.WriteLine("Project has been added to database.");
                    }
                    catch (Exception e)
                    {
                        dbContextTransaction.Rollback();
                        Console.WriteLine("Project is not added to database. See Exception: \n "  + e.Message);
                    }

                }
            }
        }
    }
}
