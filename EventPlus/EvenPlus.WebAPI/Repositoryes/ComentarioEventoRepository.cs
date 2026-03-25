using EvenPlus.WebAPI.BdContextEvent;
using EvenPlus.WebAPI.Interfaces;
using EvenPlus.WebAPI.Models;

using Microsoft.EntityFrameworkCore;

namespace EventPlus.WebAPI.Repositories;

public class ComentarioEventoRepository : IComentarioEventoRepository
{
    public readonly EventContext _context;

    public ComentarioEventoRepository(EventContext context)
    {
        _context = context;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="IdUsuario"></param>
    /// <param name="IdEvento"></param>
    /// <returns></returns>
    public ComentarioEvento BuscarPorIdUsuario(Guid IdUsuario, Guid IdEvento)
    {
        return _context.ComentarioEventos.Include(c => c.IdUsuarioNavigation).FirstOrDefault(c => c.IdUsuario == IdUsuario && c.IdEvento == IdEvento)!;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="comentarioEvento"></param>
    public void Cadastrar(ComentarioEvento comentarioEvento)
    {
        _context.ComentarioEventos.Add(comentarioEvento);
        _context.SaveChanges();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="IdComentarioEvento"></param>
    public void Deletar(Guid IdComentarioEvento)
    {
        var comentarioBuscado = _context.ComentarioEventos.Find(IdComentarioEvento);

        if (comentarioBuscado != null)
        {
            _context.ComentarioEventos.Remove(comentarioBuscado);
            _context.SaveChanges();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="IdEvento"></param>
    /// <returns></returns>
    public List<ComentarioEvento> List(Guid IdEvento)
    {
        return _context.ComentarioEventos.OrderBy(c => c.Descricao).ToList();
    }

    public List<ComentarioEvento> ListarSomenteExibe(Guid IdEvento)
    {
        return _context.ComentarioEventos.Where(c => c.IdEvento == IdEvento).ToList();
    }
}

