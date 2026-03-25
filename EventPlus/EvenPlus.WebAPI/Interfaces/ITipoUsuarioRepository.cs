using EvenPlus.WebAPI.Models;


namespace EvenPlus.WebAPI.Interfaces;

public interface ITipoUsuarioRepository
{
    void Cadastrar(Usuario tipoUsuario);
    void Deletar(Guid id);
    List<TipoUsuario> Listar();
    TipoUsuario BuscarPorId(Guid id);
    void Atualizar(Guid id, TipoUsuario tipoUsuario);
    void Cadastrar(TipoUsuario novoTipoUsuario);
}
