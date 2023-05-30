using System.ComponentModel.DataAnnotations;

namespace KNM_API.Models;

public class Ean
{
    [Key]
    public int EanID { get; set; }


    public string ModelId { get; set; }
    public virtual Model Model { get; set; }


    public string GridId { get; set; }
    public virtual Grid Grid { get; set; }


}
