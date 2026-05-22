using System;

namespace CONTApoo
{
    public class ContaInvestimento : Contas, IContas, ITransferivel
    {
        public ContaInvestimento(int nconta, string titular, double saldoAtual, double valor, double salario, double sacar) : base(nconta, titular, saldoAtual, sacar, 0, 0, salario)
        {
        }

        public override void rendimento()
        {
            double P = salario;
            double R = depositar;
            double tanb = 0.035;

            double m = P * Math.Pow(1 + (tanb / 12), 60) + R * (Math.Pow(1 + (tanb / 12), 60) - 1) / (tanb / 12);
            Console.WriteLine("Montante acumulado: " + m);
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