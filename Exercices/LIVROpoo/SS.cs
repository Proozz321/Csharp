using System;

namespace LIVROpoo
{
    public class SS : Livros, ILeitura
    {
        public SS(int NumeroPaginas, int paginasLidas, string Titulo, string Autor, int AnoPublicacao) : base(NumeroPaginas, paginasLidas, Titulo, Autor, AnoPublicacao)
        {
        }
    }
}