using System;

namespace CONTApoo
{
    public class ContaPoupança : Contas, IContas, ITransferivel
    {
        public ContaPoupança(int nconta, string titular, double saldoAtual, double valor, double salario, double sacar) : base(nconta, titular, saldoAtual, sacar, 0, 0, salario)
        {
        }

        public override void rendimento()
        {
            double rendimento = salario * 0.02 * (360/360);
            double irs = rendimento * 0.28;
            double jurosliquidos = rendimento - irs;
            Console.WriteLine("Rendimento aplicado: " + rendimento);
            Console.WriteLine("IRS: " + irs);
            Console.WriteLine("Juros líquidos: " + jurosliquidos);
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