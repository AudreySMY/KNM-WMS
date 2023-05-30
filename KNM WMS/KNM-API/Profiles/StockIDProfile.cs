using AutoMapper;
using KNM_API.Data.Dtos;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Data.Dtos.UpdateDtos;
using KNM_API.Models;

namespace KNM_API.Profiles;

public class StockIDProfile : Profile
{
    public StockIDProfile()
    {
        CreateMap<CreateEanDto, Ean>();
        CreateMap<Ean, ReadEanDto>().ForMember(EanDt => EanDt.Model, opts => opts.MapFrom(EanDt => EanDt.Model))
                                            .ForMember(EanDt => EanDt.Grid, opts => opts.MapFrom(EanDt => EanDt.Grid));
        CreateMap<UpgradeStockIDDto, Ean>();
        CreateMap<Ean, UpgradeStockIDDto>();


    }
}
