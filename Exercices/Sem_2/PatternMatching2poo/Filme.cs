namespace PatternMatching2poo
{
    public class Filme
    {
        public string Titulo { get; set; }
        public int Nota { get; set; }
        public string Genero { get; set; }

        public Filme(string titulo, int nota, string genero)
        {
            this.Titulo = titulo;
            this.Nota = nota;
            this.Genero = genero;
        }

        public string FNota() => Nota switch
        {
             >= 9 => "Obra prima",
             >= 7 => "Muito bom",
             >= 5 => "Regular",
            _ => "Ruim",
        };

        public string FGenero() => Genero switch
        {
            
            "Ação" => "Adrenalina pura",
            "Comédia" => "Riso garantido",
             _ => "Gênero desconhecido",
        };
    }
}