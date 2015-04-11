namespace BlogSystem.Data
{
    using System.Data.Entity;

    using BlogSystem.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;

    public class BlogSystemDbContext : IdentityDbContext<User>, IBlogSystemDbContext
    {
        public BlogSystemDbContext()
            : base("BlogSystem", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogSystemDbContext, Configuration>());
        }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<Tag> Tags { get; set; }

        public IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public static BlogSystemDbContext Create()
        {
            return new BlogSystemDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Property(u => u.Birthday).HasColumnType("datetime2");
            modelBuilder.Entity<User>().Property(u => u.RegistrationDate).HasColumnType("datetime2");

        }
    }
}
