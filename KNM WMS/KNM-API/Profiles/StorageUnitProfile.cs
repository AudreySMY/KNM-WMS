using AutoMapper;
using KNM_API.Data.Dtos;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Data.Dtos.UpdateDtos;
using KNM_API.Models;

namespace KNM_API.Profiles
{
    public class StorageUnitProfile : Profile
    {
        public StorageUnitProfile()
        {
            CreateMap<CreateStorageUnitDto, StorageUnit>();
            CreateMap<StorageUnit, ReadStorageUnitDto>();
            CreateMap<UpgradeStorageUnitDto, StorageUnit>();
            CreateMap<StorageUnit, UpgradeStorageUnitDto>();
        }
    }
}
