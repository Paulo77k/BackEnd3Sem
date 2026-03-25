using System.ComponentModel.DataAnnotations;

namespace EvenPlus.WebAPI.DTO;

public class PresencaDTO
{
    [Required(ErrorMessage = "O titulo do tipo de evento e obrigatorio!")]
    public string? TituloPresenca { get; set; }
  
    
        public bool Situacao { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdEvento { get; set; }
    }

