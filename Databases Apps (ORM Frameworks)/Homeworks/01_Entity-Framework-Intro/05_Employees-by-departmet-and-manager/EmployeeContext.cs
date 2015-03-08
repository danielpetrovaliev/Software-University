using System;
using System.Linq;

namespace _05_Employees_by_departmet_and_manager
{
    using _01_Create_DbContext_for_the_SoftUni_database;

    public class EmployeeContext
    {
        public static void FindEmployeesByDepartmentAndManager(string departmentName, string managerFirstName, string managerLastName)
        {
            using (var softUniEntities = new SoftUniEntities())
            {
                var manager = softUniEntities
                    .Employees
                    .FirstOrDefault(e =>
                        e.FirstName == managerFirstName || e.LastName == managerLastName
                    );
                var employeeByDepartmentAndManager =
                    softUniEntities
                        .Employees
                        .FirstOrDefault(e =>
                            e.Department.Name == departmentName || e.ManagerID == manager.EmployeeID
                        );
                Console.WriteLine("Employee is " + employeeByDepartmentAndManager.FirstName + " " + employeeByDepartmentAndManager.LastName);
            }
        }
    }
}