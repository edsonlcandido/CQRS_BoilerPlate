Projeto para aprender sobre CQRS usando o github copilot X, como tutor e estudando o código

## CQRS para projetos C# e Windows Forms
A arquitetura CQRS (Command Query Responsibility Segregation) é uma abordagem que separa a lógica de leitura e gravação em uma aplicação. Em outras palavras, a CQRS propõe que a lógica de escrita (comandos) e leitura (consultas) sejam separadas em modelos diferentes. Dessa forma, a arquitetura é capaz de otimizar a aplicação para atender às necessidades de cada tipo de operação, já que cada modelo tem sua própria responsabilidade.

No contexto específico do C# e Windows Forms, a arquitetura CQRS pode ser implementada por meio da separação de camadas e modelos. Por exemplo, a camada de apresentação (UI) pode ser responsável por enviar as solicitações de leitura ou gravação para um modelo específico, que executa a operação e retorna o resultado apropriado para a UI exibir. Isso pode ser feito de maneira organizada e escalável, possibilitando a implementação de vários recursos no projeto.

Para aplicar a arquitetura CQRS ao seu projeto, recomenda-se atribuir responsabilidades específicas a cada modelo e aplicar o princípio SRP (Single Responsibility Principle, ou Princípio da Responsabilidade Única), que consiste em garantir que cada classe ou componente tenha apenas uma responsabilidade. Essa prática pode ajudar a garantir que a aplicação seja fácil de manter e melhorar.

# Exemplo de aplicação CQRS

## Estrutura de pasta sugerido pelo Copilot X
- MyProject
  - Models
    - Item.cs
  - Commands
    - AddItemCommand.cs
    - UpdateItemCommand.cs
    - DeleteItemCommand.cs
  - Queries
    - GetAllItemsQuery.cs
    - GetItemByIdQuery.cs
  - Services
    - IItemService.cs
    - ItemService.cs
  - Repository
    - IRepository.cs
    - Repository.cs
  - Views
    - FormMain.cs