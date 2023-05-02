using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class ReadMaterialDto
{

    public int Id { get; set; }
    public string material { get; set; }
    public float volume { get; set; }
}



