namespace BlogSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
