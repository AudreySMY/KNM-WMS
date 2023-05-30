using KNM_API.Models;
using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos.CreateDtos;

public class CreateGridDto
{

    [Key]
    [Required]
    public string GridCod { get; set; }



}
