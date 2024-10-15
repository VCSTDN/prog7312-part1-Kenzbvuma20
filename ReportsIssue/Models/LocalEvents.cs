using System;
using System.ComponentModel.DataAnnotations;

namespace ReportsIssue.Models
{
    public class LocalEvent
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        public DateTime EventDate { get; set; }
    }
}
