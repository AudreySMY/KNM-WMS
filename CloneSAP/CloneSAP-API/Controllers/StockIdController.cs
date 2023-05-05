using AutoMapper;
using CloneSAP_API.Data;
using CloneSAP_API.Models;
using Microsoft.AspNetCore.Mvc;
using CloneSAP_API.Data.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace CloneSAP_API.Controllers;

[ApiController]
[Route("[Controller]")]
public class StockIdController : Controller
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
    public IEnumerable<ReadStockIDDto> GetGrid([FromQuery] int skip = 0, [FromQuery] int Take = 100)
    {
        return _mapper.Map<List<ReadStockIDDto>>(_context.StockID.Skip(skip).Take(Take).ToList());
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

