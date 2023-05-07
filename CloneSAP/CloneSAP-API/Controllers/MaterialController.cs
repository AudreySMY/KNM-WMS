using AutoMapper;
using CloneSAP_API.Data;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
using System.Text.Json;

namespace CloneSAP_API.Controllers;


[ApiController]
[Route("[Controller]")]
public class MaterialController : ControllerBase
{
    private SAPContext _context;
    private IMapper _mapper;

    public MaterialController(SAPContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public IActionResult PostMaterial([FromBody] CreateMaterialDto MaterialDto)
    {
        Material material = _mapper.Map<Material>(MaterialDto);
        if(material == null)return NotFound();
        _context.Material.Add(material);
        _context.SaveChanges();
        return Ok(material);

    }

    [HttpGet]
    public IEnumerable<ReadMaterialDto> GetMaterials([FromQuery] int skip = 0, [FromQuery] int Take = 100)
    {
        return _mapper.Map<List<ReadMaterialDto>>(_context.Material.ToList());
    }
    [HttpGet("{id}")]

    public IActionResult GetMaterialPID(int id) 
    {
        var material = _context.Material.FirstOrDefault(material => material.Id == id);
        if (material == null) return NotFound();
        var materialDto = _mapper.Map<ReadMaterialDto>( material);
        return Ok(materialDto);
    }

    [HttpPut("{id}")]

    public IActionResult GetMaterialPID(int id, [FromBody] UpgradeMaterialDto materialDto )
    {
        var material = _context.Material.FirstOrDefault(material => material.Id == id);
        if (material == null) return NotFound();
        _mapper.Map(materialDto, material);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]

    public IActionResult GetMaterialPID(int id, JsonPatchDocument<UpgradeMaterialDto> patch)
    {
        var material = _context.Material.FirstOrDefault(material => material.Id == id);
        if (material == null) return NotFound();

        var materialToPatch = _mapper.Map<UpgradeMaterialDto>( material );

        patch.ApplyTo( materialToPatch, ModelState );
        if (!TryValidateModel(materialToPatch)) return ValidationProblem(ModelState);
        _mapper.Map(materialToPatch, material);
        
        _context.SaveChanges();
        return NoContent();
    }
}

