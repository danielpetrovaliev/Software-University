namespace BlogSystem.Data.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<BlogSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BlogSystemDbContext context)
        {
            ////  This method will be called after migrating to the latest version
            ////  You can use the DbSet<T>.AddOrUpdate() helper extension method to avoid creating duplicate seed data.
        }
    }
}
