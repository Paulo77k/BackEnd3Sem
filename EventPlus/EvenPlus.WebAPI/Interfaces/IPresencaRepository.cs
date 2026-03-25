using EvenPlus.WebAPI.Models;

namespace EvenPlus.WebAPI.Interfaces;

public interface IPresencaRepository
{
    void Inscrever(Presenca presenca);
    void Deletar(Guid id);
    List<Presenca> Listar();
    Presenca BuscarPorId(Guid id);
    void Atualizar(Guid id);
    List<Presenca> ListarMinhas(Guid IdUsuario);
    object? ListarMinhas(object idUsuario);
}
