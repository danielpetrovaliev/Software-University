using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Employees_by_departmet_and_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeContext.FindEmployeesByDepartmentAndManager("Tool Designer", "Ovidiu", "Cracium");
        }
    }
}
