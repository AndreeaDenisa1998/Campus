

using System;
using System.Threading.Tasks;
using Campus.Entities;
using Campus.Entities.Campus;

namespace Campus.Persistence
{
    public interface ICampusRepository
    {
        Task <ITOO.Basic.CommonModel.Campus> GetCampusById(Guid id);

        Task Create(ITOO.Basic.CommonModel.Campus campus);

        Task SaveChanges();
    }
}
