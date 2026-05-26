using System;

namespace CONTApoo
{
    public abstract class Contas : ITransferivel, IContas
    {
        public int Nconta {get;set;}
        public string Titular {get;set;}
        public double saldoAtual {get;set;}
        public double salario {get;set;}
        public double sacar {get;set;}
        public double depositar {get;set;}
        public double tran {get;set;}

        public Contas(int nconta, string titular, double saldoAtual, double sacar, double depositar, double tran, double salario){
            this.Nconta=nconta;
            this.Titular=titular;
            this.sacar=sacar;
            this.depositar=depositar;
            this.saldoAtual=saldoAtual;
            this.tran=tran;
            this.salario=salario;
        }

        public abstract void rendimento();
        public abstract double transferir(double valor);

        public void depostar(double depositar){
            saldoAtual+=depositar;
        }

        public void retirar(double sacar){
            if(sacar>saldoAtual){
                Console.WriteLine("Saldo insuficiente");
            }else{
                saldoAtual -= sacar;
            }
        }

        public void exibir(){
            Console.WriteLine("Número da conta: "+Nconta);
            Console.WriteLine("Titular: "+Titular);
            Console.WriteLine("Saldo atual: "+saldoAtual);
        }
        
    }
    
}