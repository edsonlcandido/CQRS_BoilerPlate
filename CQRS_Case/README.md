Projeto para aprender sobre CQRS usando o github copilot X, como tutor e estudando o código

## CQRS para projetos C# e Windows Forms
A arquitetura CQRS (Command Query Responsibility Segregation) é uma abordagem que separa a lógica de leitura e gravação em uma aplicação. Em outras palavras, a CQRS propõe que a lógica de escrita (comandos) e leitura (consultas) sejam separadas em modelos diferentes. Dessa forma, a arquitetura é capaz de otimizar a aplicação para atender às necessidades de cada tipo de operação, já que cada modelo tem sua própria responsabilidade.

No contexto específico do C# e Windows Forms, a arquitetura CQRS pode ser implementada por meio da separação de camadas e modelos. Por exemplo, a camada de apresentação (UI) pode ser responsável por enviar as solicitações de leitura ou gravação para um modelo específico, que executa a operação e retorna o resultado apropriado para a UI exibir. Isso pode ser feito de maneira organizada e escalável, possibilitando a implementação de vários recursos no projeto.

Para aplicar a arquitetura CQRS ao seu projeto, recomenda-se atribuir responsabilidades específicas a cada modelo e aplicar o princípio SRP (Single Responsibility Principle, ou Princípio da Responsabilidade Única), que consiste em garantir que cada classe ou componente tenha apenas uma responsabilidade. Essa prática pode ajudar a garantir que a aplicação seja fácil de manter e melhorar.

# Exemplo de aplicação CQRS

## Estrutura de pasta sugerido pelo Copilot X
- MyProject
  - Models
    - UserModel.cs
  - Commands
    - CreateUserCommand.cs
    - UpdateUserCommand.cs
    - DeleteUserCommand.cs
  - Queries
    - GetUserQuery.cs
    - GetAllUsersQuery.cs
  - Services
    - UserService.cs
  - Repository
    - IRepository.cs
    - UserRepository.cs
  - Views
    - FormMain.cs

## Descrição das camadas 
- Namespace Models: aqui você pode adicionar as classes de modelo, que representam as entidades do seu sistema. Por exemplo: UserModel.cs, ProductModel.cs, etc.
- Namespace Commands: aqui você pode adicionar as classes de comando, que representam os comandos que são executados em seu sistema. Por exemplo: CreateUserCommand.cs, UpdateProductCommand.cs, etc.
- Namespace Queries: aqui você pode adicionar as classes de consulta, que representam as consultas que são executadas em seu sistema. Por exemplo: GetUserQuery.cs, GetAllProductsQuery.cs, etc.
- Namespace Services: aqui você pode adicionar as classes de serviço, que representam as ações de negócios que são executadas em seu sistema. Por exemplo: UserService.cs, ProductService.cs, etc.
- Namespace Repository: aqui você pode adicionar as classes de repositório, que representam a camada de acesso a dados do seu sistema. Por exemplo: UserRepository.cs, ProductRepository.cs, etc.
- Namespace Views: aqui você pode adicionar as classes de exibição, que representam as janelas do seu sistema. Por exemplo: MainForm.cs, CreateUserForm.cs, etc.

        // Model
        public class UserModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        // Commands
        public class CreateUserCommand
        {
            public UserModel User { get; set; }
        }

        public class UpdateUserCommand
        {
            public int Id { get; set; }
            public UserModel User { get; set; }
        }

        public class DeleteUserCommand
        {
            public int Id { get; set; }
        }

        // Queries
        public class GetUserQuery
        {
            public int Id { get; set; }
        }

        public class GetAllUsersQuery
        {
        }

        // Services
        public class UserService
        {
            private readonly IRepository<UserModel> userRepository;

            public UserService(IRepository<UserModel> userRepository)
            {
                this.userRepository = userRepository;
            }

            public void CreateUser(UserModel user)
            {
                userRepository.Create(user);
            }

            public void UpdateUser(int id, UserModel user)
            {
                userRepository.Update(id, user);
            }

            public void DeleteUser(int id)
            {
                userRepository.Delete(id);
            }

            public UserModel GetUser(int id)
            {
                return userRepository.GetById(id);
            }

            public IEnumerable<UserModel> GetAllUsers()
            {
                return userRepository.GetAll();
            }
        }

        // Repository
        public interface IRepository<TModel> where TModel : class
        {
            void Create(TModel model);
            void Update(int id, TModel model);
            void Delete(int id);
            TModel GetById(int id);
            IEnumerable<TModel> GetAll();
        }

        public class UserRepository : IRepository<UserModel>
        {
            private readonly List<UserModel> users = new List<UserModel>();
            public void Create(UserModel model)
            {
                users.Add(model);
            }

            public void Delete(int id)
            {
                var user = GetById(id);
                users.Remove(user);
            }

            public IEnumerable<UserModel> GetAll()
            {
                return users;
            }

            public UserModel GetById(int id)
            {
                return users.Find(u => u.Id == id);
            }

            public void Update(int id, UserModel model)
            {
                var user = GetById(id);
                users.Remove(user);
                users.Add(model);
            }
        }

        // Views are not included in this code snippet
