namespace BlogSystem.Services.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using BlogSystem.Models;

    public class PostOutputModel
    {
        public PostOutputModel()
        {
            this.Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public string UserId { get; set; }

        public UserOutputModel User { get; set; }

        public static Expression<Func<Post, PostOutputModel>> FromPost
        {
            get
            {
                return p => new PostOutputModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                    Tags = p.Tags,
                    User =
                        new UserOutputModel
                        {
                            FullName = p.User.FullName,
                            Gender = p.User.Gender.ToString(),
                            Id = p.User.Id,
                            Username = p.User.UserName
                        }
                };
            }
        }
    }
}