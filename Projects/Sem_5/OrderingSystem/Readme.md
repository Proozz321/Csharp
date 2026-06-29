# Ordering System

Aplicação de consola desenvolvida em C# (.NET 8) para simulação de um sistema de gestão de pedidos e controlo de stock. O projeto foi evoluído de uma estrutura tradicional acoplada para um design modular e altamente escalável, aplicando os princípios SOLID e padrões de arquitetura modernos.

## Evolução da Arquitetura

O sistema foi refatorado para eliminar o acoplamento rígido entre componentes, adotando as seguintes abordagens práticadas ao longo do cronograma:

### 1. Injeção de Dependência (DI) e Inversão de Dependência (DIP)
Foi introduzido o ecossistema `Microsoft.Extensions.DependencyInjection` para gerir o ciclo de vida e a resolução dos objetos automaticamente.
* **Abstração:** As classes dependem de contratos (como as interfaces `Inot` e `Istock`), permitindo alterar as implementações concretas (como mudar de `Email` para `SMS`) sem impactar a regra de negócio central.
* **Ciclo de Vida:** Configuração centralizada utilizando o tempo de vida `Transient` para garantir a consistência do estado das dependências durante a execução.

### 2. Padrão Mediator (MediatR)
Para manter o princípio da responsabilidade única (SRP), a orquestração do encerramento do pedido foi desacoplada do fluxo principal (`Program.cs`). O ponto de entrada da aplicação apenas dispara uma intenção através do `FecharCommand`, que é intersetado e processado isoladamente pelo `FecharHandler`.

### 3. Padrão Strategy (Implementado na Quinta-feira)
Para resolver a flexibilidade no cálculo de promoções sem violar o Princípio Open/Closed (OCP), foi introduzido o **Strategy Pattern** através da interface `IDesconto`.
* A classe `Pedido` agora recebe uma estratégia de desconto dinamicamente através do método `Dstr()`.
* Novas regras de negócio (como `DescSazonal` ou `DescVip`) podem ser criadas e injetadas via DI sem alterar uma única linha de código dentro da classe `Pedido`.

### 4. Comunicação por Eventos C# (Implementado na Quinta-feira)
O componente de `Relatorio` foi completamente desacoplado do `FecharHandler`. 
* O `FecharHandler` não conhece a existência da classe de relatórios; ele limita-se a disparar um evento nativo (`PFinalizado`) do tipo `EventHandler<PedidoEventArgs>`.
* No `Program.cs`, o `Relatorio` subscreve-se a este canal de comunicação. Assim que o pedido é fechado, o relatório reage e imprime o resumo de forma assíncrona e independente.

---

## Estrutura do Projeto

* `Program.cs` - Ponto de entrada da aplicação, configuração do container de DI, subscrição de eventos e loop seguro de inputs.
* `Desconto.cs` - Contrato `IDesconto` e as estratégias concretas do *Strategy Pattern* (`SemDesc`, `DescVip`, `DescSazonal`).
* `FecharCommand.cs` - Contém a definição do comando do MediatR, o respetivo `FecharHandler` e o evento `PFinalizado` com os seus `PedidoEventArgs`.
* `Pedido.cs` - Agregação de itens, cálculo do valor total bruto (`Total()`), cálculo com desconto (`TotalComDesconto()`) e estado do pedido.
* `Produtos.cs` - Modelo de dados do produto.
* `Item.cs` - Representação do produto e da sua respetiva quantidade dentro de um pedido.
* `Stock.cs` - Regras de negócio para verificação e atualização de stock através da interface `Istock`.
* `Inot.cs` - Contratos e interfaces para os serviços de notificações, stock e relatórios.
* `Notificação.cs` - Implementações concretas de envio de alertas (`Email` e `SMS`).
* `Relatorio.cs` - Serviço responsável pela geração e impressão do resumo detalhado (valores com e sem desconto) do pedido.

---

## Tecnologias Utilizadas

* .NET 8.0 SDK
* MediatR (Padrão Mediator)
* Microsoft.Extensions.DependencyInjection (Injeção de Dependências)
* Microsoft.Extensions.Logging

---

## Execução

1. Restaurar as dependências do projeto:
   ```bash
   dotnet restore