using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Business.Campus.Models;

namespace Campus.Business.Campus.Services
{
    public interface ICampusService
    {
        Task<CampusModel> GetById(Guid id);

        Task<CampusModel> Create(CreateCampusModel model);


    }
}
