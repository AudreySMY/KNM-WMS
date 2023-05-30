using KNM_API.Models;
using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos.CreateDtos;

public class CreateStorageUnitDto
{
    [Key]
    public int Label { get; set; }
    public int EanID { get; set; }
    public int Quantity { get; set; }

    public DateTime CreatingDating { get; set; }
    public DateTime LastModif { get; set; }
}
