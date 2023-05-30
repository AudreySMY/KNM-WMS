using AutoMapper;
using KNM_API.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using KNM_API.Models;
using KNM_API.Data.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Data.Dtos.UpdateDtos;

namespace KNM_API.Controllers;

[ApiController]
[Route("[Controller]")]
public class GridController : ControllerBase
{
    private KNMContext _context;
    private IMapper _mapper;

    public GridController(KNMContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public IActionResult PostGrid([FromBody] CreateGridDto gridDto)
    {
        Grid grid = _mapper.Map<Grid>(gridDto);
        if(grid == null) return NotFound();
        _context.Grid.Add(grid);
        _context.SaveChanges();
        return Ok(grid);

    }

    [HttpGet]
    public IEnumerable<ReadGridDto> GetGrid()
    {   
        
        return _mapper.Map<List<ReadGridDto>>(_context.Grid).ToList();


    }

    [HttpGet("{id}")]
    public IActionResult GetGridPID(string id)
    {
       var grid = _context.Grid.FirstOrDefault(grid=>grid.GridCod == id);
        if(grid == null)return NotFound();
        var gridDto = _mapper.Map<ReadGridDto>(grid);
        return Ok(gridDto);
    }

    [HttpPut("{id}")]

    public IActionResult PutGrid(string id, [FromBody] UpgradeGridDto gridDto)
    {
        var grid = _context.Grid.FirstOrDefault(grid => grid.GridCod == id);
        if(grid == null)return NotFound();
        _mapper.Map(gridDto, grid);
        _context.SaveChanges();
        return NoContent();
    }
    [HttpPatch("{id}")]

    public IActionResult PatchGrid(string id, JsonPatchDocument<UpgradeGridDto> patch )
    {
        var grid = _context.Grid.FirstOrDefault(grid => grid.GridCod == id);
        if (grid == null) return NotFound();

        var gridToPatch = _mapper.Map<UpgradeGridDto>(grid);

        patch.ApplyTo(gridToPatch,ModelState);

        if(!TryValidateModel(gridToPatch)) return ValidationProblem(ModelState);
        _mapper.Map(gridToPatch, grid);

        _context.SaveChanges();
        return NoContent();
    }


}

