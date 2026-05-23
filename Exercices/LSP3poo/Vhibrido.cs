using System;
namespace LSP3poo
{
    public class Vhibrido : Veiculo, IAbastecivel, ICarregar
    {

        public double litros { get; set; }
        public double kwh { get; set; }

        public Vhibrido(double litros, double kwh)
        {
            this.litros = litros;
            this.kwh = kwh;
        }   

        public override void Ligar()
        {
            Console.WriteLine("O veículo híbrido está ligado.");
        }

        public override void ConsultarAutonomia()
        {
            Console.WriteLine("A autonomia do veículo híbrido é de " + litros * 8 + " km.");
        }

        public double Abastecer(double litros)
        {
            return litros;
        }

        public double Carregar(double kwh)
        {
            return kwh;
        }

    }
}