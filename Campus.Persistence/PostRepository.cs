using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;
using Microsoft.EntityFrameworkCore;

namespace Campus.Persistence
{
    class PostRepository : IPostRepository
    {
        private readonly CampusContext context;

        public PostRepository(CampusContext context)
        {
            this.context = context;
        }
        public async Task<Comments> GetCommentById(Guid id)
        {
            return await context.Posts
                .FirstAsync(s => s.Id == id);
        }
        public void Delete(Comments comment)
        {
            context.Posts.Remove(comment);
        }
        public async Task Create(Comments comment)
        {
            await this.context.Posts.AddAsync(comment);
        }
        public void Update(Comments comment)
        {
            this.context.Posts.Update(comment);
        }
        public async Task SaveChanges()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
