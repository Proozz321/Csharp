using System;
namespace LSP2poo
{
    public interface IContas
    {
     public void Levantar(double Valor);
     public void Depositar(double Valor);
     public void ConsultarSaldo();

    }
}