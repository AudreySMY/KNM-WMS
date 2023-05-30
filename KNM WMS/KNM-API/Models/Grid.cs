using System.ComponentModel.DataAnnotations;

namespace KNM_API.Models
{
    public class Grid
    {


        [Key]
        [Required]
        public string GridCod { get; set; }


    }
}
