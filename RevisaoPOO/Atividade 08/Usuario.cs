class Usuario : IAutenticavel
{
    public string Nome;
    private string senha = "1234";

    public Usuario(string nome)
    {
        Nome = nome;
    }

    public bool Autenticar(string senha)
    {
        return this.senha == senha;
    }
}