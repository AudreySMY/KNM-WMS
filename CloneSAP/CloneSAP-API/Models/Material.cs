using System.ComponentModel.DataAnnotations;

namespace CloneSAP_API.Models;

public class Material
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O MATERIAL E OBRIGATORIO")]
    [MaxLength(10,ErrorMessage ="o tamanho maximo do material e 10 characters")]
    public string material { get; set; }
    [Required]
    public float volume { get; set; }
}

