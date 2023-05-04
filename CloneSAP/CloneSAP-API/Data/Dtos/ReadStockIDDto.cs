using CloneSAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class ReadStockIDDto
{

    public int stockIDn { get; set; }

    public int materialId { get; set; }
    public virtual ReadMaterialDto material { get; set; }


    public int gridId { get; set; }
    public virtual ReadGridDto grid { get; set; }
}
