using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Campus.Business.Campus.Models;

namespace Campus.Business.Campus
{
    public sealed class CampusMappingProfile : Profile
    {
        public CampusMappingProfile()
        {
            CreateMap<ITOO.Basic.CommonModel.Campus, CampusModel>();

            CreateMap<CreateCampusModel, ITOO.Basic.CommonModel.Campus>();
        }
    }
}
