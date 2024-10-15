namespace ReportsIssue.Models
{
    public class EventHistory
    {
        private List<LocalEvent> _eventHistory = new List<LocalEvent>();

        public void AddToHistory(LocalEvent localEvent)
        {
            // Check if the event is already in the history
            var existingEvent = _eventHistory.FirstOrDefault(e => e.EventId == localEvent.EventId);

            if (existingEvent != null)
            {
                // If the event is already in the list, move it to the top
                _eventHistory.Remove(existingEvent);
                _eventHistory.Insert(0, localEvent);
            }
            else
            {
                // Add the new event to the top of the list
                _eventHistory.Insert(0, localEvent);

                // Ensure the history list only keeps the last 5 unique events
                if (_eventHistory.Count > 5)
                {
                    _eventHistory.RemoveAt(_eventHistory.Count - 1);
                }
            }
        }

        public IEnumerable<LocalEvent> GetHistory()
        {
            return _eventHistory;
        }
    }
}
