using KNM_API.Models;
using Microsoft.EntityFrameworkCore;

namespace KNM_API.Data;

public class KNMContext:DbContext
{
	public KNMContext(DbContextOptions<KNMContext> opts):base(opts){}

	public DbSet<Model> Model { get; set; }
    public DbSet<Grid> Grid { get; set; }
    public DbSet<Ean> Ean { get; set; }
    public DbSet<StorageUnit> StorageUnit { get; set; }
    public DbSet<Position> Position { get; set; }
}

