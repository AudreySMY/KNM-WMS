using CloneSAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Data.Dtos;

public class ReadStorageUnitDto
{
    public int SU { get; set; }
    public int quantity { get; set; }
}
