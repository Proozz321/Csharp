// See https://aka.ms/new-console-template for more information
using System;
namespace RPGpoo
{
    class Program
    {
        static void Main(string[] args)
        {
           Personagem[]grupo = { 
                new Arqueiro("Legolas", 100, 5),
                new Mago("Gandalf", 80, 10),
                new Guerreiro("Aragorn", 120, 8),
            };

            foreach(var p in grupo){

                p.exibir();
                p.atacar();
                Console.WriteLine();
                
            }
        }
    }    
}