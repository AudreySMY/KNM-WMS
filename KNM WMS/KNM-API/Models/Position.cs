

using System.ComponentModel.DataAnnotations;

namespace KNM_API.Models
{   
    public class Position
    {
        [Key]
        [Required]
        public string IdentifierPos { get; set; } 
        public float VolumeMax { get; set; }
        public int EanID { get; set; }
        public virtual Ean Ean { get; set; }

    }
}
