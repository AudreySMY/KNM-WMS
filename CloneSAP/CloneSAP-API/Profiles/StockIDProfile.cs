using AutoMapper;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;

namespace CloneSAP_API.Profiles;

public class StockIDProfile : Profile
{
    public StockIDProfile()
    {
        CreateMap<CreateStockIDDto, StorageUnit>();
        CreateMap<StockID, ReadStockIDDto>().ForMember(stockIDDt => stockIDDt.material, opts => opts.MapFrom(stockID => stockID.Material))
                                            .ForMember(stockIDDt => stockIDDt.grid, opts => opts.MapFrom(stockID => stockID.Grid));


    }
}
