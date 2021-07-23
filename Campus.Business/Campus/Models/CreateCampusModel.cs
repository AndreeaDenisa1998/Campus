using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Campus.Models
{
    public sealed class CreateCampusModel
    {
        public int NumberOfLikes { get; set; }
        public string ContentOfPosts { get; set; }
        public byte[] Image { get; set; }
    }
}
