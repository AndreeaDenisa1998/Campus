using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;
using Microsoft.EntityFrameworkCore;

namespace Campus.Persistence
{
   public class ReviewRepository
    {
        private readonly CampusContext context;

        public ReviewRepository(CampusContext context)
        {
            this.context = context;
        }
        public async Task<Review> GetReviewById(Guid id)
        {
            return await context.Review
                .FirstAsync(s => s.Id == id);
        }
        public void Delete(Review review)
        {
            context.Review.Remove(review);
        }
        public async Task Create(Review review)
        {
            await this.context.Review.AddAsync(review);
        }
        public void Update(Review review)
        {
            this.context.Review.Update(review);
        }
        public async Task SaveChanges()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
