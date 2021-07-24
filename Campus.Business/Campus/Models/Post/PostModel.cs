using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Campus.Models.Post
{
    public class PostModel
    {
        public Guid Id { get; set; }
        public string Content { get; private set; }
        public int NumberOfLikes { get; private set; }
        public DateTime Date { get; private set; }

        public byte[] Image { get; private set; }

    }
}
