class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa();

        p.Nome = "Paulo";
        p.Idade = 25;   // válido
        p.Idade = -3;   // inválido, não altera

        p.ExibirDados();

        Console.ReadLine();
    }
}