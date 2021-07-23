using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Campus.Models
{
    public sealed class CampusModel
    {
        public Guid IdPost { get; private set; }
        public Guid IdTypesPost { get; private set; }
        public Guid IdUser { get; private set; }

        public int NumberOfLikes { get; private set; }

        public string ContentOfPosts { get; private set; }

        public byte[] Image { get; private set; }
    }
}
