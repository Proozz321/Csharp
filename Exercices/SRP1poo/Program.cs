using System;
using System.Text.RegularExpressions;
namespace SRPpoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var validador = new validaremail();
            var boasvindas = new boasvindas();

            Utilizador[] users = {
                new Utilizador("João", "joao@example.com", "password123"),
                new Utilizador("Maria", "maria@example", "password456"),
            };

            foreach(var user in users)
            {
                if(validador.Valemail(user.email))
                {
                    boasvindas.Boasvinda(user.nome);
                }
                else
                {
                    Console.WriteLine("Email inválido para " + user.nome);
                }
            }
        }
    }
}