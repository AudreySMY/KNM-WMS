using AutoMapper;
using CloneSAP_API.Data;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloneSAP_API.Controllers;


[ApiController]
[Route("[Controller]")]
public class StorageUnitController : Controller
{
    private  SAPContext _context;
    private  IMapper _mapper;

    public StorageUnitController(SAPContext context,IMapper mapper)
	{
        _context= context;
        _mapper= mapper;
    }

    [HttpPost]

    public void PostStorageUnit([FromBody]CreateStorageUnitDto suDto)
    {
        StorageUnit sUnit = _mapper.Map<StorageUnit>(suDto);

        _context.StorageUnit.Add(sUnit);
        _context.SaveChanges();
    }
    [HttpGet]

    public IEnumerable<ReadStorageUnitDto> GetStorageUnits([FromQuery]int skip=0, [FromQuery] int take = 100)
    {
        return _mapper.Map<List<ReadStorageUnitDto>>(_context.StorageUnit.Skip(skip).Take(take).ToList());
    }
}
