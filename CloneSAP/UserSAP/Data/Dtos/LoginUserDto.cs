using Microsoft.Build.Framework;

namespace UserSAP.Data.Dtos;

public class LoginUserDto
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}
