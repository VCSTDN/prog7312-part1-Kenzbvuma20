using System.ComponentModel.DataAnnotations;

namespace ReportsIssue.Models
{
    public class MediaAttachment
    {
        [Key]
        public int MediaAttachmentId { get; set; }
        public string? FilePath { get; set; }


    }
}
