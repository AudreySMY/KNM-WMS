using AutoMapper;
using KNM_API.Data;
using KNM_API.Data.Dtos;
using KNM_API.Data.Dtos.CreateDtos;
using KNM_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KNM_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class PositionController : ControllerBase 
    {
        private IMapper _Mapper;
        private KNMContext _Context;

        public PositionController(IMapper mapper, KNMContext context)
        {
            _Mapper = mapper;
            _Context = context;
        }

        [HttpPost]
        public IActionResult PostPosition([FromBody] CreatePositionDto positionDto)
        {   
            Position position = _Mapper.Map<Position>(positionDto);
            if (position == null) NotFound();
            _Context.Position.Add(position);
            _Context.SaveChanges();
            return Ok(position);
            
        }
        [HttpGet]
        public IEnumerable<ReadPositionDto> GetPosition() {
            return _Mapper.Map<List<ReadPositionDto>>(_Context.Position.ToList());
        }
    }
}
