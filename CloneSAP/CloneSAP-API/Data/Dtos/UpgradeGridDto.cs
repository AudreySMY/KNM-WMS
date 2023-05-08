using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class UpgradeGridDto
{

    [Required]
    public string gridCod { get; set; }
    [Required]
    public int gridId { get; set; }



}
