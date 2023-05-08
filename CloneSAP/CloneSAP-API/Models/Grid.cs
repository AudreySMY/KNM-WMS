using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Models
{
    public class Grid
    {


        [Key]
        public int Id { get; set; }
        [Required]
        public string GridCod { get; set; }

        public virtual ICollection<StockID> StockIDs { get; set; }

    }
}
