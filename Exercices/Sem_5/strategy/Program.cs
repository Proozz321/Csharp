using System;
namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SIMULADOR DE FRETE E-COMMERCE ===\n");    
            double peso = 5.0; // 5kg
        
            var calcSedex = new CalcularFrete(new Sedex());
            double valorS = calcSedex.Calcular(peso);
            
            Console.WriteLine($"Opção Correios (SEDEX): R$ {valorS:N2}");
            
            var calcExp = new CalcularFrete(new Expressa());
            double valorR = calcExp.Calcular(peso);
            
            Console.WriteLine($"expresso: R$ {valorR:N2}");
            Console.WriteLine($"loja: R$ {peso:N2}");            
            Console.ReadLine();
        }
    }

}