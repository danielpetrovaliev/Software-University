using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Create_DbContext_for_the_SoftUni_database;

namespace _10_Stored_Procedure_in_SoftUni_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Before executing this code you must create stored procedure in sql server and update Entities model in my first project.
            // You can find DDL for creating stored procedure in homework folder.

            using (var softUniEntities = new SoftUniEntities())
            {
                var count = softUniEntities.usp_FindTotalProjectsForEmployee("Rob", "Walters").FirstOrDefault();
                Console.WriteLine("Projects count: " + count);
            }
        }
    }
}
