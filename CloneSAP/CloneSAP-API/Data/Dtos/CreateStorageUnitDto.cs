using CloneSAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class CreateStorageUnitDto
{

    public int SU { get; set; }

    [Required]
    [Range(0, 9999999999)]
    public int quantity { get; set; }
}
