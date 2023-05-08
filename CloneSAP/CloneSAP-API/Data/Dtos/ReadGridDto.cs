using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class ReadGridDto
{
    public int gridId { get; set; }
    public string gridCod { get; set; }

}
