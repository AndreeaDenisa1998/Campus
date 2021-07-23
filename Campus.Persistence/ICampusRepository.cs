

using System;
using System.Threading.Tasks;
using Campus.Entities;
using Campus.Entities.Campus;

namespace Campus.Persistence
{
    public interface ICampusRepository
    {
        Task <Posts> GetCampusById(Guid id);
    }
}
