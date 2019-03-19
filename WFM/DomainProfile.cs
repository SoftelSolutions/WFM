using AutoMapper;
using WFM.Entity;
using WFM.WebAPI.DTOs;
using WFM.WebAPI.DTOs.UserDTOs;

namespace WFMWebAPI
{
    class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            CreateMap<User, UserResponse>();
            CreateMap<User, UpdateUserRequest>().ReverseMap();

            CreateMap<User, CreateUserRequest>().ReverseMap();
        }
    }
}
