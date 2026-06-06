using System;
namespace Func_Action
{
   class Program
    {
        static void Main(string[] args)
        {
            Processar p = new Processar();
            p.ProcessarConv(10, x => x * 1.8 + 32, resultado => Console.WriteLine($"O resultado é: {resultado}"));
        }
    }
}