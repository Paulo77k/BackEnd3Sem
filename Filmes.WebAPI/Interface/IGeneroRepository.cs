using Filmes.WebAPI.Models;

namespace Filmes.WebAPI.Interface
{
    public interface IGeneroRepository
    {
        void Cadastrar(TbGenero novoGenero);
            List<TbGenero> Listar();
        void AtualizarIdCorpo(TbGenero generoAtualizado);
        void AtualizarIdUrl(Guid id, TbGenero genero);
        void Deletar(Guid id);
        TbGenero BuscarPorId(Guid id);

    }
}
