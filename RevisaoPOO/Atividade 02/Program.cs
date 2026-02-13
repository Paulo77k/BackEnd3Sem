class Program
{
    static void Main()
    {
       
        Pessoa p = new Pessoa();

        
        p.Nome = "Paulo";
        p.Idade = 25;

        
        p.ExibirDados();

        Console.ReadLine(); 
    }
}