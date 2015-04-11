namespace BlogSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using BlogSystem.Models;
    using Data;
    using Microsoft.AspNet.Identity;
    using Models;

    [Authorize]
    [RoutePrefix("api/comments")]
    public class CommentsController : BaseApiController
    {
        protected CommentsController()
            : base(new BlogSystemData(new BlogSystemDbContext()))
        {
        }

        // GET  api/comments/{id}
        [HttpGet]
        public IHttpActionResult GetComment(int id)
        {
            var comment = this.Data.Comments
                .All()
                .Select(c => new CommentOutputModel()
                {
                    Id = c.Id,
                    Content = c.Content,
                    Post = new PostOutputModel
                    {
                        Content = c.Post.Content,
                        Id = c.Post.Id,
                        Tags = c.Post.Tags,
                        Title = c.Post.Title,
                        User = new UserOutputModel
                        {
                            FullName = c.Post.User.FullName,
                            Gender = c.Post.User.Gender.ToString(),
                            Id = c.Post.User.Id,
                            Username = c.Post.User.UserName
                        }
                    },
                    User = new UserOutputModel
                    {
                        FullName = c.User.FullName,
                        Gender = c.User.Gender.ToString(),
                        Id = c.User.Id,
                        Username = c.User.UserName
                    },
                    PostId = c.PostId,
                    UserId = c.UserId
                })
                .FirstOrDefault(c => c.Id == id);

            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment);
        }

        // GET  api/comments
        [HttpGet]
        public IHttpActionResult GetAllComments()
        {
            var comments = this.Data.Comments
                .All()
                .Select(c => new CommentOutputModel()
                {
                    Id = c.Id,
                    Content = c.Content,
                    Post = new PostOutputModel
                    {
                        Content = c.Post.Content,
                        Id = c.Post.Id,
                        Tags = c.Post.Tags,
                        Title = c.Post.Title,
                        User = new UserOutputModel
                        {
                            FullName = c.Post.User.FullName,
                            Gender = c.Post.User.Gender.ToString(),
                            Id = c.Post.User.Id,
                            Username = c.Post.User.UserName
                        }
                    },
                    User = new UserOutputModel
                    {
                        FullName = c.User.FullName,
                        Gender = c.User.Gender.ToString(),
                        Id = c.User.Id,
                        Username = c.User.UserName
                    },
                    PostId = c.PostId,
                    UserId = c.UserId
                });

            return Ok(comments);
        }

        // GET  api/comments?postId={id}
        [HttpGet]
        public IHttpActionResult GetComments([FromUri] int postId)
        {
            var comments = this.Data.Comments
                .All()
                .Where(c => c.PostId == postId)
                .Select(c => new CommentOutputModel()
                {
                    Id = c.Id,
                    Content = c.Content,
                    Post = new PostOutputModel
                    {
                        Content = c.Post.Content,
                        Id = c.Post.Id,
                        Tags = c.Post.Tags,
                        Title = c.Post.Title,
                        User = new UserOutputModel
                        {
                            FullName = c.Post.User.FullName,
                            Gender = c.Post.User.Gender.ToString(),
                            Id = c.Post.User.Id,
                            Username = c.Post.User.UserName
                        }
                    },
                    User = new UserOutputModel
                    {
                        FullName = c.User.FullName,
                        Gender = c.User.Gender.ToString(),
                        Id = c.User.Id,
                        Username = c.User.UserName
                    },
                    PostId = c.PostId,
                    UserId = c.UserId
                });

            return Ok(comments);
        }

        // POST api/comments
        [HttpPost]
        public IHttpActionResult PostComment(Comment comment)
        {
            comment.UserId = this.User.Identity.GetUserId();
            this.Data.Comments.Add(comment);

            this.Data.SaveChanges();

            return Ok(comment);
        }

        // PUT  api/comments
        [HttpPut]
        public IHttpActionResult PutComment(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            // Check Permisions
            if (comment.UserId != this.User.Identity.GetUserId())
            {
                return BadRequest("You do not have permisions to edit comment");
            }

            this.Data.Comments.Update(comment);
            this.Data.SaveChanges();

            return Ok(comment);
        }
    }
}