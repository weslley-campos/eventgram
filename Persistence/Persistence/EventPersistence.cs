using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public class EventPersistence
    {
        private static List<Event> events;

        static EventPersistence()
        {
            if (events == null)
            {
                events = new List<Event>();
                new EventPersistence().Add(new Event("Lorem ipsum", "Lorem ipsum", "Rua D", "20/06/95","Thiago"));
                new EventPersistence().Add(new Event("Lorem ipsum", "Lorem ipsum", "Rua C", "20/06/95","Thiago"));
            }
        }

        public void Add(Event @event)
        {
             @event.Id = events.Count + 1;
             events.Add(@event);
        }

        public int Find(Event @event) => events.FindIndex(e => e.Id == @event.Id);

        public void Update(Event @event) => events[Find(@event)] = @event;

        public List<Event> GetAll() => events;

        public Event GetBy(int? id) => id.HasValue ? events.Find(@event => @event.Id == id) : null;

        public void Delete(int id) => events.Remove(GetBy(id));

    }
}
