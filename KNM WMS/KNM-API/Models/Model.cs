using System.ComponentModel.DataAnnotations;

namespace KNM_API.Models;

public class Model
{
    [Key]
    [Required(ErrorMessage = "O MATERIAL E OBRIGATORIO")]
    [MaxLength(10, ErrorMessage = "o tamanho maximo do material e 10 characters")]
    public string ModelCod { get; set; }
    [Required]
    public float Volume { get; set; }


}

