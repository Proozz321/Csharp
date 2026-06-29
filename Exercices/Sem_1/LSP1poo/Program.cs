using System;
namespace LSP1poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Papagaio papagaio = new Papagaio();
            Pinguim pinguim = new Pinguim();

            papagaio.Voar(); // Saída: O papagaio está voando.
        }
    }
}