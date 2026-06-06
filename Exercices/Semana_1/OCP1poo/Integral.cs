using System;
namespace OCP1poo
{
    class Integral : aFuncionario, Isalario
    {
        public Integral(string nome, double salario) : base(nome, salario)
        {
        }

        public override double CalcularSalario()
        {
            return Salario;
        }
    }
}