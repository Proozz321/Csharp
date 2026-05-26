using System;

namespace LSP2poo{
    
    public class ContaCorrente : ContaBancaria, IContas
    {
        public double saldo;
        public double valor { get; set; }

        public ContaCorrente(double valor) : base(valor)
        {
            this.valor = valor;
        }

        public override void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Levantar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public override void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}