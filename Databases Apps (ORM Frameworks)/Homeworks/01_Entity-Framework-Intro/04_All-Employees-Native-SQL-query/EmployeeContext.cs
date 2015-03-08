using System;
using System.Collections.Generic;
using System.Linq;
using _01_Create_DbContext_for_the_SoftUni_database;

namespace _04_All_Employees_Native_SQL_query
{
    public class EmployeeContext
    {
        public static void FindEmployeesWithProjects(int projectStartDateYear)
        {
            var softUniEntities = new SoftUniEntities();
            var query = "SELECT [e].[FirstName]" +
                        "FROM Employees [e]" +
                        "JOIN EmployeesProjects [ep]" +
                        "ON [ep].[EmployeeID] = [e].[EmployeeID]" +
                        "JOIN Projects [p]" +
                        "ON [p].[ProjectID] = [ep].[ProjectID]" +
                        "WHERE YEAR([p].[StartDate]) = '2002'" +
                        "GROUP BY [e].[FirstName]" +
                        "ORDER BY [e].[FirstName]";

            var employees = softUniEntities.Database.SqlQuery<Employee>(query).FirstOrDefault();

            Console.WriteLine(employees.FirstName);
        }
    }
}