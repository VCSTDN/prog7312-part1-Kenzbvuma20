using Microsoft.AspNetCore.Mvc;
using ReportsIssue.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReportsIssue.Controllers
{
    public class LocalEventsController : Controller
    {
        private readonly ReportsIssueDbContext _dbContext;
        private static Stack<LocalEvent> _eventHistory = new Stack<LocalEvent>();
        private SearchTracker _searchTracker = new SearchTracker();


        public LocalEventsController(ReportsIssueDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index(string searchCategory, string searchStartDate, string searchEndDate, string searchQuery)
        {
            var events = _dbContext.LocalEvents.AsQueryable();

            // Filter by category if provided
            if (!string.IsNullOrEmpty(searchCategory))
            {
                events = events.Where(e => e.Category == searchCategory);
            }

            // Parse start and end date
            DateTime? startDate = string.IsNullOrEmpty(searchStartDate) ? (DateTime?)null : DateTime.Parse(searchStartDate);
            DateTime? endDate = string.IsNullOrEmpty(searchEndDate) ? (DateTime?)null : DateTime.Parse(searchEndDate);

            // Filter by date range if provided
            if (startDate.HasValue && endDate.HasValue)
            {
                events = events.Where(e => e.EventDate >= startDate.Value && e.EventDate <= endDate.Value);
            }

            // Filter by search query if provided
            if (!string.IsNullOrEmpty(searchQuery))
            {
                events = events.Where(e => e.Title.Contains(searchQuery) || e.Description.Contains(searchQuery));
            }

            // Use SortedDictionary to organize events by date
            var sortedEvents = new SortedDictionary<DateTime, List<LocalEvent>>();
            var uniqueCategories = new HashSet<string>();  // Use HashSet for unique categories

            foreach (var localEvent in events)
            {
                if (!sortedEvents.ContainsKey(localEvent.EventDate))
                {
                    sortedEvents[localEvent.EventDate] = new List<LocalEvent>();
                }
                sortedEvents[localEvent.EventDate].Add(localEvent);

                // Track unique categories
                uniqueCategories.Add(localEvent.Category);
            }

            // Flatten the sorted dictionary into a list for display
            var orderedEvents = sortedEvents.SelectMany(e => e.Value).ToList();

            // Pass sorted events and unique categories to the view
            ViewBag.UniqueCategories = uniqueCategories; // Pass unique categories using ViewBag
            return View(orderedEvents);
        }


        public IActionResult Details(int id)
        {
            var localEvent = _dbContext.LocalEvents.FirstOrDefault(e => e.EventId == id);
            if (localEvent == null)
            {
                return NotFound();
            }

            // Track event history (limit to 5 most recent)
            if (_eventHistory.Count == 5)
            {
                _eventHistory.Pop();
            }
            _eventHistory.Push(localEvent);

            // Pass the history to the view using ViewBag
            ViewBag.EventHistory = _eventHistory;

            return View("Details", localEvent);
        }

        public IActionResult RecommendEvents()
        {
            var mostSearchedCategory = _searchTracker.GetMostSearchedCategory();
            if (!string.IsNullOrEmpty(mostSearchedCategory))
            {
                var recommendedEvents = _dbContext.LocalEvents
                    .Where(e => e.Category == mostSearchedCategory)
                    .OrderBy(e => e.EventDate)
                    .Take(3)  // Recommend the top 3 events
                    .ToList();

                ViewBag.RecommendedEvents = recommendedEvents;  // Pass recommendations using ViewBag
            }

            return View();
        }


    }
}
