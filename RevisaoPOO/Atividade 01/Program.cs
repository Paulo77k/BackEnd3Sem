using Atividade_01;

class Program
{
    static void Main()
    {
       
        Pessoa p = new Pessoa ();

        
        p.Nome = "Paulo";
        p.Idade = 25;

        
        Console.WriteLine("Nome: " + p.Nome);
        Console.WriteLine("Idade: " + p.Idade);

        Console.ReadLine(); 
    }
}