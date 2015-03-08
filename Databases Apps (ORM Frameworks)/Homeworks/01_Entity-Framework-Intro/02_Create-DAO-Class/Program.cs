using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Create_DAO_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateReadUpdateDelete.InsertTown("Geto");

            CreateReadUpdateDelete.ChangeTownName(34, "Bangladesh");

            var townByName = CreateReadUpdateDelete.GetTownByName("Sofia");
            Console.WriteLine(townByName.Name);

            CreateReadUpdateDelete.RemoveTown(33);
        }
    }
}
