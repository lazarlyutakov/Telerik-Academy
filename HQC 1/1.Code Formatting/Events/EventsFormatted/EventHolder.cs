namespace EventsFormatted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        static EventHolder events = new EventHolder();

        MultiDictionary<string, Event> findByTitle = new MultiDictionary<string, Event>(true);
        OrderedBag<Event> findByDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);

            findByTitle.Add(title.ToLower(), newEvent);
            findByDate.Add(newEvent);

            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in findByTitle[title])
            {
                removed++;
                findByDate.Remove(eventToRemove);
            }

            findByTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = findByDate.RangeFrom(new Event(date, "", ""), true);
            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }     
    }
}