namespace MusicSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using MusicSystem.Models;

    [RoutePrefix("api/albums")]
    public class AlbumsController : BaseApiController
    {
        protected AlbumsController()
            : base(new MusicSystemData(new MusicSystemDbContext()))
        {
        }

        public IHttpActionResult Get()
        {
            return Ok(this.Data.Albums.All().Select(AlbumOutputModel.FromAlbum));
        }

        public IHttpActionResult Get(int id)
        {
            var album = this.Data.Albums.All().Where(a => a.Id == id).Select(AlbumOutputModel.FromAlbum);

            if (album == null)
            {
                return NotFound();
            }

            return Ok(album);
        }

        public IHttpActionResult Post(Album album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            this.Data.Albums.Add(album);
            this.Data.SaveChanges();

            return Ok(album);
        }

        public IHttpActionResult Put(int id, Album album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var albumFromDb = this.Data.Albums.GetById(id);
            albumFromDb = album;

            this.Data.Albums.Update(albumFromDb);
            this.Data.SaveChanges();

            return Ok(album);
        }

        public IHttpActionResult Delete(int id)
        {
            var album = this.Data.Albums.GetById(id);

            this.Data.Albums.Delete(album);
            this.Data.SaveChanges();

            return Ok();
        }
    }
}