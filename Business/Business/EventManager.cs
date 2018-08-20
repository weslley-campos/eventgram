using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Persistence;
using Model.Models;

namespace Business.Business
{
    public class EventManager
    {
        EventPersistence eventPersistence;

        public EventManager() => eventPersistence = new EventPersistence();

        public List<Event> GetAll() => eventPersistence.GetAll();

        public Event GetBy(int id) => eventPersistence.GetBy(id);

        public List<Event> GetAllByUser(int? id) => eventPersistence.GetAllByUser(id);

        public void Create(Event @event) => eventPersistence.Add(@event);

        public void Edit(Event @event) => eventPersistence.Update(@event);

        public void Delete(int id) => eventPersistence.Delete(id);
    }
}
