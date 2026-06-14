# Gestão de Contratos

Aplicação web para cadastro e gerenciamento de contratos comerciais de compra e venda.

O projeto permite autenticar usuários, cadastrar contratos, editar informações, realizar
exclusão lógica e armazenar o documento do contrato em PDF.

## Regra de negócio principal

Um contrato de venda somente pode ser cadastrado quando existe saldo disponível durante
todos os meses de sua vigência.

O saldo mensal é calculado da seguinte forma:

```text
Saldo disponível = quantidade comprada - quantidade vendida
```

Caso o novo contrato ultrapasse o saldo disponível, a operação é rejeitada e os meses
com saldo insuficiente são apresentados ao usuário.

## Funcionalidades

- Autenticação e gerenciamento de usuários com ASP.NET Core Identity.
- Cadastro, consulta, edição e exclusão lógica de contratos.
- Contratos dos tipos compra e venda.
- Upload e visualização de documentos PDF.
- Cálculo automático da data de término do contrato.
- Validação dos dados e do saldo mensal disponível.
- Interface web MVC com Razor Views.

## Tecnologias

- .NET 10
- ASP.NET Core MVC 10
- Entity Framework Core 10
- SQLite
- ASP.NET Core Identity
- MediatR 14
- FluentValidation 12
- AutoMapper 16
- xUnit e Moq

As versões dos pacotes NuGet são gerenciadas centralmente pelo arquivo
`Directory.Packages.props`.

## Arquitetura

A solução é organizada nos seguintes projetos:

| Projeto | Responsabilidade |
| --- | --- |
| `ContractManager.Web` | Aplicação MVC, controllers, Razor Views, autenticação e configuração da aplicação. |
| `ContractManager.Application` | Configuração e profiles do AutoMapper. |
| `ContractManager.Domain` | Entidades, comandos, validações e regras de negócio. |
| `ContractManager.Data` | Contexto do Entity Framework, repositórios, mapeamentos e migrations. |
| `ContractManager.IoC` | Registro das dependências da aplicação. |
| `ContractManager.UnitTests` | Testes unitários do domínio. |

O projeto utiliza Command Pattern, Repository Pattern, injeção de dependências e
exclusão lógica de registros.

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Executando o projeto

Na raiz do repositório, restaure e compile a solução:

```powershell
dotnet restore ContractManager.sln
dotnet build ContractManager.sln
```

Inicie a aplicação web:

```powershell
dotnet run --project src/ContractManager.Web/ContractManager.Web.csproj
```

Por padrão, o perfil de desenvolvimento disponibiliza a aplicação em:

- `https://localhost:59472`
- `http://localhost:59473`

O banco de dados SQLite utiliza a connection string `DataSource=app.db`, definida em
`src/ContractManager.Web/appsettings.json`.

## Testes

Execute os testes automatizados com:

```powershell
dotnet test ContractManager.sln
```

## Atualização para .NET 10

O projeto foi atualizado do ASP.NET Core 2.2 para o .NET 10. Durante a atualização,
foram modernizados:

- O pipeline HTTP, utilizando routing e endpoints.
- A configuração do host da aplicação.
- O registro do ASP.NET Core Identity e das Razor Pages.
- A integração de injeção de dependências do AutoMapper e do MediatR.
- O gerenciamento centralizado das versões dos pacotes NuGet.
- A infraestrutura de execução dos testes.

## Observações

O foco original do projeto está nas funcionalidades, na arquitetura e nas regras de
negócio. A interface utiliza Bootstrap e pode conter alguns textos em inglês herdados
dos templates do framework.
