using AutoMapper;
using CloneSAP_API.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using CloneSAP_API.Models;
using CloneSAP_API.Data.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace CloneSAP_API.Controllers;

[ApiController]
[Route("[Controller]")]
public class GridController : Controller
{
    private SAPContext _context;
    private IMapper _mapper;

    public GridController(SAPContext context, IMapper mapper)
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
    public IEnumerable<ReadGridDto> GetGrid([FromQuery] int skip = 0, [FromQuery] int Take = 100)
    {
        return _mapper.Map<List<ReadGridDto>>(_context.Grid.Skip(skip).Take(Take));
    }

    [HttpGet("{id}")]
    public IActionResult GetGridPID(int id)
    {
       var grid = _context.Grid.FirstOrDefault(grid=>grid.Id == id);
        if(grid == null)return NotFound();
        var gridDto = _mapper.Map<ReadGridDto>(grid);
        return Ok(gridDto);
    }

    [HttpPut("{id}")]

    public IActionResult PutGrid(int id, [FromBody] UpgradeGridDto gridDto)
    {
        var grid = _context.Grid.FirstOrDefault(grid => grid.Id == id);
        if(grid == null)return NotFound();
        _mapper.Map(gridDto, grid);
        _context.SaveChanges();
        return NoContent();
    }
    [HttpPatch("{id}")]

    public IActionResult PatchGrid(int id, JsonPatchDocument<UpgradeGridDto> patch )
    {
        var grid = _context.Grid.FirstOrDefault(grid => grid.Id == id);
        if (grid == null) return NotFound();

        var gridToPatch = _mapper.Map<UpgradeGridDto>(grid);

        patch.ApplyTo(gridToPatch,ModelState);

        if(!TryValidateModel(gridToPatch)) return ValidationProblem(ModelState);
        _mapper.Map(gridToPatch, grid);

        _context.SaveChanges();
        return NoContent();
    }


}

