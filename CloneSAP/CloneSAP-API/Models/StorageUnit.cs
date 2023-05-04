using System;
using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Models;

public class StorageUnit
{
    [Key]
    public int Id { get; set; }
    public int SIID { get; set; }
    public virtual StockID SI { get; set; }
    public int quantity { get; set; }

    public DateTime CreatingDating { get; set; }
    public DateTime LastModif { get; set; }

}
