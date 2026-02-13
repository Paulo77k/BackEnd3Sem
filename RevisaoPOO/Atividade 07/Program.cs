class Program
{
    static void Main()
    {
        Veiculo v1 = new Carro();
        Veiculo v2 = new Bicicleta();

        v1.Mover(); 
        v2.Mover(); 
        Console.ReadLine();
    }
}