namespace BlogSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using BlogSystem.Models;
    using Data;
    using Models;

    [RoutePrefix("api/tags")]
    public class TagsController : BaseApiController
    {
        protected TagsController() 
            : base(new BlogSystemData(new BlogSystemDbContext()))
        {
        }

        // GET  api/tags
        [HttpGet]
        public IHttpActionResult GetTags()
        {
            var tags = this.Data.Tags
                .All()
                .Select(TagOutputModel.FromTag);

            return Ok(tags);
        }

        // GET  api/tags/{id}
        [HttpGet]
        public IHttpActionResult GetTags(int id)
        {
            var tags = this.Data.Tags
                .All()
                .Where(t => t.Id == id)
                .Select(TagOutputModel.FromTag);

            return Ok(tags);
        }

        // POST api/tags
        [HttpPost]
        public IHttpActionResult PostTag(Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            this.Data.Tags.Add(tag);
            this.Data.SaveChanges();

            return Ok(tag);
        }

        // PUT  api/tags
        [HttpPut]
        public IHttpActionResult PutTag(Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            this.Data.Tags.Update(tag);
            this.Data.SaveChanges();

            return Ok(tag);
        }
    }
}