using System;
using System.Text.RegularExpressions;

namespace SRPpoo
{
    class Utilizador
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Utilizador(string nome, string email, string password)
        {
            this.nome = nome;
            this.email = email;
            this.password = password;
        }
    }
   
    class validaremail{
        public bool Valemail(string email)
        {
            var rg = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return rg.IsMatch(email);
        }
    }

    class boasvindas{
        public void Boasvinda(string nome)
        {
            Console.WriteLine("Bem-vindo, " + nome + "!");
        }
    }
}