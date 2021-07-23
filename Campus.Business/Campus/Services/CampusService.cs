using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Campus.Business.Campus.Models;
using Campus.Persistence;

namespace Campus.Business.Campus.Services
{
    
    public sealed  class CampusService:ICampusService
    {
        private readonly ICampusRepository campusRepository;
        private readonly IMapper mapper;
        public CampusService(ICampusRepository campusRepository, IMapper mapper)
        {
            this.campusRepository = campusRepository;
            this.mapper = mapper;
        }
        public async Task<CampusModel> GetById(Guid id)
        {
           var campus= await campusRepository.GetCampusById(id);
           return mapper.Map<CampusModel>(campus);
        }

        public async Task<CampusModel> Create(CreateCampusModel model)
        {
            var campus = this.mapper.Map<ITOO.Basic.CommonModel.Campus>(model);

            await this.campusRepository.Create(campus);
            await this.campusRepository.SaveChanges();

            return mapper.Map<CampusModel>(campus);
        }
    }
}
