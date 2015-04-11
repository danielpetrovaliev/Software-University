namespace BlogSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using BlogSystem.Models;
    using Data;
    using Microsoft.AspNet.Identity;
    using Models;

    [Authorize]
    [RoutePrefix("api/posts")]
    public class PostsController : BaseApiController
    {
        protected PostsController()
            : base(new BlogSystemData(new BlogSystemDbContext()))
        {
        }

        [HttpGet]
        public IHttpActionResult GetPost(int id)
        {
            var post = this.Data.Posts
                .All()
                .Select(PostOutputModel.FromPost)
                .FirstOrDefault(p => p.Id == id);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        [HttpGet]
        public IHttpActionResult GetAllPosts()
        {
            var posts = this.Data.Posts.All().Select(PostOutputModel.FromPost);

            return Ok(posts);
        }

        [HttpPost]
        public IHttpActionResult CreatePost(Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            post.UserId = this.User.Identity.GetUserId();

            this.Data.Posts.Add(post);
            this.Data.SaveChanges();

            return Created("api/posts/" + post.Id, post);
        }

        [HttpPut]
        public IHttpActionResult UpdatePost(Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            this.Data.Posts.Update(post);
            this.Data.SaveChanges();

            return Ok(post.Id);
        }

        [HttpDelete]
        public IHttpActionResult DeletePost(int id)
        {
            var post = this.Data.Posts.GetById(id);

            if (post == null)
            {
                return NotFound();
            }

            if (post.User.Id != this.User.Identity.GetUserId())
            {
                return BadRequest("You have not permision to delete this post.");
            }

            this.Data.Posts.Delete(post);
            this.Data.SaveChanges();

            return Ok();
        }


    }
}