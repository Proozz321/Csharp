using System;

namespace CARROpoo
{
    public class camiao : Veiculo, ICarro
    {
        public camiao(string marca, int velmax, double combatual, double maxcomb, int gasolina, int km) : base(marca, velmax, combatual, maxcomb, gasolina, km)
        {
        }
    }
    
}