using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private int idUser;
        private string eventModerator;

        public Event() => Id = 0;

        public Event(string EventName, string EventDescription, string EventLocation, string EventDate, string EventModerator)
        {
            this.EventName = EventName;
            this.EventDescription = EventDescription;
            this.EventLocation = EventLocation;
            this.EventDate = EventDate;
            this.EventModerator = EventModerator;
            //this.IdUser = IdUser;
        }

        [Key]
        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "O nome do Evento é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public string EventName { get => eventName; set => eventName = value; }

        [Display(Name = "Descrição")]
        public string EventDescription { get => eventDescription; set => eventDescription = value; }

        [Required(ErrorMessage = "A localização do Evento é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Localização")]
        public string EventLocation { get => eventLocation; set => eventLocation = value; }

        [Required(ErrorMessage = "A data do Evento é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Data")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public string EventDate { get => eventDate; set => eventDate = value; }

        [Display(Name = "Moderador")]
        public string EventModerator { get => eventModerator; set => eventModerator = value; }

        public int IdUser { get => idUser; set => idUser = value; }
    }
}
