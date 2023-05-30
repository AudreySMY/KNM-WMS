using AutoMapper;
using KNM_API.Data;
using KNM_API.Data.Dtos;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Data.Dtos.UpdateDtos;
using KNM_API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
using System.Text.Json;

namespace KNM_API.Controllers;


[ApiController]
[Route("[Controller]")]
public class ModelController : ControllerBase
{
    private KNMContext _context;
    private IMapper _mapper;

    public ModelController(KNMContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public IActionResult PostModel([FromBody] CreateModelDto MaterialDto)
    {
        Model material = _mapper.Map<Model>(MaterialDto);
        if(material == null)return NotFound();
        _context.Model.Add(material);
        _context.SaveChanges();
        return Ok(material);

    }

    [HttpGet]
    public IEnumerable<ReadModelDto> GetModels([FromQuery]string? material)
    {   
        if(material is null) return _mapper.Map<List<ReadModelDto>>(_context.Model.ToList());
            
        return _mapper.Map<List<ReadModelDto>>(_context.Model.FromSql($"select * from material where material = {material}").ToList());

    }
    [HttpGet("{id}")]

    public IActionResult GetModelPID(string id) 
    {
        var material = _context.Model.FirstOrDefault(material => material.ModelCod == id);
        if (material == null) return NotFound();
        var materialDto = _mapper.Map<ReadModelDto>( material);
        return Ok(materialDto);
    }

    [HttpPut("{id}")]

    public IActionResult GetModelPID(string id, [FromBody] UpgradeMaterialDto materialDto )
    {
        var material = _context.Model.FirstOrDefault(material => material.ModelCod == id);
        if (material == null) return NotFound();
        _mapper.Map(materialDto, material);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]

    public IActionResult GetMaterialPID(string id, JsonPatchDocument<UpgradeMaterialDto> patch)
    {
        var model = _context.Model.FirstOrDefault(model => model.ModelCod == id);
        if (model == null) return NotFound();

        var materialToPatch = _mapper.Map<UpgradeMaterialDto>( model );

        patch.ApplyTo( materialToPatch, ModelState );
        if (!TryValidateModel(materialToPatch)) return ValidationProblem(ModelState);
        _mapper.Map(materialToPatch, model);
        
        _context.SaveChanges();
        return NoContent();
    }
}

