using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Create_database_UsersGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try to start two times
            CreateAdminUser("Pesho");
        }

        public static void CreateAdminUser(string nameOfUser)
        {
            using (var usersGroupsEntities = new UsersGroupsEntities())
            {
                using (var dbContextTransaction = usersGroupsEntities.Database.BeginTransaction())
                {
                    try
                    {
                        var adminGroupId = 0;

                        if (!usersGroupsEntities.Groups.Any(g => g.Name == "Admins"))
                        {
                            var adminGroup = new Group {Name = "Admins"};
                            usersGroupsEntities.Groups.Add(adminGroup);
                            usersGroupsEntities.SaveChanges();
                            adminGroupId = adminGroup.Id;
                        }
                        else
                        {
                            adminGroupId = usersGroupsEntities.Groups.First(g => g.Name == "Admins").Id;
                        }

                        var user = new User
                        {
                            Name = nameOfUser,
                            GroupId = adminGroupId
                        };

                        usersGroupsEntities.Users.Add(user);
                        usersGroupsEntities.SaveChanges();

                        dbContextTransaction.Commit();
                        Console.WriteLine("User: " + nameOfUser + " successfuly added to 'users' and 'Admins' group.");
                    }
                    catch (Exception e)
                    {
                        dbContextTransaction.Rollback();
                        Console.WriteLine("User has not been added. See exception: \n " + e.Message);
                    }
                }
            }
        }
    }
}
