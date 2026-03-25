using EvenPlus.WebAPI.BdContextEvent;
using EvenPlus.WebAPI.Interfaces;
using EvenPlus.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EvenPlus.WebAPI.Repositoryes;

public class EventoRepository : IEventoRepository
{
    private readonly EventContext _context;
    public EventoRepository(EventContext context)
    {
        _context = context; 
    }
    public void Atualizar(Guid id, Evento evento)
    {
        throw new NotImplementedException();
    }

    public Evento BuscarPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Evento evento)
    {
        throw new NotImplementedException();
    }

    public void Deletar(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Evento> Listar()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Metodo que lista eventos filtrando pelas presencas de um usuario
    /// </summary>
    /// <param name="IdUsuario">Id do usuario para filtragem</param>
    /// <returns>Lista de eventos filtrados por um usuario</returns>
    public List<Evento> ListarPorId(Guid IdUsuario)
    {
        return _context.Eventos.Include(e => e.IdTipoEventoNavigation)
            .Include(e => e.IdInstituicaoNavigation)
            .Where(e => e.Presencas.Any(p => p.IdUsuario == IdUsuario ))//&& p.Situacao == true))
            .ToList();
    }
    /// <summary>
    /// Metodo que buscar proximos eventos que irao acontecer 
    /// </summary>
    /// <returns>Lista de proximos eventos</returns>
    public List<Evento> ListarProximos()
    {
      return  _context.Eventos
            .Include(e => e.IdTipoEventoNavigation)
            .Include(e => e.IdInstituicaoNavigation)
            .Where(e => e.DataEvento >= DateTime.Now)
            .OrderBy(e => e.DataEvento)
            .ToList();
    }
}
