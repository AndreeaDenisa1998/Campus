using Campus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Campus.Persistence
{
    public  class CommentRepository : ICommentRepository
    {
        private readonly CampusContext context;

        public CommentRepository(CampusContext context)
        {
            this.context = context;
        }
        public async Task<Comments> GetCommentById(Guid id)
        {
            return await context.Comments
                .FirstAsync(s => s.Id == id);
        }
        public void Delete(Comments comment)
        {
            context.Comments.Remove(comment);
        }
        public async Task Create(Comments comment)
        {
            await this.context.Comments.AddAsync(comment);
        }
        public void Update(Comments comment)
        {
            this.context.Comments.Update(comment);
        }
        public async Task SaveChanges()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
