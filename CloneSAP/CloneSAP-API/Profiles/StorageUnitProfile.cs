using AutoMapper;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;

namespace CloneSAP_API.Profiles
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
