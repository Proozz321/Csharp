using System;
using strategyEvents;
class Program
{
    static void Main()
    {
        // Instancia o sujeito (estação)
        var estacao = new Station();

        // Instancia os observadores (displays)
        var displaySimples = new Display();
        var alertaClima = new Alerta();

        // PASSO CRUCIAL: Inscreve os métodos dos displays no evento da estação
        estacao.NovaT += displaySimples.Exibir;
        estacao.NovaT += alertaClima.Verificar;

        // Simulando as mudanças de temperatura
        Console.WriteLine("--- Mudança 1: 22°C ---");
        estacao.Mudar(22); // Apenas o Display Simples deve reagir

        Console.WriteLine("\n--- Mudança 2: 38°C ---");
        estacao.Mudar(38); // Ambos vão reagir (alerta de calor)

        Console.WriteLine("\n--- Mudança 3: 3°C ---");
        estacao.Mudar(3);  // Ambos vão reagir (alerta de frio)
    }
}