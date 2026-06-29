namespace PatternMatchingpoo
{
    public class Pagamento
    {
        public double Valor { get; set; }
        public string Metodo { get; set; }
    
    public Pagamento(double valor, string metodo)
    {
            this.Valor = valor;
            this.Metodo = metodo;
    }

    public double CalcularTaxa()
    {
            return Metodo switch
            {
                "Cartão" => Valor * 0.05,
                "Pix" => 0.00,
                "Boleto" => 3.5,
                _ => 0.0
            };
        }
    }
}