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
        public DbSet<LocalEvent> LocalEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportIssueViewModel>()
                .HasOne(r => r.MediaAttachment)
                .WithMany()
                .HasForeignKey(r => r.MediaAttachmentId);

            modelBuilder.Ignore<MainMenuViewModel>();
            modelBuilder.Ignore<MenuItem>();

            // Seed data for LocalEvent
            modelBuilder.Entity<LocalEvent>().HasData(
                new LocalEvent
                {
                    EventId = 1,
                    Title = "Community Cleanup",
                    Description = "Join us to clean up the local park.",
                    Category = "Roads",
                    EventDate = DateTime.Now.AddDays(5)
                },
                new LocalEvent
                {
                    EventId = 2,
                    Title = "Tech Talk",
                    Description = "A talk on the latest trends in technology.",
                    Category = "Other",
                    EventDate = DateTime.Now.AddDays(10)
                },
                new LocalEvent
                {
                    EventId = 3,
                    Title = "Health and Wellness Fair",
                    Description = "Discover tips and resources for a healthier lifestyle.",
                    Category = "Sanitation",
                    EventDate = DateTime.Now.AddDays(15)
                },
                new LocalEvent
                {
                    EventId = 4,
                    Title = "Community Cleanup Day",
                    Description = "Join your neighbors to clean up local parks and streets.",
                    Category = "Sanitation",
                    EventDate = DateTime.Now.AddDays(10)
                },
                new LocalEvent
                {
                    EventId = 5,
                    Title = "Public Road Safety Forum",
                    Description = "A discussion on improving road safety and addressing local concerns.",
                    Category = "Roads",
                    EventDate = DateTime.Now.AddDays(20)
                },
                new LocalEvent
                {
                    EventId = 6,
                    Title = "Tree Planting Drive",
                    Description = "Help us plant trees to improve the local environment.",
                    Category = "Environment",
                    EventDate = DateTime.Now.AddDays(12)
                },
                new LocalEvent
                {
                    EventId = 7,
                    Title = "Neighborhood Watch Meeting",
                    Description = "Discuss safety measures to improve public safety in your area.",
                    Category = "Public Safety",
                    EventDate = DateTime.Now.AddDays(5)
                },
                new LocalEvent
                {
                    EventId = 8,
                    Title = "Accessibility Awareness Workshop",
                    Description = "Learn about accessibility issues and how to support an inclusive community.",
                    Category = "Accessibility",
                    EventDate = DateTime.Now.AddDays(18)
                },
                new LocalEvent
                {
                    EventId = 9,
                    Title = "Energy Efficiency Seminar",
                    Description = "Learn tips to reduce your energy consumption and save on bills.",
                    Category = "Utilities and Energy",
                    EventDate = DateTime.Now.AddDays(7)
                },
                new LocalEvent
                {
                    EventId = 10,
                    Title = "Local Housing Development Discussion",
                    Description = "Join the discussion on future housing developments in the community.",
                    Category = "Housing and Buildings",
                    EventDate = DateTime.Now.AddDays(22)
                },
                new LocalEvent
                {
                    EventId = 11,
                    Title = "Public Transport Improvements Feedback",
                    Description = "Provide your feedback on proposed changes to local bus and train routes.",
                    Category = "Traffic and Transportation",
                    EventDate = DateTime.Now.AddDays(9)
                },
                new LocalEvent
                {
                    EventId = 12,
                    Title = "Park Renovation Planning",
                    Description = "Help plan the renovation of our local park facilities.",
                    Category = "Parks and Recreation",
                    EventDate = DateTime.Now.AddDays(11)
                },
                new LocalEvent
                {
                    EventId = 13,
                    Title = "Noise Reduction Initiative Meeting",
                    Description = "Discuss ways to reduce noise pollution in residential areas.",
                    Category = "Noise",
                    EventDate = DateTime.Now.AddDays(16)
                },
                new LocalEvent
                {
                    EventId = 14,
                    Title = "Stray Animal Adoption Day",
                    Description = "Come and adopt a pet while helping to control the stray animal population.",
                    Category = "Animal Control",
                    EventDate = DateTime.Now.AddDays(14)
                },
                new LocalEvent
                {
                    EventId = 15,
                    Title = "School Improvement Forum",
                    Description = "A forum to discuss improvements in local educational facilities and programs.",
                    Category = "Education",
                    EventDate = DateTime.Now.AddDays(8)
                }
            );
        }
    }
}

