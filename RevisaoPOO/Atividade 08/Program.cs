class Program
{
    static void Main()
    {
        IAutenticavel u = new Usuario("Paulo");
        IAutenticavel a = new Administrador("Root");

        Console.WriteLine("Usuário autenticado? " + u.Autenticar("1234"));
        Console.WriteLine("Admin autenticado? " + a.Autenticar("admin"));

        Console.ReadLine();
    }
}
