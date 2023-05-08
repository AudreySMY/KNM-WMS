using AutoMapper;
using CloneSAP_API.Data;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CloneSAP_API.Controllers;


[ApiController]
[Route("[Controller]")]
public class StorageUnitController : ControllerBase
{
    private  SAPContext _context;
    private  IMapper _mapper;

    public StorageUnitController(SAPContext context,IMapper mapper)
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

    public IEnumerable<ReadStorageUnitDto> GetStorageUnits([FromQuery] string? material, [FromQuery]string? grid, [FromQuery]int? stockid)
    {
        if(material is null && grid is null && stockid is not null)
            return _mapper.Map<List<ReadStorageUnitDto>>(
                _context.StorageUnit
                    .Where(su => su.SI.ID == stockid).ToList());

        if (material is not null && grid is null && stockid is null)
            return _mapper.Map<List<ReadStorageUnitDto>>(
                _context.StorageUnit
                    .Where(su => su.SI.Material.material == material).ToList());

        if (material is  null && grid is not null && stockid is null)
            return _mapper.Map<List<ReadStorageUnitDto>>(
                _context.StorageUnit
                    .Where(su => su.SI.Grid.GridCod == grid).ToList());

        if (material is not null && grid is not null && stockid is null)
            return _mapper.Map<List<ReadStorageUnitDto>>(
                _context.StorageUnit
                    .Where(su => su.SI.Grid.GridCod == grid 
                        && su.SI.Material.material == material).ToList());

        if (material is not null && grid is not null && stockid is not null)
            return _mapper.Map<List<ReadStorageUnitDto>>(
                _context.StorageUnit
                    .Where(su => su.SI.Grid.GridCod == grid 
                        && su.SI.Material.material == material 
                            && su.SIID == stockid).ToList());


        return _mapper.Map<List<ReadStorageUnitDto>>(_context.StorageUnit.ToList());
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
