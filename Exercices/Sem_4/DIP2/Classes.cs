using System;
namespace DIP2
{
    public interface Ivenda
    {
        void Guardar(decimal valor);
        decimal Obter();
    }

    public interface Idesconto
    {
        decimal Des(decimal original);
    }

    public class Venda : Ivenda
    {
        private decimal _valor = 0;

        public void Guardar(decimal valor)
        {
            _valor += valor;
        }

        public decimal Obter() => _valor;
    }

    public class Desconto : Idesconto
    {
        public decimal Des(decimal original) => original * 0.9m;
    }

    public class Registradora
    {
        private readonly Ivenda _venda;
        private readonly Idesconto _desc;

        public Registradora(Ivenda venda, Idesconto original)
        {
            _venda = venda;
            _desc = original;
        }

        public void Fechar(decimal bruto)
        {
            decimal valor = _desc.Des(bruto);
            _venda.Guardar(valor);

            Console.WriteLine($"Valor bruto: {bruto}, valor com desconto: {valor}");
        }
    }
}