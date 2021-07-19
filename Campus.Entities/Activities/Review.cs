using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Entities
{
    public sealed class Review : Entity
    {
        public Review(string content,Guid idStudent,int numberofStars,DateTime date,int numberofLikes) : base()
        {
            Content = content;
            IdStudents = idStudent;
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
        public Guid IdStudents { get; private set; }

        public Students Students { get; private set; }

        public CafeteriaPost CafeteriaPost { get; private set; }
    }
}
