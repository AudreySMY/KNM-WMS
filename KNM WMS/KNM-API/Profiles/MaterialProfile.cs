using AutoMapper;
using KNM_API.Data.Dtos;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Data.Dtos.UpdateDtos;
using KNM_API.Models;

namespace KNM_API.Profiles;

public class MaterialProfile : Profile
    {
    public MaterialProfile()
    {
        CreateMap<CreateModelDto, Model>();
        CreateMap<Model, ReadModelDto>();
        CreateMap<UpgradeMaterialDto, Model>();
        CreateMap<Model, UpgradeMaterialDto>();
    }
    }

