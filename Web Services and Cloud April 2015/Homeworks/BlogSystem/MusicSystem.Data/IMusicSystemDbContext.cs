namespace MusicSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public interface IMusicSystemDbContext
    {
        IDbSet<Album> Albums { get; set; }

        IDbSet<Artist> Artists { get; set; }

        IDbSet<Song> Songs { get; set; }

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class; 
    }
}