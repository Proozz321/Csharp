using System;
using System.Threading.Tasks;
namespace async_await2
{
    class Biblioteca
    {
        public int Id { get; set; }

        public Biblioteca(int id)
        {
            this.Id = id;
        }

        public async Task<string> BuscarLivro(int id)
        {
            await Task.Delay(2000);

            return id switch
            {
                1 => "O livro é: O Senhor dos Anéis",
                2 => "O livro é: O Hobbit",
                3 => "O livro é: O Silmarillion",  
                _=> "Livro não encontrado"
            };
        
        }

        public async Task<string> AutorLivro(int id)
        {
            await Task.Delay(5000);

            return id switch
            {
                1 => "O autor é: J.R.R. Tolkien",
                2 => "O autor é: J.J.R. Tolkien",
                3 => "O autor é: J.J.J. Tolkien",  
                _=> "Autor não encontrado"
            };
        }

    }
    
}