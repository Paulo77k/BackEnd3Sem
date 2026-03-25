using System.ComponentModel.DataAnnotations;

namespace EvenPlus.WebAPI.DTO;

public class EventoDTO
{
    [Required(ErrorMessage = "O titulo do tipo de evento e obrigatorio!")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O Nome do evento e obrigatorio!")]
    public string? Nome { get; set; }
    [Required(ErrorMessage = " A Descricao do evento e obrigatorio")]
    public string Descricao { get; internal set; }
    [Required(ErrorMessage = " A Data do evento e obrigatorio")]
    public Guid IdTipoEvento { get; set; }
    public DateTime DataEvento { get; set; }
    public Guid Idinstituicao { get; set; }
}
