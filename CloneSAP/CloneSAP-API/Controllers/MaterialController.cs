using AutoMapper;
using CloneSAP_API.Data;
using CloneSAP_API.Data.Dtos;
using CloneSAP_API.Models;
using Microsoft.AspNetCore.Mvc;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;

namespace CloneSAP_API.Controllers;


[ApiController]
[Route("[Controller]")]
public class MaterialController : Controller
{
    private SAPContext _context;
    private IMapper _mapper;

    public MaterialController(SAPContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public void PostMaterial([FromBody] CreateMaterialDto MaterialDto)
    {
        Material material = _mapper.Map<Material>(MaterialDto);

        _context.Material.Add(material);
        _context.SaveChanges();

    }

    [HttpGet]
    public IEnumerable<ReadMaterialDto> GetMaterials([FromQuery] int skip = 0, [FromQuery] int Take = 100)
    {
        return _mapper.Map<List<ReadMaterialDto>>(_context.Material.Skip( skip ).Take( Take ));
    }

}

