namespace MusicSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        private ICollection<Artist> artists;

        public Song()
        {
            this.artists = new HashSet<Artist>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime? ReleseDate { get; set; }

        public Genre Genre { get; set; }

        public virtual ICollection<Artist> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
