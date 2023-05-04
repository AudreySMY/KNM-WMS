using CloneSAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class ReadStorageUnitDto
{
    public int Id { get; set; }
    public virtual ReadStockIDDto SI { get; set; }
    public int quantity { get; set; }
    public DateTime CreatingDating { get; set; };
}
