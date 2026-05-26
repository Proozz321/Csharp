namespace RecordPatternpoo
{
    public record Encomenda{
        public double Peso { get; init; }
        public string Destino { get; init; }

        public Encomenda(double peso, string destino)
        {
            this.Peso = peso;
            this.Destino = destino;
        }

        public double Edestino() => Destino switch
        {
            "Nacional" => 10.00,
            "Internacional" => 50.00,
            "Expresso" => Peso * 5.00,
            _ => 0.00
        };
    }
    
}