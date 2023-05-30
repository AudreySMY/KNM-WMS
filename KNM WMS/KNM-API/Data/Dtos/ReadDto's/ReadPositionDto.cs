using KNM_API.Models;

namespace KNM_API.Data.Dtos
{
    public class ReadPositionDto
    {

        public string IdentifierPos { get; set; }
        public float VolumeMax { get; set; }
        public int EanID { get; set; } 
        public virtual ReadEanDto EanDto { get; set; }
    }
}
