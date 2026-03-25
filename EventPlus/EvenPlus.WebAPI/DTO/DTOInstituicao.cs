using System.ComponentModel.DataAnnotations;

namespace EvenPlus.WebAPI.DTO;

public class DTOInstituicao
{
    [Required(ErrorMessage = "O titulo do tipo de evento é obrigatório!")]
    public string? NomeFantasia { get; set; }

    [Required(ErrorMessage = "O cnpj do usuario é obrigatório!")]
    public string? CNPJ { get; set; }
    [Required(ErrorMessage = "O endereco do usuario é obrigatório!")]
    public string? Endereco { get; set; }
}
