using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;

namespace Campus.Persistence
{
    public interface IPostRepository
    {
        Task<Comments> GetCommentById(Guid id);
        Task Create(Comments comment);
        Task SaveChanges();
        void Delete(Comments comment);
        void Update(Comments comment);
    }
}

