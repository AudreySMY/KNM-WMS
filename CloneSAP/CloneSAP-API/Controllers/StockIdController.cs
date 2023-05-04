using AutoMapper;
using CloneSAP_API.Data;
using CloneSAP_API.Models;
using Microsoft.AspNetCore.Mvc;
using CloneSAP_API.Data.Dtos;

namespace CloneSAP_API.Controllers;

[ApiController]
[Route("[Controller]")]
public class StockIdController : Controller
{
    private SAPContext _context;
    private IMapper _mapper;

    public StockIdController(SAPContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public void PostStockID([FromBody] CreateStockIDDto stockIDDto)
    {
        StockID stockID = _mapper.Map<StockID>(stockIDDto);

        _context.StockID.Add(stockID);
        _context.SaveChanges();

    }

    [HttpGet]
    public IEnumerable<ReadStockIDDto> GetGrid([FromQuery] int skip = 0, [FromQuery] int Take = 100)
    {
        return _mapper.Map<List<ReadStockIDDto>>(_context.StockID.Skip(skip).Take(Take).ToList());
    }

}
