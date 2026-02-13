class Funcionario : Pessoa
{
    public double Salario;

   
    public Funcionario(string nome, int idade, double salario)
        : base(nome, idade)
    {
        Salario = salario;
    }

  
    public void ExibirFuncionario()
    {
        ExibirDados();
        Console.WriteLine("Salário: R$ " + Salario);
    }
}