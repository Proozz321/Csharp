using System;
namespace LSP2poo
{
    public class ContaPoupança : ContaBancaria
    {
        public double saldo;

        public ContaPoupança(double Valor) : base(Valor)
        {
            this.Valor = Valor;
        }
        public override void Depositar(double Valor)
        {
            saldo += Valor;
        }

        public override void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}

using System;
namespace LSP2poo
{
    public class ContaPoupança : ContaBancaria
    {
        public double saldo;

        public ContaPoupança(double Valor) : base(Valor)
        {
            this.Valor = Valor;
        }
        public override void Depositar(double Valor)
        {
            saldo += Valor;
        }

        public override void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}