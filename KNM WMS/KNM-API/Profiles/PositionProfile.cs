using AutoMapper;
using KNM_API.Data.Dtos;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Models;

namespace KNM_API.Profiles
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<CreatePositionDto, Position>();
            CreateMap<Position, ReadPositionDto>().ForMember(_positionDto =>_positionDto.EanDto, opts=>opts.MapFrom(_position => _position.EanID));
        }
        
    }
}
