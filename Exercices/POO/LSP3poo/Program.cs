using System;
namespace LSP3poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculo ={
                    new Vhibrido(50, 35),
                    new Veletrico(50),
                    new Vhibrido(35, 50)
            };
            foreach (var item in veiculo)
            {
                item.Ligar();
                item.ConsultarAutonomia();

                if (item is IAbastecivel a)
                    a.Abastecer(10);

                if(item is ICarregar c)
                    c.Carregar(10);
            }
        }
    }
}