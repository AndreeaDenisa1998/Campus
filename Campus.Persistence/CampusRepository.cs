using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;

namespace Campus.Persistence
{
    public sealed class CampusRepository : ICampusRepository
    {
        private readonly CampusContext context;

        public CampusRepository(CampusContext context)
        {
            this.context = context;
        }

        public async Task<ITOO.Basic.CommonModel.Campus> GetCampusById(Guid id)
        {
            return await context.Campus.Include(x => x.Comments).SingleOrDefaultAsync(t => t.Id == id);
        }

        public async Task Create(ITOO.Basic.CommonModel.Campus campus)
        {
            await this.context.Campus.AddAsync(campus);
        }


        Task<ITOO.Basic.CommonModel.Campus> ICampusRepository.GetCampusById(Guid id)
        {
            return GetCampusById(id);
        }

        public async Task SaveChanges()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
