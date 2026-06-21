using System;
    namespace OrderingSystem
    {
        class Relatorio : Irelatorio
        {
            public void GerarRelatorio(Pedido pedido)
            {
                Console.WriteLine("=== RELATÓRIO DO PEDIDO ===");
                Console.WriteLine("Itens: " + pedido.Itens.Count);
                Console.WriteLine("Total: R$ " + pedido.Total());
                Console.WriteLine("Data: " + DateTime.Now);
            }
        }
    }