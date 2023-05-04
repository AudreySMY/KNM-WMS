using AutoMapper;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using CloneSAP_API.Models;

namespace CloneSAP_API.Controllers;

[ApiController]
[Route("[Controller]")]
public class StorageUnitController : Controller
{
    private SAPContext _context;
    private IMapper _mapper;

    public StorageUnitController(SAPContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public void PostStorageUnit([FromBody] CreateGridDto storageUnitDto)
    {
        StorageUnit storageUnit = _mapper.Map<StorageUnit>(storageUnitDto);

        _context.StorageUnit.Add(storageUnit);
        _context.SaveChanges();

    }

    [HttpGet]
    public IEnumerable<ReadStorageUnitDto> GetGrid([FromQuery] int skip = 0, [FromQuery] int Take = 100)
    {
        return _mapper.Map<List<ReadStorageUnitDto>>(_context.StorageUnit.Skip(skip).Take(Take));
    }


}

