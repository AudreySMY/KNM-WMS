using AutoMapper;
using UserSAP.Data.Dtos;
using UserSAP.Models;

namespace UserSAP.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDto, User>();

    }
}
