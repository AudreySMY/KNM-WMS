using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Models;

public class StorageUnit
{
    [Key]
    [Required]
    [MaxLength(10)]
    public int SU { get; set; }

    [Required]
    public int stockIDupc;
    public virtual StockID StockID { get; set; }

    
    [Required]
    [Range(0,9999999999)]
    public int quantity { get; set; }

}
