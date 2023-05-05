using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class UpgradeGridDto
{

    [Required]
    public string CollorCod { get; set; }
    [Required]
    public string SizeCod { get; set; }
    [Required]
    public int gridId { get; set; }



}
