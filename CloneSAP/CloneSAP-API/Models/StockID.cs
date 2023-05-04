using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Models;

public class StockID
{
    [Key]
    public int ID { get; set; }


    public int MaterialId { get; set; }
    public virtual Material Material { get; set; }


    public int GridId { get; set; }
    public virtual Grid Grid { get; set; }


}
