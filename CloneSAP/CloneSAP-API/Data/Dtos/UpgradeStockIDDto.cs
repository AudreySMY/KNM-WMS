using CloneSAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

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
