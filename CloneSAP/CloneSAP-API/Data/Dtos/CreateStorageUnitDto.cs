using CloneSAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class CreateStorageUnitDto
{
    [Key]
    [Required]
    public int Id { get; set; }
    public int SIID { get; set; }
    [Required]
    public int quantity { get; set; }

    public DateTime CreatingDating { get; set; } = DateTime.Now;
}
