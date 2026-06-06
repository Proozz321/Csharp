using System;
namespace Func_Action2
{
    class Program
    {
        static void Main(string[] args)
        {
            Validador v = new Validador();
            v.Validar("Ma", valor => valor.Length >= 3,
            () => Console.WriteLine("Dado válido"),
            () => Console.WriteLine("Dado inválido"));
        }
    }
}