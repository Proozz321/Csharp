using System;

namespace LIVROpoo
{
    public class RI : Livros, ILeitura
    {
        public RI(int NumeroPaginas, int paginasLidas, string Titulo, string Autor, int AnoPublicacao) : base(NumeroPaginas, paginasLidas, Titulo, Autor, AnoPublicacao)
        {
        }
    }
}