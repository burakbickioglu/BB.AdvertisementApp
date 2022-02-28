using AutoMapper;
using BB.AdvertisementApp.Dtos;
using BB.AdvertisementApp.UI.Models;

namespace BB.AdvertisementApp.UI.Mappings.AutoMapper
{ 
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
        }
    }
}
