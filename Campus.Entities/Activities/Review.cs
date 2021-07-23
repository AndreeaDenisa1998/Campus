using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities.Authentication;

namespace Campus.Entities
{
    public sealed class Review : Entity
    {
        public Review(string content,Guid idUsers,int numberofStars,DateTime date,int numberofLikes) : base()
        {
            Content = content;
            IdUsers = idUsers;
            NumberOfLikes = numberofLikes;
            Date = date;
            NumberOfStars = numberofLikes;

        }
        [Required, MaxLength(1000)]
        public string Content { get; private set; }
        [Required]
        public int NumberOfStars { get; private set; }
        [Required]
        public DateTime Date { get; private set; }
        [Required]
        public int NumberOfLikes { get; private set; }
        [Required]
        public Guid IdUsers { get; private set; }

        public Users Users { get; private set; }

    }
}
