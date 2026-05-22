using System;
namespace OCP1poo
{
    abstract class aFuncionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public aFuncionario(string nome, double salario)
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        public abstract double CalcularSalario();
    } 
}