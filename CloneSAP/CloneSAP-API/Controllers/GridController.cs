using AutoMapper;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using CloneSAP_API.Models;

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

    public void PostGrid([FromBody] CreateGridDto gridDto)
    {
        Grid grid = _mapper.Map<Grid>(gridDto);

        _context.Grid.Add(grid);
        _context.SaveChanges();

    }

    [HttpGet]
    public IEnumerable<ReadGridDto> GetGrid([FromQuery] int skip = 0, [FromQuery] int Take = 100)
    {
        return _mapper.Map<List<ReadGridDto>>(_context.Grid.Skip(skip).Take(Take));
    }


}

