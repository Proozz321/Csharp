using System;
namespace strategy
{
    public interface Ifrete{ public double Calcular(double valor);}

    public class Sedex : Ifrete
    {
        public double Calcular(double valor) => (valor * 1.025) + 10;
    }

    public class Expressa : Ifrete
    {
        public double Calcular(double valor) => (valor * 1.048) + 25;
    }
    public class CalcularFrete
    {
        private readonly Ifrete _frete;
        public CalcularFrete(Ifrete frete) => _frete = frete;           
        public double Calcular(double valor) => _frete.Calcular(valor);
    }
}