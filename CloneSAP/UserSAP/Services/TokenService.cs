using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserSAP.Models;

namespace UserSAP.Services;

public class TokenService
{
    public string GenerateToken(User user)
    {
        Claim[] claims = new Claim[]
        {
            new Claim("username",user.UserName),
            new Claim("Id",user.Id),
            new Claim(ClaimTypes.DateOfBirth, user.DateOfBirth.ToString())

        };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("A8SDU9ASDISAUD7AS6DASHFCZ9IASDASD9USA7DY7SAD"));

        var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken
        (
            expires: DateTime.Now.AddMinutes(10),
            claims: claims,
            signingCredentials: signingCredentials
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
