using System;

namespace LSP3poo
{
    public class Vgasolina : Veiculo, IAbastecivel
    {
        public double litros { get; set; }

        public Vgasolina(double litros)
        {
            this.litros = litros;
        }

        public override void Ligar()
        {
            Console.WriteLine("O veículo a gasolina está ligado.");
        }

        public override void ConsultarAutonomia()
        {
            Console.WriteLine("A autonomia do veículo a gasolina é de " + litros * 8 + " km.");
        }

        public double Abastecer(double litros)
        {
            return litros;
        }
    }
}