﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities.Authentication;

namespace Campus.Entities
{
    public sealed class Comments : Entity
    {
        public Comments(Guid idPosts,string content,Guid idUsers, int numberofLikes, DateTime date) : base()
        {
            IdPosts = idPosts;
            Content = content;
            IdUsers = idUsers;
            NumberOfLikes = numberofLikes;
            Date = date;
        }

        [Required,MaxLength(1000)]
        public string Content {get; private set;}

        [Required]
        public Guid IdUsers { get; private set; }

        [Required]
        public Guid IdPosts { get; private set; }

        public Users Users { get; private set; }

        [Required]
        public int NumberOfLikes { get; private set; }
        public Posts Posts { get; private set; }

        [Required]
        public DateTime Date { get; private set; }
      
    }
   
}
