using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using MusicSystem.Models;

    public class AlbumOutputModel
    {
        private ICollection<SongOutputModel> songs;
        private ICollection<ArtistOutputModel> artists;

        public AlbumOutputModel()
        {
            this.songs = new HashSet<SongOutputModel>();
            this.artists = new HashSet<ArtistOutputModel>();
        }

        public static Expression<Func<Album, AlbumOutputModel>> FromAlbum
        {
            get
            {
                return a => new AlbumOutputModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Producer = a.Producer,
                    Artists = a.Artists.Select(ar => new ArtistOutputModel{Id = ar.Id, Name = ar.Name}).ToList(),
                    Songs = a.Songs.Select(s => new SongOutputModel{AlbumId = s.AlbumId, Genre = s.Genre.ToString(), Id = s.Id, ReleseDate = s.ReleseDate, Title = s.Title}).ToList()
                };
            }
        }

        public int Id { get; set; }

        public string  Title { get; set; }

        public DateTime ReleseDate { get; set; }

        public string Producer { get; set; }

        public virtual ICollection<SongOutputModel> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }

        public virtual ICollection<ArtistOutputModel> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }
    }
}
