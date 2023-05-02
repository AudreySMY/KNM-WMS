﻿using CloneSAP_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CloneSAP_API.Data;

public class SAPContext:DbContext
{
	public SAPContext(DbContextOptions<SAPContext> opts):base(opts){}

	public DbSet<Material> Material { get; set; }
}
