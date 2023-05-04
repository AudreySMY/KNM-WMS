using AutoMapper;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;

namespace CloneSAP_API.Profiles;

public class GridProfile : Profile
{
    public GridProfile()
    {
        CreateMap<CreateGridDto, Grid>();
        CreateMap<Grid, ReadGridDto>();
    }
}
