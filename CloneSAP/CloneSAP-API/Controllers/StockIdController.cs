using AutoMapper;
using CloneSAP_API.Data;
using CloneSAP_API.Models;
using Microsoft.AspNetCore.Mvc;
using CloneSAP_API.Data.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace CloneSAP_API.Controllers;

[ApiController]
[Route("[Controller]")]
public class StockIdController : ControllerBase
{
    private SAPContext _context;
    private IMapper _mapper;

    public StockIdController(SAPContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public IActionResult PostStockID([FromBody] CreateStockIDDto stockIDDto)
    {
        StockID stockID = _mapper.Map<StockID>(stockIDDto);
        if(stockID == null)return NotFound();
        _context.StockID.Add(stockID);
        _context.SaveChanges();
        return Ok(stockID);

    }

    [HttpGet]
    public IEnumerable<ReadStockIDDto> GetGrid([FromQuery]string? grid = null, [FromQuery]string? material= null)
    {
        if (grid is not null && material is null)
            return _mapper.Map<List<ReadStockIDDto>>(
                _context.StockID.Where(stockid =>
                stockid.Grid.GridCod == grid)
                .ToList());

        if (grid is null && material is not null)
            return _mapper.Map<List<ReadStockIDDto>>(_context.StockID
                .Where(stockid =>stockid.Material.material == material)
                .ToList());
       

        if (grid is not null && material is not null)
            return _mapper.Map<List<ReadStockIDDto>>(_context.StockID
                .Where(stockid => stockid.Material.material == material && stockid.Grid.GridCod == grid)
                .ToList());

        return _mapper.Map<List<ReadStockIDDto>>(
            _context.StockID
            .ToList());
}

    [HttpGet("{id}")]

    public IActionResult GetStockIDPID(int id)
    {
        var stockid = _context.StockID.FirstOrDefault(stockid => stockid.ID == id);
        if (stockid == null) return NotFound();
        var stockidDto = _mapper.Map<ReadStockIDDto>(stockid);
        return Ok(stockidDto);
    }

    [HttpPut("{id}")]

    public IActionResult PutStockID(int id, [FromBody] UpgradeStockIDDto stockidDto)
    {
        var stockid = _context.StockID.FirstOrDefault(stockid => stockid.ID == id);
        if (stockid == null) return NotFound();
        _mapper.Map(stockidDto, stockid);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]

    public IActionResult PatchstockidD(int id, JsonPatchDocument<UpgradeStockIDDto> patch)
    {
        var stockid = _context.StockID.FirstOrDefault(stockid => stockid.ID == id);
        if (stockid == null) return NotFound();

        var stockidToPatch = _mapper.Map<UpgradeStockIDDto>(stockid);

        patch.ApplyTo(stockidToPatch, ModelState);
        if (!TryValidateModel(stockidToPatch)) return ValidationProblem(ModelState);
        _mapper.Map(stockidToPatch, stockid);

        _context.SaveChanges();
        return NoContent();
    }
}

