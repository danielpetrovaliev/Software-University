namespace BlogSystem.Services.Models
{
    using System.Linq.Expressions;
    using Antlr.Runtime.Misc;
    using BlogSystem.Models;

    public class UserOutputModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; }

        public static Expression<Func<User, UserOutputModel>> FromUser
        {
            get
            {
                return u => new UserOutputModel
                {
                    Id = u.Id,
                    FullName = u.FullName,
                    Username = u.UserName,
                    Gender = u.Gender.ToString()
                };
            }
        }
    }
}