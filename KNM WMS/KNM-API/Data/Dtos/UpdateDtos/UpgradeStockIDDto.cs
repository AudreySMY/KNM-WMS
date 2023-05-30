using KNM_API.Models;
using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos.UpdateDtos;

public class UpgradeStockIDDto
{
    [Key]
    [Required]
    public int StockIDn { get; set; }

    [Required]
    public int MaterialId { get; set; }
    [Required]
    public int GridId { get; set; }
}
