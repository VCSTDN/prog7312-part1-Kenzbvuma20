using Microsoft.EntityFrameworkCore;

namespace ReportsIssue.Models

{
    public class ReportsIssueDbContext : DbContext
    {

        public ReportsIssueDbContext(DbContextOptions<ReportsIssueDbContext> options)
        : base(options)
        {

        }
        
        public DbSet<ReportIssueViewModel> ReportIssues { get; set; }
        public DbSet<MediaAttachment> MediaAttachments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportIssueViewModel>()
                .HasOne(r => r.MediaAttachment)
                .WithMany()
                .HasForeignKey(r => r.MediaAttachmentId);
            modelBuilder.Ignore<MainMenuViewModel>();
            modelBuilder.Ignore<MenuItem>();
            

        }




    }
}
