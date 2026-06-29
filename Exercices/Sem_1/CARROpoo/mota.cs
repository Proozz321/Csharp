using System;

namespace CARROpoo
{
    public class Mota : Veiculo, ICarro
    {
        public Mota(string marca, int velmax, double combatual, double maxcomb, int gasolina, int km) : base(marca, velmax, combatual, maxcomb, gasolina, km)
        {
        }
    }
    
}