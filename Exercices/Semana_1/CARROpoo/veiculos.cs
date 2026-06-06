using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARROpoo
{
    public abstract class Veiculo
    {
        public string marca { get; set; }
        public int velmax { get; set; }
        public double combatual { get; set; }
        public double maxcomb { get; set; }
        public int gasolina { get; set; }
        public int km { get; set; }

        public Veiculo(string marca, int velmax, double combatual, double maxcomb, int gasolina, int km)
        {
            this.marca = marca;
            this.velmax = velmax;
            this.combatual = combatual;
            this.maxcomb = maxcomb;
            this.gasolina = gasolina;
            this.km = km;
        }

        public void abastecer()
        {
           if (gasolina > maxcomb){
             combatual = maxcomb;
            }
            else if(gasolina <= maxcomb){
              combatual += gasolina;
            }
        }

        public void autonomia()
        {
           Console.WriteLine("A autonomia do carro é de: " + (km/gasolina * maxcomb) + " km");
        }

         public void exibir()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Velocidade Máxima: " + velmax + " km/h");
            Console.WriteLine("Combustível Atual: " + combatual + " litros");
            Console.WriteLine("Capacidade Máxima de Combustível: " + maxcomb + " litros");
            Console.WriteLine("Gasolina no Tanque: " + gasolina + " litros");
            Console.WriteLine("Quilometragem: " + km + " km");
        }


    } 
}