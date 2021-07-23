using Campus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Persistence
{
    public interface ICampusRepository
    {
        Task<Users> GetStudentById(Guid Id);
    }
}
