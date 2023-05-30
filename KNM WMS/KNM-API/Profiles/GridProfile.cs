using AutoMapper;
using KNM_API.Data.Dtos;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Data.Dtos.UpdateDtos;
using KNM_API.Models;

namespace KNM_API.Profiles;

public class GridProfile : Profile
{
    public GridProfile()
    {
        CreateMap<CreateGridDto, Grid>();
        CreateMap<Grid, ReadGridDto>();
        CreateMap<UpgradeGridDto, Grid>();
        CreateMap<Grid, UpgradeGridDto>();

    }
}
