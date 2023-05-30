using System;
using System.ComponentModel.DataAnnotations;

namespace KNM_API.Models;

public class StorageUnit
{
    [Key]
    public int Label { get; set; }
    public int EanID { get; set; }
    public virtual Ean Ean { get; set; }
    public int Quantity { get; set; }

    public DateTime CreatingDating { get; set; }
    public DateTime LastModif { get; set; }

}
