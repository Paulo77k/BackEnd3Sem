using System;

class Pessoa
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

    // Construtor
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

    // Sem parâmetros
    public void Apresentar()
    {
        Console.WriteLine("Olá, meu nome é " + Nome);
    }

    // Com sobrenome (sobrecarga)
    public void Apresentar(string sobrenome)
    {
        Console.WriteLine("Olá, meu nome é " + Nome + " " + sobrenome);
    }
}