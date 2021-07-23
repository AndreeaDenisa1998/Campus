using Campus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Campus.Persistence
{
    public sealed class CampusRepository : ICampusRepository
    {
        private readonly CampusContext context;

        public CampusRepository(CampusContext context)
        {
            this.context = context;
        }
        public async Task<Users> GetStudentById(Guid id)
        {
            return await context.Users
                .FirstAsync(s => s.Id == id);
        }

    }
}
