using AutoMapper;
using KNM_API.Data;
using KNM_API.Data.Dtos;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Data.Dtos.UpdateDtos;
using KNM_API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace KNM_API.Controllers;


[ApiController]
[Route("[Controller]")]
public class StorageUnitController : ControllerBase
{
    private  KNMContext _context;
    private  IMapper _mapper;

    public StorageUnitController(KNMContext context,IMapper mapper)
	{
        _context= context;
        _mapper= mapper;
    }

    [HttpPost]

    public IActionResult PostStorageUnit([FromBody]CreateStorageUnitDto suDto)
    {
        StorageUnit sUnit = _mapper.Map<StorageUnit>(suDto);
        if (sUnit == null) return NotFound();
        _context.StorageUnit.Add(sUnit);
        _context.SaveChanges();
        return Ok(sUnit);
    }
    [HttpGet]

    public IEnumerable<ReadStorageUnitDto> GetStorageUnits()
    {
        
        return _mapper.Map<List<ReadStorageUnitDto>>(_context.StorageUnit.ToList());
    }

    [HttpGet("{id}")]

    public IActionResult GetStorageUnitPID(int id)
    {
        var storageunit = _context.StorageUnit.FirstOrDefault(storageunit => storageunit.Label == id);
        if (storageunit == null) return NotFound();
        var storageunitDto = _mapper.Map<ReadStorageUnitDto>(storageunit);
        return Ok(storageunitDto);
    }

    [HttpPut("{id}")]

    public IActionResult PutStorageUnit(int id, [FromBody] UpgradeStorageUnitDto storageUnitDto)
    {
        var storageUnit = _context.StorageUnit.FirstOrDefault(storageUnit => storageUnit.Label == id);
        if (storageUnit == null) return NotFound();
        _mapper.Map(storageUnitDto, storageUnit);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]

    public IActionResult PatchStorageUnit(int id, JsonPatchDocument<UpgradeStorageUnitDto> patch)
    {
        var storageUnit = _context.StorageUnit.FirstOrDefault(storageUnit => storageUnit.Label == id);
        if (storageUnit == null) return NotFound();

        var storageUnitToPatch = _mapper.Map<UpgradeStorageUnitDto>(storageUnit);

        patch.ApplyTo(storageUnitToPatch, ModelState);
        if (!TryValidateModel(storageUnitToPatch)) return ValidationProblem(ModelState);
        _mapper.Map(storageUnitToPatch, storageUnit);

        _context.SaveChanges();
        return NoContent();
    }
}
