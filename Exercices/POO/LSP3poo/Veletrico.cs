using System;
namespace LSP3poo
{
    public class Veletrico : Veiculo, ICarregar
    {
        private double kwh { get; set; }

        public Veletrico(double kwh){
            this.kwh = kwh;
        }

        public override void Ligar()
        {
            Console.WriteLine("O veículo elétrico está ligado.");
        }

        public override void ConsultarAutonomia()
        {
            Console.WriteLine("A autonomia do veículo elétrico é de " + kwh * 8 + " km.");
        }
        public double Carregar(double kwh)
        {
            return kwh;
        }
    }
}