using System;

namespace LIVROpoo
{
    public class ORV : Livros, ILeitura
    {
        public ORV(int NumeroPaginas, int paginasLidas, string Titulo, string Autor, int AnoPublicacao)
            :base(NumeroPaginas, paginasLidas, Titulo, Autor, AnoPublicacao)
        {
        }
    }
}