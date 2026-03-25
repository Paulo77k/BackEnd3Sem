using EvenPlus.WebAPI.Models;


namespace EvenPlus.WebAPI.Interfaces
{
    public interface IUsuarioRepository
    {
        public Usuario BuscarPorEmailESenha(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(Guid IdUsuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
