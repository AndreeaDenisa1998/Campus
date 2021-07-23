using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Campus.Models.Reviews
{
    public class ReviewModel
    {
        public Guid Id { get; set; }
        public string Content { get; private set; }
        public int NumberOfLikes { get; private set; }
        public int NumberOfStars { get; private set; }
        public DateTime Date { get; private set; }
    }
}
