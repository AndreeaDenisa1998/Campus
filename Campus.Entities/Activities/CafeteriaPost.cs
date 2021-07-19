using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Entities
{
    public sealed class CafeteriaPost :Entity
    {
        public CafeteriaPost(Guid idUser,byte[] image,string content,Guid idReview,int numberofLikes,DateTime date) : base()
        {
            Content = content;
            IdUsers = idUser;
            IdReview = idReview;
            Image = image;
            NumberOfLikes = numberofLikes;
            Date = date;

        }

        [Required, MaxLength(1000)]
        public string Content { get; private set; }

        [Required]
        public byte[] Image { get; private set; }
        [Required]

        public Guid IdReview { get; private set; }
        [Required]

        public Guid IdUsers { get; private set; }

        [Required]
        public int NumberOfLikes { get; private set; }

        [Required]
        public DateTime Date { get; private set; }

       
        public ICollection<Review> Review { get; private set; }

    }
}
