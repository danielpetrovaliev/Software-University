namespace MusicSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using MusicSystem.Models;

    [RoutePrefix("api/Songs")]
    public class SongsController : BaseApiController
    {
        protected SongsController() 
            : base(new MusicSystemData(new MusicSystemDbContext()))
        {
        }

        public IHttpActionResult Get()
        {
            var songs = this.Data.Songs.All().Select(SongOutputModel.FromSong);
            return Ok(songs);
        }

        public IHttpActionResult Get(int id)
        {
            var song = this.Data.Songs.GetById(id);
            
            if (song == null)
            {
                return NotFound();
            }

            return Ok(song);
        }

        public IHttpActionResult Post(Song song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            this.Data.Songs.Add(song);
            this.Data.SaveChanges();

            return Ok(song);
        }

        public IHttpActionResult Put(int id, Song song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var songFromDb = this.Data.Songs.GetById(id);
            songFromDb = song;

            this.Data.Songs.Update(songFromDb);
            this.Data.SaveChanges();

            return Ok(song);
        }

        public IHttpActionResult Delete(int id)
        {
            var song = this.Data.Songs.GetById(id);

            if (song == null)
            {
                return BadRequest();
            }

            this.Data.Songs.Delete(song);
            this.Data.SaveChanges();

            return Ok();
        }
    }
}