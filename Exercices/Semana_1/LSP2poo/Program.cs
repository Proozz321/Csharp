using System;
namespace LSP2poo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(0);
            contaCorrente.Depositar(1000);
            contaCorrente.ConsultarSaldo();
            contaCorrente.Levantar(500);
            contaCorrente.ConsultarSaldo();

            ContaPoupança contaPoupança = new ContaPoupança(0);
            contaPoupança.Depositar(2000);
            contaPoupança.ConsultarSaldo();
        }
    }
}