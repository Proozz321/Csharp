using System;
namespace LINQ
{
    public class Filmes
    {
        public string Nome { get; set;}
        public int Nota {get; set;}
        public string Categoria {get; set;}
    
        public Filmes(string nome, int nota, string categoria)
        {
            this.Nome = nome;
            this.Nota = nota;
            this.Categoria = categoria;
        }


    }
}