using System;
namespace OCP1poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Integral funcionarioIntegral = new Integral("João", 3000);
            Parcial funcionarioParcial = new Parcial("Maria", 1500, 80);
            FreeLancer funcionarioFreeLancer = new FreeLancer("Pedro", 500, 5);
            
            funcionarioIntegral.CalcularSalario();
            funcionarioParcial.CalcularSalario();
            funcionarioFreeLancer.CalcularSalario();

            Console.WriteLine($"Salário do funcionário integral: {funcionarioIntegral.CalcularSalario()}");
            Console.WriteLine($"Salário do funcionário parcial: {funcionarioParcial.CalcularSalario()}");
            Console.WriteLine($"Salário do funcionário free lancer: {funcionarioFreeLancer.CalcularSalario()}");
        }
    }
}