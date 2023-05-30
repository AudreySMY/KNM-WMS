using KNM_API.Models;
using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos;

public class ReadEanDto
{
    public int EanID { get; set; }


    
    

    public string ModelId { get; set; }
    public virtual ReadModelDto Model { get; set; }


    public string GridId { get; set; }
    public virtual ReadGridDto Grid { get; set; }
}
