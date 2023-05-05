using AutoMapper;
using CloneSAP_API.Data;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;
using Microsoft.AspNetCore.JsonPatch;
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

    [HttpGet("{id}")]

    public IActionResult GetStorageUnitPID(int id)
    {
        var storageunit = _context.StorageUnit.FirstOrDefault(storageunit => storageunit.Id == id);
        if (storageunit == null) return NotFound();
        var storageunitDto = _mapper.Map<ReadStorageUnitDto>(storageunit);
        return Ok(storageunitDto);
    }

    [HttpPut("{id}")]

    public IActionResult PutStorageUnit(int id, [FromBody] UpgradeStorageUnitDto storageUnitDto)
    {
        var storageUnit = _context.StorageUnit.FirstOrDefault(storageUnit => storageUnit.Id == id);
        if (storageUnit == null) return NotFound();
        _mapper.Map(storageUnitDto, storageUnit);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]

    public IActionResult PatchStorageUnit(int id, JsonPatchDocument<UpgradeStorageUnitDto> patch)
    {
        var storageUnit = _context.StorageUnit.FirstOrDefault(storageUnit => storageUnit.Id == id);
        if (storageUnit == null) return NotFound();

        var storageUnitToPatch = _mapper.Map<UpgradeStorageUnitDto>(storageUnit);

        patch.ApplyTo(storageUnitToPatch, ModelState);
        if (!TryValidateModel(storageUnitToPatch)) return ValidationProblem(ModelState);
        _mapper.Map(storageUnitToPatch, storageUnit);

        _context.SaveChanges();
        return NoContent();
    }
}
