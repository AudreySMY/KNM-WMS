using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class ReadGridDto
{
    public int gridId { get; set; }
    public string CollorCod { get; set; }
    public string SizeCod { get; set; }

}
