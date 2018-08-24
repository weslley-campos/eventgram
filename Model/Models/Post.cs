using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Models
{
    public class Post
    {
        private int _id;
        private int _eventId;
        private string _description;
        private int _postLikes;
        private int _shares;
        private int _comments;

        public Post() => Id = 0;

        public Post(int id, int eventId, string description, int postLikes, int shares, int comments)
        {
            Id = id;
            EventId = eventId;
            Description = description;
            PostLikes = postLikes;
            Shares = shares;
            Comments = comments;
        }

        [Key]
        public int Id { get => _id; set => _id = value; }

        [Required(ErrorMessage = "Um evento é necessário")]
        public int EventId { get => _eventId; set => _eventId = value; }

        [Display(Name = "Descrição")]
        public string Description { get => _description; set => _description = value; }

        [Display(Name = "Curtidas")]
        public int PostLikes { get => _postLikes; set => _postLikes = value; }

        [Display(Name = "Compartilhamentos")]
        public int Shares { get => _shares; set => _shares = value; }

        [Display(Name = "Comentários")]
        public int Comments { get => _comments; set => _comments = value; }


    }
}
