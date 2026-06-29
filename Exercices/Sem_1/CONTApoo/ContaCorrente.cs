using System;

namespace CONTApoo
{
    public class ContaCorrente : Contas, IContas, ITransferivel
    {
        public ContaCorrente(int nconta, string titular, double saldoAtual, double valor, double salario, double sacar) : base(nconta, titular, saldoAtual, sacar, 0, 0, salario)
        {
        }

        public override void rendimento()
        {
          double saldofinal = saldoAtual  + salario - sacar;
          Console.WriteLine("Saldo final: " + saldofinal);
        }

        public override double transferir(double valor)
        {
            if (valor > saldoAtual)
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
                return 0;
            }
            else
            {
                saldoAtual -= valor;
                Console.WriteLine("Valor transferido: " + valor);
                return valor;
            }
        }
        

    }
    
}