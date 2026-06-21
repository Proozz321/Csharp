# Ordering System

Aplicação de consola desenvolvida em C# (.NET 8) para simulação de um sistema de gestão de pedidos e controlo de stock. O projeto foi evoluído de uma estrutura tradicional acoplada para um design modular e escalável, servindo como base prática para a aplicação de princípios SOLID e padrões de arquitetura.

## Evolução da Arquitetura

O sistema foi refatorado para eliminar o acoplamento rígido entre componentes, adotando duas abordagens principais:

### 1. Injeção de Dependência (DI) e Inversão de Dependência (DIP)
Originalmente, as dependências eram instanciadas manualmente dentro das classes clientes (ex: `new Pedido(new Email())`). Foi introduzido o ecossistema `Microsoft.Extensions.DependencyInjection` para gerir o ciclo de vida e a resolução dos objetos automaticamente.
* **Abstração:** As classes agora dependem de contratos (como a interface `Inot`), permitindo que a implementação concreta seja alterada sem impactar as regras de negócio.
* **Ciclo de Vida:** Configuração centralizada utilizando o tempo de vida adequado (`Transient`) para garantir a consistência do estado do pedido e do stock durante a execução.

### 2. Padrão Mediator (MediatR)
Para manter o princípio da responsabilidade única (SRP), a orquestração do encerramento do pedido foi desacoplada do fluxo principal (`Program.cs`).
* **Desacoplamento de Fluxo:** O ponto de entrada da aplicação apenas dispara uma intenção através de um comando (`FecharCommand`).
* **Encapsulamento de Lógica:** O `FecharHandler` interseta o comando e executa isoladamente as ações necessárias (finalização do pedido e geração de relatórios), permitindo que novas ações pós-venda sejam adicionadas futuramente sem alterar a interface de utilizador.

---

## Estrutura do Projeto

* `Program.cs` - Ponto de entrada da aplicação, configuração do container de DI e loop do menu.
* `FecharCommand.cs` - Contém a definição do comando e o respetivo Handler para processamento via MediatR.
* `Produtos.cs` - Modelo de dados do produto.
* `Item.cs` - Representação do produto e da sua respetiva quantidade dentro de um pedido.
* `Pedido.cs` - Agregação de itens, cálculo do valor total e estado do pedido.
* `Stock.cs` - Regras de negócio para verificação e atualização de stock.
* `Inot.cs` - Contrato para o serviço de notificações.
* `Notificação.cs` - Implementações concretas de envio (Email e SMS).
* `Relatorio.cs` - Serviço responsável pela geração do resumo impresso do pedido.

---

## Tecnologias Utilizadas

* .NET 8.0 SDK
* MediatR
* Microsoft.Extensions.DependencyInjection
* Microsoft.Extensions.Logging

---

## Execução

1. Restaurar as dependências do projeto:
   ```bash
   dotnet restore