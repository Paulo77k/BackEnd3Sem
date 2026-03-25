using System.ComponentModel.DataAnnotations;

namespace EvenPlus.WebAPI.DTO;

public class TipoUsuarioDTO
{
    [Required(ErrorMessage = "O nome do usuario e obrigatorio!" )]
    public string? Nome { get; set; }
    [Required(ErrorMessage = "O Email do usuario e obrigatorio!")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "A senha do usuario e obrigatorio!")]
    public string? Senha { get; set; }
    
    public Guid IdTipoUsuario { get; set; }

}