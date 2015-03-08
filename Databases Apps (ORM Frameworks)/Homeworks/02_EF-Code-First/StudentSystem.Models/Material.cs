using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace StudentSystem.Models
{
    public class Material
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public MaterialType Type { get; set; }

        [Required]
        public string Link { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}