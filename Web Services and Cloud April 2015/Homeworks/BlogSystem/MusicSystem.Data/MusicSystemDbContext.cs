namespace MusicSystem.Data
{
    using System.Data.Entity;
    using Migrations;
    using Models;

    public class MusicSystemDbContext : DbContext, IMusicSystemDbContext
    {
        public MusicSystemDbContext()
            : base("MusicSystem")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicSystemDbContext, Configuration>());
        }

        public IDbSet<Album> Albums { get; set; }

        public IDbSet<Artist> Artists { get; set; }

        public IDbSet<Song> Songs { get; set; }

        public IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
