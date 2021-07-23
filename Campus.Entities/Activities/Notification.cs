using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Entities.Activities
{
   public class Notification : Entity
    {
        public Notification(string content, Guid idStudent,DateTime date) : base()
        {
            Content = content;
          

        }
        [Required, MaxLength(1000)]
        public string Content { get; private set; }
       
        
        public DateTime Date { get; private set; }
       
     
        public Guid IdStudents { get; private set; }
        public Guid IdUsers { get; private set; }
        public Guid IdPosts { get; private set; }
        public Students Students { get; private set; }
        public Users Users { get; set; }
        public Posts Posts { get; set; }
        
    }
}
