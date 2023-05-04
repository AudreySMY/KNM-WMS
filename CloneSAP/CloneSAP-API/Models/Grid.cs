using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Models
{
    public class Grid
    {


        [Key]
        public int Id { get; set; }
        [Required]
        public string CollorCod { get; set; }
        [Required]
        public string SizeCod { get; set; }

        public virtual ICollection<StockID> StockIDs { get; set; }


    }
}
