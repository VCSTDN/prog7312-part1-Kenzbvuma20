namespace ReportsIssue.Models
{
    public class EventManager
    // Stores events by date using a sorted dictionary

    {
        private SortedDictionary<DateTime, List<LocalEvent>> _eventsByDate = new SortedDictionary<DateTime, List<LocalEvent>>();


        // Adds an event to the dictionary, organizing by date

        public void AddEvent(LocalEvent localEvent)
        {
            if (!_eventsByDate.ContainsKey(localEvent.EventDate))
            {
                _eventsByDate[localEvent.EventDate] = new List<LocalEvent>();
            }
            _eventsByDate[localEvent.EventDate].Add(localEvent);
        }

        // Retrieves events for a specific date
        public IEnumerable<LocalEvent> GetEventsForDate(DateTime date)
        {
            if (_eventsByDate.ContainsKey(date))
            {
                return _eventsByDate[date];
            }
            return Enumerable.Empty<LocalEvent>();
        }

        // Returns all events sorted by date

        public IEnumerable<LocalEvent> GetAllEventsSorted()
        {
            return _eventsByDate.SelectMany(e => e.Value).ToList();
        }
    }

}
