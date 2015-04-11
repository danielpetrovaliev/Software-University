namespace MusicSystem.Services.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using MusicSystem.Models;

    public class SongOutputModel
    {
        private ICollection<Artist> artists;

        public static Expression<Func<Song, SongOutputModel>> FromSong
        {
            get
            {
                return s => new SongOutputModel
                {
                    Id = s.Id,
                    Title = s.Title,
                    ReleseDate = s.ReleseDate,
                    Genre = s.Genre.ToString(),
                    Album = new AlbumOutputModel
                    {
                        Id = s.AlbumId,
                        Producer = s.Album.Producer,
                        Title = s.Album.Title
                    }
                };
            }
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime? ReleseDate { get; set; }

        public string Genre { get; set; }

        public virtual ICollection<Artist> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }

        public int AlbumId { get; set; }

        public virtual AlbumOutputModel Album { get; set; }
    }
}