using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos.UpdateDtos;

public class UpgradeMaterialDto
{

    [Required(ErrorMessage = "O MATERIAL E OBRIGATORIO")]
    [MaxLength(10, ErrorMessage = "o tamanho maximo do material e 10 characters")]
    public string Material { get; set; }
    [Required]
    public float Volume { get; set; }
}

