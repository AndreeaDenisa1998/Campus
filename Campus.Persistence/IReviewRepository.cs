using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;

namespace Campus.Persistence
{
    public interface IReviewRepository
    {
        Task<Review> GetReviewById(Guid id);
        Task Create(Review review);
        Task SaveChanges();
        void Delete(Review review);
        void Update(Review review);
    }
}
