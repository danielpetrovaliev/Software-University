namespace MusicSystem.Data
{
    using System;
    using System.Collections.Generic;
    using Models;
    using Repositories;

    public class MusicSystemData : IMusicSystemData
    {
        private IMusicSystemDbContext context;
        private IDictionary<Type, object> repositories; 

        public MusicSystemData(IMusicSystemDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IMusicSystemDbContext Context
        {
            get { return this.context; }
        }

        public IRepository<Artist> Artists
        {
            get { return new GenericRepository<Artist>(this.Context); }
        }

        public IRepository<Song> Songs
        {
            get { return new GenericRepository<Song>(this.Context); }
        }

        public IRepository<Album> Albums
        {
            get { return new GenericRepository<Album>(this.Context); }
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }
    }
}