using AutoMapper;
using WFM.Entity;
using WFM.WebAPI.DTOs;

namespace WFMWebAPI
{
    class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            CreateMap<User, UserResponse>();
        }
    }
}
