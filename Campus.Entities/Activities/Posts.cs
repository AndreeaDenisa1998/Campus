using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities.Activities;

namespace Campus.Entities
{
    public sealed class Posts : Entity
    {
        public Posts(Guid idPosts,string content, Guid idStudent,byte[] image, int numberofLikes, DateTime date) : base()
        {
            IdPosts = idPosts;
            Content = content;
            IdStudents = idStudent;
            Image = image;
            NumberOfLikes = numberofLikes;
            Date = date;


        }
        [Required, MaxLength(1000)]
        public string Content { get; private set; }

        [Required]
        public DateTime Date { get; private set; }

        [Required]
        public int NumberOfLikes { get; private set; }

        [Required]
        public byte[] Image { get; private set; }

        [Required]
        public Guid IdPosts { get; private set; }

        [Required]
        public Guid IdStudents { get;private set; }

        public Students Students { get; private set; }
        public Notification Notification { get; set; }

        

        public ICollection<Comments> Comments { get; private set; }

        public ICollection<Review> Reviews { get; private set; }


    }
}
