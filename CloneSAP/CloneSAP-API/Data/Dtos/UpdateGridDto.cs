using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class UpdateGridDto
{
    [Required]
    public string CollorCod { get; set; }
    [Required]
    public string SizeCod { get; set; }
}

