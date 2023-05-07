using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserSAP.Data;
using UserSAP.Data.Dtos;
using UserSAP.Models;
using UserSAP.Services;

namespace UserSAP.Controllers;

[ApiController]
[Route("[Controller]")]
public class UserController : ControllerBase
{
   private UserService _userService;

    public UserController(UserService registerService)
    {
        _userService = registerService;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> RegisterUser(CreateUserDto dto)
    {
        await _userService.Register(dto);
        return Ok("Usuario cadastrado");
    }
    [HttpPost("Login")]
    public IActionResult Login(LoginUserDto dto)
    {
        _userService.Login(dto);
        return Ok("Login OK");
    }
}
