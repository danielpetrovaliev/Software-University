using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace StudentSystem.Models
{
    public class Homework
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public ContentType ContentType { get; set; }

        [Required]
        public DateTime DeadLine { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
