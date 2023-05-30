using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos.UpdateDtos;

public class UpgradeGridDto
{

    [Required]
    public string Cod { get; set; }
    [Required]
    public int gridId { get; set; }



}
