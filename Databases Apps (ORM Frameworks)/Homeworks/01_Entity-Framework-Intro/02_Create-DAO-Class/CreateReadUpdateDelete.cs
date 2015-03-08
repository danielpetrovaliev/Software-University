using System;
using System.Linq;
using _01_Create_DbContext_for_the_SoftUni_database;

namespace _02_Create_DAO_Class
{
    public class CreateReadUpdateDelete
    {
        public static int InsertTown(string name)
        {
            var softuniEntities = new SoftUniEntities();
            var town = new Town
            {
                Name = name
            };

            softuniEntities.Towns.Add(town);
            softuniEntities.SaveChanges();
            Console.WriteLine("Town " + name + " inserted!");

            return town.TownID;
        }

        public static void ChangeTownName(int townId, string newTownName)
        {
            var sofUniEntities = new SoftUniEntities();
            var town = sofUniEntities.Towns.Find(townId);
            var oldTownName = town.Name;

            town.Name = newTownName;
            sofUniEntities.SaveChanges();

            Console.WriteLine(oldTownName + " now is: " + town.Name);
        }

        public static void RemoveTown(int townId)
        {
            var softUniEntities = new SoftUniEntities();
            var town = softUniEntities.Towns.Find(townId);
            var removedTownName = town.Name;

            softUniEntities.Towns.Remove(town);
            softUniEntities.SaveChanges();

            Console.WriteLine(removedTownName + " is removed!");
        }

        public static Town GetTownByName(string townName)
        {
            var softUniEntities = new SoftUniEntities();

            return softUniEntities.Towns.FirstOrDefault(t => t.Name == townName);
        }
    }
}