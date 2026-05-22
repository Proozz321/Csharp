using System;
namespace OCP1poo
{
    class FreeLancer : aFuncionario,Isalario
    {
        public int ProjetosConcluidos { get; set; }

        public FreeLancer(string nome, double salario, int projetosConcluidos) : base(nome, salario)
        {
            this.ProjetosConcluidos = projetosConcluidos;
        }
        public override double CalcularSalario()
        {
            return Salario * ProjetosConcluidos;
        }
    }
}