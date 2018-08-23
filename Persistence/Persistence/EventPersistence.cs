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
                new EventPersistence().Add(0, new Event("Lorem ipsum", "Lorem ipsum", "Rua A", "20/06/95","Thiago"));
                new EventPersistence().Add(1, new Event("Lorem ipsum", "Lorem ipsum", "Rua B", "20/06/95","Ana"));
                new EventPersistence().Add(2, new Event("Lorem ipsum", "Lorem ipsum", "Rua D", "20/06/95","Pedro"));
                new EventPersistence().Add(3, new Event("Lorem ipsum", "Lorem ipsum", "Rua C", "20/06/95","Carlos"));
            }
        }

        public void Add(int id, Event @event)
        {
             @event.Id = events.Count + 1;
             @event.IdUser = id;
             events.Add(@event);
        }


        public void Update(Event @event) => events[events.FindIndex(e => e.Id == @event.Id)] = @event;

        public Event GetBy(int? id) => id.HasValue ? events.Find(@event => @event.Id == id) : null;

        public List<Event> GetAllByUser(int? id)
        {
            Console.WriteLine(id);
            return events.FindAll(@event => @event.IdUser == id);
        }

        public int Delete(int id)
        {
            Event delete = GetBy(id);
            events.Remove(delete);
            return delete.IdUser;
        }

    }
}