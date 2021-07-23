using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Entities
{
    public sealed class Comments : Entity
    {
       /* public Comments(Guid idPosts,string content,Guid idStudent, int numberofLikes, DateTime date) : base()
        {
            IdPosts = idPosts;
            Content = content;
            IdStudents = idStudent;
            NumberOfLikes = numberofLikes;
            Date = date;
        }*/

        [Required,MaxLength(1000)]
        public string Content {get; private set;}
        public int NumberOfLikes { get; private set; }
        public DateTime Date { get; private set; }

        [Required]
        public Guid IdStudents { get; private set; }

        [Required]
        public Guid IdPosts { get; private set; }
        public Guid IdUsers { get; private set; }

        public Students Students { get; private set; }

        [Required]
        
        public Posts Posts { get; private set; }

        [Required]
        
        public Users Users { get; set; }
      
    }
   
}
