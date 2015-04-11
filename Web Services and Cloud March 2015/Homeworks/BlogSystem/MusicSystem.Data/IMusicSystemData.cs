namespace MusicSystem.Data
{
    using Models;
    using Repositories;

    public interface IMusicSystemData
    {
        IRepository<Artist> Artists { get; }

        IRepository<Song> Songs { get; }

        IRepository<Album> Albums { get; }

        int SaveChanges();
    }
}