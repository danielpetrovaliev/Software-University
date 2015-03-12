namespace News.Data
{
    using System.Data.Entity;

    using Models;

    public class NewsDbContext : DbContext
    {
        public NewsDbContext()
            :base("News")
        {
            
        }

        public IDbSet<News> News { get; set; }
    }
}
