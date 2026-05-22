using System;

namespace LIVROpoo
{
    public class Livros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }
        public int paginasLidas { get; set;}
    

        public Livros(int NumeroPaginas, int paginasLidas, string Titulo, string Autor, int AnoPublicacao)
        {
            this.NumeroPaginas = NumeroPaginas;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.AnoPublicacao = AnoPublicacao;
            this.paginasLidas = paginasLidas;
        }

        public void CalCap()
        {
            if(paginasLidas > NumeroPaginas)
            {
                Console.WriteLine("Não é possível ler mais páginas do que o total do livro.");
            }
            else
            {
                double porcentagemLida = (double)paginasLidas / NumeroPaginas * 100;
                Console.WriteLine($"Você leu {porcentagemLida:F2}% - {paginasLidas - NumeroPaginas} / {NumeroPaginas} páginas do livro.");
            }
        }

        public void lançamento()
        {
            int anoAtual = DateTime.Now.Year;
            if (AnoPublicacao > anoAtual)
            {
               return;
            }
            else
            {
                Console.WriteLine($"O livro foi lançado em {AnoPublicacao}, há {anoAtual - AnoPublicacao} anos.");
            }
        }

        public void exibir()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
        }
    }
}