using System;
    namespace OrderingSystem
    {
        class Relatorio : Irelatorio
        {
            public void GerarRelatorio(Pedido pedido)
            {
                Console.WriteLine("=== RELATÓRIO DO PEDIDO ===");
                Console.WriteLine("Itens: " + pedido.Itens.Count);
                Console.WriteLine("Valor Sem Desconto: R$ " + pedido.Total()); 
                Console.WriteLine("Valor Com Desconto: R$ " + pedido.TDesco()); 
                Console.WriteLine("Data: " + DateTime.Now);
                Console.WriteLine("===========================\n");
            }
        }
    }