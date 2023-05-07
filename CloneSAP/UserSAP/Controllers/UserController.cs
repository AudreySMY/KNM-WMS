using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserSAP.Data;
using UserSAP.Data.Dtos;
using UserSAP.Models;

namespace UserSAP.Controllers;

[ApiController]
[Route("[Controller]")]
public class UserController : ControllerBase
{
    public IMapper _mapper;
    public UserManager<User> _userManager;

    public UserController(IMapper mapper, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterUser(CreateUserDto dto)
    {
        User user = _mapper.Map<User>(dto);
        IdentityResult resultado = await _userManager.CreateAsync(user,dto.Password);

        if(resultado.Succeeded)return Ok(user);
        throw new ApplicationException("Falha Ao cadastrar usuario");
    }
}
