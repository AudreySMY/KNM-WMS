using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UserSAP.Data.Dtos;
using UserSAP.Models;

namespace UserSAP.Services;

public class UserService
{
    public IMapper _mapper;
    public UserManager<User> _userManager;
    public UserService _registerService;
    private SignInManager<User> _signInManager;
    private TokenService _tokenService;


    public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, TokenService tokenService)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = tokenService;
    }

    

    public async Task Register(CreateUserDto dto)
    {
        User user = _mapper.Map<User>(dto);
        IdentityResult resultado = await _userManager.CreateAsync(user, dto.Password);

        if (!resultado.Succeeded) throw new ApplicationException("Falha Ao cadastrar usuario");
        
    }

    public async Task<string> Login(LoginUserDto dto)
    {
       var resultado = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password,false,false);
        if (!resultado.Succeeded)
        {
            throw new ApplicationException($"Failed to login {dto.UserName}");
        }

        var user = _signInManager.UserManager.Users.FirstOrDefault(user => user.NormalizedUserName == dto.UserName.ToUpper());
        var token = _tokenService.GenerateToken(user);
        return token;
    }

    
}
