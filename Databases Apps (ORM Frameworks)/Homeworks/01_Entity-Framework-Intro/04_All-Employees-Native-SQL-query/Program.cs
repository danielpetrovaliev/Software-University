using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_All_Employees_Native_SQL_query
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeContext.FindEmployeesWithProjects(2002);
        }
    }
}
