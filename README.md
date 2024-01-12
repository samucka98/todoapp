# Todo App com ASP.NET

1. Criação do projeto:

- `dotnet new web -o todoapp`

2. Instalação dos pacotes:

- `dotnet add package Microsoft.EntityFrameworkCore.Sqlite`
- `dotnet add package Microsoft.EntityFrameworkCore.Design`

3. Geração do banco:

- `dotnet ef migrations add CreateDatabase`

4. Atualizando o banco:

- `dotnet ef database update`
