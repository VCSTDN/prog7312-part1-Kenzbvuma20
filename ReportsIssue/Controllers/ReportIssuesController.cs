using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using ReportsIssue.Models;
using System;

namespace ReportsIssue.Controllers
{
    public class ReportIssuesController : Controller
    {


        private readonly ReportsIssueDbContext _dbContext;

        private readonly INotyfService _notificationService;

        public ReportIssuesController(DbContextOptions<ReportsIssueDbContext> dbContextOptions, INotyfService notificationService)
        {
            _dbContext = new ReportsIssueDbContext(dbContextOptions);
            _notificationService = notificationService;
        }

       

        public IActionResult Index()
        {
            var reportIssues = _dbContext.ReportIssues.ToList();
            return View(reportIssues);
        }



        [HttpPost]
        public IActionResult Create(ReportIssueViewModel model, IFormFile? mediaAttachment)
        {
            if (ModelState.IsValid)
            {
                // Update progress bar
               

                if (mediaAttachment != null && mediaAttachment.Length > 0)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", mediaAttachment.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        mediaAttachment.CopyTo(stream);
                    }



                    var mediaAttachmentEntity = new MediaAttachment { FilePath = mediaAttachment.FileName };
                    _dbContext.MediaAttachments.Add(mediaAttachmentEntity);
                    _dbContext.SaveChanges(); // Save the media attachment entity first
                    model.MediaAttachmentId = mediaAttachmentEntity.MediaAttachmentId; // Set the MediaAttachmentId property
                    model.MediaAttachmentFilePath = mediaAttachment.FileName; // Set the MediaAttachmentFilePath property
                    model.MediaAttachment = new MediaAttachment { FilePath = mediaAttachment.FileName };
                }

                // Create a new ReportIssue entity
                var reportIssueVM = new ReportIssueViewModel
                {
                    Location = model.Location,
                    Category = model.Category,
                    Description = model.Description,
                    MediaAttachmentId = model.MediaAttachmentId,
                    MediaAttachmentFilePath = model.MediaAttachmentFilePath,
                   
                };

                // Use the DbContext to save the report issue to the database
                _dbContext.ReportIssues.Add(reportIssueVM);
                _dbContext.SaveChanges();

                // Send a notification using the INotificationService
                _notificationService.Success("Report issue created successfully!");

                // Redirect to the menu page
                return RedirectToAction("Index", "Home");
            }
            return View("Create", model);
        }


    }
}
