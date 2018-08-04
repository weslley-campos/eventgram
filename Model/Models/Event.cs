using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Event
    {
        private int id;
        private string eventName;
        private string eventDescription;
        private string eventLocation;
        private string eventDate;
        private string eventModerator;

        public Event() => Id = 0;

        public Event(string EventName, string EventDescription, string EventLocation, string EventDate, string EventModerator)
        {
            this.EventName = EventName;
            this.EventDescription = EventDescription;
            this.EventLocation = EventLocation;
            this.EventDate = EventDate;
            this.EventModerator = EventModerator;
        }

        public int Id { get => id; set => id = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string EventDescription { get => eventDescription; set => eventDescription = value; }
        public string EventLocation { get => eventLocation; set => eventLocation = value; }
        public string EventDate { get => eventDate; set => eventDate = value; }
        public string EventModerator { get => eventModerator; set => eventModerator = value; }
    }
}
