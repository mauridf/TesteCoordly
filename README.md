# TesteCoordly

## Descrição

Esta é uma API simples para gerenciamento de produtos, desenvolvida com .NET Core 8 e Entity Framework Core. A API permite realizar operações básicas de CRUD (Criar, Ler, Atualizar e Deletar) para produtos. Cada produto possui um identificador único, nome, preço e quantidade em estoque. A aplicação segue boas práticas de arquitetura com separação de camadas (Models, Repositories, Controllers) e implementa validações básicas. 

A documentação da API é feita com o Swagger, permitindo uma fácil interação e testes dos endpoints.

## Tecnologias Utilizadas
- .NET Core 8
- Entity Framework Core
- SQL Server
- Swagger

## Funcionalidades
- **Criar Produto**: Adicionar um novo produto com nome, preço e quantidade.
- **Listar Produtos**: Visualizar todos os produtos cadastrados.
- **Atualizar Produto**: Alterar os detalhes de um produto existente.
- **Deletar Produto**: Remover um produto do sistema.

## Instruções para Rodar o Projeto Localmente

### Pré-requisitos:
- [.NET SDK](https://dotnet.microsoft.com/download/dotnet) instalado
- [SQL Server LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) ou outra instância SQL Server configurada
- Um editor de código, como o [Visual Studio Code](https://code.visualstudio.com/)

### Passos para rodar:

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/usuario/TesteCoordly.git
   cd TesteCoordly
   ```

2. **Configure a string de conexão** no arquivo `appsettings.json` com sua instância do SQL Server (LocalDB ou outro).

3. **Restaurar pacotes**:
   ```bash
   dotnet restore
   ```

4. **Rodar as migrações** para criar o banco de dados:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. **Executar a aplicação**:
   ```bash
   dotnet run
   ```

   A aplicação será iniciada e estará disponível em `https://localhost:5001`.

## Acessar o Swagger para Testar a API

1. Após rodar a aplicação, abra o navegador e acesse o seguinte URL:
   ```
   https://localhost:5001/swagger
   ```

2. O Swagger exibirá a documentação interativa da API, permitindo testar os endpoints diretamente pela interface.

   - **GET /api/Produtos**: Listar todos os produtos
   - **GET /api/Produtos/{id}**: Obter um produto pelo ID
   - **POST /api/Produtos**: Criar um novo produto
   - **PUT /api/Produtos/{id}**: Atualizar um produto existente
   - **DELETE /api/Produtos/{id}**: Deletar um produto pelo ID
