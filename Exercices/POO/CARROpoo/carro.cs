using System;

namespace CARROpoo
{
    public class Carro : Veiculo, ICarro
    {
        public Carro(string marca, int velmax, double combatual, double maxcomb, int gasolina, int km) : base(marca, velmax, combatual, maxcomb, gasolina, km)
        {
        }
    }
    
}