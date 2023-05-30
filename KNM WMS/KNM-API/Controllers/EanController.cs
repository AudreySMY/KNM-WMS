using AutoMapper;
using KNM_API.Data;
using KNM_API.Models;
using Microsoft.AspNetCore.Mvc;
using KNM_API.Data.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Data.Dtos.UpdateDtos;

namespace KNM_API.Controllers;

[ApiController]
[Route("[Controller]")]
public class EanController : ControllerBase
{
    private KNMContext _context;
    private IMapper _mapper;

    public EanController(KNMContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public IActionResult PostEan([FromBody] CreateEanDto stockIDDto)
    {
        Ean stockID = _mapper.Map<Ean>(stockIDDto);
        if(stockID == null)return NotFound();
        _context.Ean.Add(stockID);
        _context.SaveChanges();
        return Ok(stockID);

    }

    [HttpGet]
    public IEnumerable<ReadEanDto> GetEan()
    {

           return _mapper.Map<List<ReadEanDto>>(_context.Ean.ToList());

    }

    [HttpGet("{id}")]

    public IActionResult GetEanPID(int id)
    {
        var ean = _context.Ean.FirstOrDefault(ean => ean.EanID == id);
        if (ean == null) return NotFound();
        var stockidDto = _mapper.Map<ReadEanDto>(ean);
        return Ok(stockidDto);
    }

    [HttpPut("{id}")]

    public IActionResult PutEan(int id, [FromBody] UpgradeStockIDDto stockidDto)
    {
        var ean = _context.Ean.FirstOrDefault(ean => ean.EanID == id);
        if (ean == null) return NotFound();
        _mapper.Map(stockidDto, ean);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]

    public IActionResult PatchEan(int id, JsonPatchDocument<UpgradeStockIDDto> patch)
    {
        var ean = _context.Ean.FirstOrDefault(ean => ean.EanID == id);
        if (ean == null) return NotFound();

        var stockidToPatch = _mapper.Map<UpgradeStockIDDto>(ean);

        patch.ApplyTo(stockidToPatch, ModelState);
        if (!TryValidateModel(stockidToPatch)) return ValidationProblem(ModelState);
        _mapper.Map(stockidToPatch, ean);

        _context.SaveChanges();
        return NoContent();
    }
}

