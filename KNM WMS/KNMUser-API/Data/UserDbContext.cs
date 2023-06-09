﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserSAP.Models;

namespace UserSAP.Data;

public class UserDbContext : IdentityDbContext<User>
{
	public UserDbContext(DbContextOptions<UserDbContext> opts) : base(opts)
	{

	}
}
