
class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa("Paulo", 25);

        p.Apresentar();
        p.Apresentar("Vieira");

        Console.ReadLine();
    }
}