using System.Collections.Generic;
using StudentSystem.Models;

namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentSystem.Data.StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            var cSharpCourse = new Course
            {
                Name = "C#",
                Description = "Best Course ever.",
                Price = 200.0m,
                StartDate = new DateTime(2014, 02, 02),
                EndDate = new DateTime(2014, 03, 30)
            };

            var peshoStudent = new Student()
            {
                FirstName = "Pesho",
                LastName = "Peshev",
                BirthDay = new DateTime(2000, 01, 01),
                PhoneNumber = "0888888888"
            };

            var homework1 = new Homework()
            {
                Content = "Nothing",
                ContentType = ContentType.Pdf,
                Course = cSharpCourse,
                Student = peshoStudent,
                DeadLine = new DateTime(2015, 03, 30)
            };

            var javaCourse = new Course
            {
                Name = "Java",
                Description = "WTF ?",
                Price = 200.0m,
                StartDate = new DateTime(2014, 02, 02),
                EndDate = new DateTime(2014, 03, 30)
            };

            var goshoStudent = new Student
            {
                FirstName = "Gosho",
                LastName = "Goshev",
                BirthDay = new DateTime(2000, 01, 01),
                PhoneNumber = "0878888888"
            };

            var homework2 = new Homework()
            {
                Content = "Nothing",
                ContentType = ContentType.Pdf,
                Course = javaCourse,
                Student = goshoStudent,
                DeadLine = new DateTime(2015, 03, 30)
            };

            context.Homeworks.Add(homework1);
            context.Homeworks.Add(homework2);
            context.SaveChanges();
        }
    }
}
