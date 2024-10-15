namespace ReportsIssue.Models;
using System.Collections.Generic;

public class PriorityQueue
{
    // Uses a sorted dictionary to manage a queue of events by date
    private SortedDictionary<DateTime, Queue<LocalEvent>> _eventQueue = new SortedDictionary<DateTime, Queue<LocalEvent>>();


    // Adds an event to the queue based on its event date
    public void AddEvent(LocalEvent localEvent)
    {
        if (!_eventQueue.ContainsKey(localEvent.EventDate))
        {
            _eventQueue[localEvent.EventDate] = new Queue<LocalEvent>();
        }
        _eventQueue[localEvent.EventDate].Enqueue(localEvent);
    }

    // Retrieves and removes the next event in the queue (earliest event)
    public LocalEvent GetNextEvent()
    {
        if (_eventQueue.Count == 0)
        {
            return null;
        }
        var earliest = _eventQueue.First().Value;
        var nextEvent = earliest.Dequeue();
        if (earliest.Count == 0)
        {
            _eventQueue.Remove(_eventQueue.First().Key);
        }
        return nextEvent;
    }
}
