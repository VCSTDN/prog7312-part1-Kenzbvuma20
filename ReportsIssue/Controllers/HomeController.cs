using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportsIssue.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using System.Diagnostics;

namespace ReportsIssue.Controllers
{
    public class HomeController : Controller
    {

        private readonly INotyfService _notificationService;

        private readonly ReportsIssueDbContext _dbContext;

        public HomeController(ReportsIssueDbContext dbContext, INotyfService notificationService)
        {
            _dbContext = dbContext;
            _notificationService = notificationService;
        }
        public ActionResult Index()
        {
            var viewModel = new MainMenuViewModel
            {
                MenuOptions = new[]
                {
            new MenuItem { Text = "Report Issues", Enabled = true, Controller = "Home", Action = "CreateReportIssue" },
            new MenuItem { Text = "Local Events and Announcements", Enabled = false },
            new MenuItem { Text = "Service Request Status", Enabled = false }
                }

             


            };

            // Retrieve the saved report issues from the database
            var reportIssues = _dbContext.ReportIssues.ToList();

            // Add the report issues to the view model
            viewModel.ReportIssues = reportIssues;
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult CreateReportIssue()
        {
            return View("~/Views/ReportIssues/Create.cshtml", new ReportIssueViewModel());
        }


       
    }
}
