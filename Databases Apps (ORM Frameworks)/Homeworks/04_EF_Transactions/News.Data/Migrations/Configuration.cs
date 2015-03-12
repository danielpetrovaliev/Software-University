namespace News.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<NewsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(NewsDbContext context)
        {
            // Remove all 

            context.News.AddOrUpdate(new News()
            {
                Content = "JavaScript is the best"
            });
            context.News.AddOrUpdate(new News()
            {
                Content = "12333"
            });
            context.News.AddOrUpdate(new News()
            {
                Content = "asdasdasdasd"
            });
            context.News.AddOrUpdate(new News()
            {
                Content = "What is EF?"
            });
        }
    }
}
