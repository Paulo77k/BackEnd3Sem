class Administrador : IAutenticavel
{
    public string Nome;
    private string senha = "admin";

    public Administrador(string nome)
    {
        Nome = nome;
    }

    public bool Autenticar(string senha)
    {
        return this.senha == senha;
    }
}