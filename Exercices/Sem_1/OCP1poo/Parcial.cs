using System;
namespace OCP1poo
{
    class Parcial : aFuncionario, Isalario
    {
        public int HorasTrabalhadas { get; set; }

        public Parcial(string nome, double salario, int horasTrabalhadas) : base(nome, salario)
        {
            this.HorasTrabalhadas = horasTrabalhadas;
        }
        public override double CalcularSalario()
        {
            return (Salario / 160) * HorasTrabalhadas;
        }
    }
}