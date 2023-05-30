using KNM_API.Models;
using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos.UpdateDtos;

public class UpgradeStorageUnitDto
{
    [Key]
    public int Id { get; set; }
    public int SIID { get; set; }
    [Required]
    public int Quantity { get; set; }

    public DateTime CreatingDating { get; set; } = DateTime.Now;
    public DateTime LastModif { get; set; } = DateTime.Now;
}
