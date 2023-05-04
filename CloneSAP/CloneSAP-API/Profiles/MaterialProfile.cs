using AutoMapper;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;

namespace CloneSAP_API.Profiles;

    public class MaterialProfile : Profile
    {
    public MaterialProfile()
    {
        CreateMap<CreateMaterialDto, Material>();
        CreateMap<Material, ReadMaterialDto>();
    }
    }

