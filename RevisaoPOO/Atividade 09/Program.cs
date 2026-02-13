class Program
{
    static void Main()
    {
        // Chamadas sem instanciar objeto
        int soma = Calculadora.Somar(10, 5);
        int mult = Calculadora.Multiplicar(4, 3);

        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Multiplicação: " + mult);

        Console.ReadLine();
    }
}