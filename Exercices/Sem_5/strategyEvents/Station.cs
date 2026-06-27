using System;
namespace strategyEvents
{
    public class Station
    {
         private decimal _ValorAtual;
        public event Action<decimal>  NovaT;

        public void Mudar(decimal NovaTemp)
        {
         _ValorAtual = NovaTemp;
         NovaT?.Invoke(_ValorAtual);   
        }
    }

    public class Display
    {
        public void Exibir(decimal temp) => Console.WriteLine($"Temperatura atual: {temp}°C");
    }

    public class Alerta
    {
        public void Verificar(decimal temp)
        {
            if(temp > 35)
            {
                Console.WriteLine($"Alerta de calor extremo! {temp}°C");
            }
            else if (temp < 5)
            {
                Console.WriteLine($"Alerta de frio extremo! {temp}°C");
            }
        }
    }
}