namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;
    using StudentSystem.Models;

    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<StudentSystemDbContext>());

            var studentSystemEntities = new StudentSystemDbContext();

            var newCourse = new Course
            {
                Name = "C#2",
                Description = "C# level 2",
                Price = 300.0m,
                StartDate = new DateTime(2014, 05, 13),
                EndDate = new DateTime(2015, 06, 20)
            };

            newCourse.Materials.Add(new Material
            {
                Name = "Demo for second lection of c# 2 course.",
                Link = "https://www.softuni.bg",
                Type = MaterialType.Demo
            });
            newCourse.Materials.Add(new Material
            {
                Name = "Homework for second lection of c# 2 course.",
                Link = "https://www.softuni.bg",
                Type = MaterialType.Homework
            });

            var newStudent = new Student
            {
                FirstName = "Minka",
                LastName = "Svirkova",
                
            };

            newStudent.Homeworks.Add(new Homework
            {
                Content = "Make Rocket.",
                ContentType = ContentType.Zip,
                DeadLine = new DateTime(2014, 05, 22)
            });
            newStudent.Homeworks.Add(new Homework
            {
                Content = "Your task is to create c# program.",
                ContentType = ContentType.Pdf,
                DeadLine = new DateTime(2014, 04, 22),
                
            });
            newCourse.Students.Add(newStudent);

            studentSystemEntities.Courses.Add(newCourse);
            studentSystemEntities.SaveChanges();


            var students = studentSystemEntities.Students;

            foreach (var student in students)
            {
                Console.WriteLine("Student: " + student.FullName);
                Console.Write(" Homeworks:");

                var currStudentHomeworks = student.Homeworks.ToList();

                foreach (var homework in currStudentHomeworks)
                {
                    Console.Write(" " + homework.Content + ", Content Type: " +
                        homework.ContentType.ToString() + ", Deadline: " +
                        homework.DeadLine.ToShortDateString());
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
