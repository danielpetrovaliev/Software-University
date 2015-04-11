namespace BlogSystem.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using BlogSystem.Models;

    public class TagOutputModel
    {
        public TagOutputModel()
        {
            this.Posts = new HashSet<PostOutputModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<PostOutputModel> Posts { get; set; }

        public static Expression<Func<Tag, TagOutputModel>> FromTag
        {
            get
            {
                return t => new TagOutputModel
                {
                    Id = t.Id,
                    Name = t.Name
                };
            }
        }
    }
}