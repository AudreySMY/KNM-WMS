using KNM_API.Models;
using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos.CreateDtos;

public class CreateEanDto
{
    [Key]

    public int EanID { get; set; }
    public string ModelId { get; set; }
    public string GridId { get; set; }
}
