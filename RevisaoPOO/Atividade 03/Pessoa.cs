namespace Atividade_03
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
            {
                idade = value;
            }
            else
            {
                Console.WriteLine("Idade inválida! Deve ser maior que zero.");
            }
        }
    }

    
    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
    }
    }
}