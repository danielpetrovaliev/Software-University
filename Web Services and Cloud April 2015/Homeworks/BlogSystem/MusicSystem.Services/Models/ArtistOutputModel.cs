using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicSystem.Services.Models
{
    using System.Linq.Expressions;
    using MusicSystem.Models;

    public class ArtistOutputModel
    {
        private ICollection<AlbumOutputModel> albums;
        private ICollection<SongOutputModel> songs;

        public static Expression<Func<Artist, ArtistOutputModel>> FromArtist
        {
            get
            {
                return a => new ArtistOutputModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    Albums = a.Albums.Select(al => new AlbumOutputModel{Id = al.Id, Producer = al.Producer, Title = al.Title}).ToList(),
                    Songs = a.Songs.Select(s => new SongOutputModel { AlbumId = s.AlbumId, Genre = s.Genre.ToString(), Id = s.Id, ReleseDate = s.ReleseDate, Title = s.Title }).ToList(),
                    BirthDate = a.BirthDate,
                    Country = a.Country
                };
            }
        }

        public ArtistOutputModel()
        {
            this.albums = new HashSet<AlbumOutputModel>();
            this.songs = new HashSet<SongOutputModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ICollection<AlbumOutputModel> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }

        public virtual ICollection<SongOutputModel> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }
    }
}
