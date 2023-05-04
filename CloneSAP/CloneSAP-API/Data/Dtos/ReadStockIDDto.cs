using CloneSAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class ReadStockIDDto
{

    public int stockIDupc;

    public int materialId;
    public virtual ReadMaterialDto material { get; set; }

    public int gridId;
    public virtual ReadGridDto grid { get; set; }
}
