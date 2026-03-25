using System.ComponentModel.DataAnnotations;

namespace EvenPlus.WebAPI.DTO;

public class UsuarioDTO
{
    [Required(ErrorMessage = "O titulo do tipo de evento é obrigatório!")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O Nome do usuario e obrigatorio")]
    public object Nome { get; internal set; }

    [Required(ErrorMessage = " A senha do usuario e obrigatorio")]
    public object Senha { get; internal set; }
    public Guid? IdTipoUsuario { get; internal set; }
}
