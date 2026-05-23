# OrderingSystem

Projeto prático desenvolvido durante meus estudos de C# para aplicar os princípios **SOLID** num sistema real.

## O que o sistema faz

- Lista produtos disponíveis
- Permite adicionar produtos ao pedido
- Verifica estoque antes de adicionar
- Calcula o total do pedido
- Notifica por Email ou SMS ao finalizar
- Gera um relatório com os detalhes do pedido

## Estrutura

```
Produtos.cs       # dados do produto
Item.cs           # produto + quantidade dentro do pedido
Pedido.cs         # gerencia itens e calcula total
Stock.cs          # controla o estoque
Notificação.cs    # Email e SMS
Relatorio.cs      # resumo do pedido
Program.cs        # fluxo principal
```

## Como rodar

```bash
dotnet run
```

## O que aprendi aqui

Cada classe tem uma responsabilidade clara. Novos tipos de notificação podem ser adicionados sem tocar no código existente. O `Pedido` não sabe se a notificação é por Email ou SMS — recebe isso de fora.