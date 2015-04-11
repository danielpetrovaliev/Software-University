namespace BlogSystem.Services.Models
{
    using System.Linq.Expressions;
    using Antlr.Runtime.Misc;
    using BlogSystem.Models;

    public class CommentOutputModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual UserOutputModel User { get; set; }

        public int PostId { get; set; }

        public virtual PostOutputModel Post { get; set; }

        public static Expression<Func<Comment, CommentOutputModel>> FromComment
        {
            get
            {
                return c => new CommentOutputModel()
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
                };
            }
        }
    }
}