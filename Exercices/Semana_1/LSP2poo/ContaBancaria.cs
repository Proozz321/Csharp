using System;
namespace LSP2poo{
    
    public abstract class ContaBancaria
    {
        public double Valor { get; set; }

        public ContaBancaria(double Valor)
        {
            this.Valor = Valor;
        }

        public abstract void Depositar(double Valor);

        public abstract void ConsultarSaldo();
    }
}