namespace Atividade_5
{
    public class Pessoa
    {
         public string Nome;
    private int idade;

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value > 0)
                idade = value;
            else
                Console.WriteLine("Idade inválida!");
        }
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
    }
    }
}