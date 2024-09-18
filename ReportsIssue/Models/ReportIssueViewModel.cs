using System.ComponentModel.DataAnnotations;

namespace ReportsIssue.Models
{
    public class ReportIssueViewModel
    {
        [Key]
        public int ReportsIssueId { get; set; }

        public string? Location { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public int MediaAttachmentId { get; set; } 
        public MediaAttachment? MediaAttachment { get; set; }
        public string? MediaAttachmentFilePath { get; set; }

        public int Progress { get; set; }


    }
}
