using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Campus.Business.Campus.Models;
using Campus.Persistence;

namespace Campus.Business.Campus.Services
{
    
    public sealed  class CampusService:ICampusService
    {
        private readonly ICampusRepository campusRepository;
        public CampusService(ICampusRepository campusRepository)
        {
            this.campusRepository = campusRepository;
        }
        public async Task<CampusModel> GetById(Guid id)
        {
           var trip = await campusRepository.GetCampusById(id);
           return new CampusModel()
           {
           };
        }
    }
}
