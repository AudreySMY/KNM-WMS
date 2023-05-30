using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserSAP.Models;

public class User : IdentityUser
{
    public DateTime DateOfBirth { get; set; }
	public User() : base(){}

}