using EvenPlus.WebAPI.BdContextEvent;
using EvenPlus.WebAPI.Interfaces;
using EvenPlus.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EvenPlus.WebAPI.Repositoryes;

public class PresencaRepository : IPresencaRepository
{
    private readonly EventContext _eventContext;

    public PresencaRepository(EventContext eventContext)
    {
        _eventContext = eventContext; 
    }
    /// <summary>
    /// Metodo que alterna a situacao da presenca
    /// </summary>
    /// <param name="id">Id da presenca a ser alterada</param>
    public void Atualizar(Guid id)
    {
        var presencaBuscada = _eventContext.Presencas.Find(id);

        if(presencaBuscada != null)
        {
            presencaBuscada.Situacao = !presencaBuscada.Situacao;

            _eventContext.SaveChanges();
        }
    }
    /// <summary>
    /// Metodo que busca uma presenca por id
    /// </summary>
    /// <param name="id">Id da presenca a ser buscada</param>
    /// <returns>Presenca buscada</returns>
    public Presenca BuscarPorId(Guid id)
    {
        return _eventContext.Presencas
            .Include(p => p.IdEventoNavigation)
            .ThenInclude(e => e!.IdInstituicaoNavigation)
            .FirstOrDefault(p => p.IdPresenca == id)!;
    }

    public void Deletar(Guid id)
    {
        
    }

    public void Inscrever(Presenca presenca)
    {
        throw new NotImplementedException();
    }

    public List<Presenca> Listar()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Metodo que lista as presencas de um usuario especifico
    /// </summary>
    /// <param name="IdUsuario">Id do usuario para filtragem</param>
    /// <returns>Lista de presencas de um usuario</returns>
    public List<Presenca> ListarMinhas(Guid IdUsuario)
    {
        return _eventContext.Presencas
            .Include (p => p.IdEventoNavigation)
            .ThenInclude(e => e!.IdInstituicaoNavigation)
            .Where(p => p.IdUsuario == IdUsuario)
            .ToList();
    }

    public object? ListarMinhas(object idUsuario)
    {
        throw new NotImplementedException();
    }
}
