# PhoneBook
---
# Phone Book App / Aplicativo de Agenda Telefônica

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

## 🌐 English
**A simple console-based phone book with CRUD operations using Entity Framework and SQL Server.**

### Features
- Add/Edit/Delete contacts
- Email and phone number validation
- SQL Server database
- Clean architecture with Repository Pattern
- Console user interface

### Prerequisites
- .NET 6+ SDK
- SQL Server (LocalDB included in Visual Studio)
- Entity Framework Core Tools

### Installation
```bash
git clone [your-repo-url]
cd PhoneBookApp
dotnet restore
dotnet ef database update
dotnet run
```

### Project Structure
```
📁 Models       - Domain entities
📁 Data         - DB Context
📁 Repository   - Data access layer
📁 Services     - Business logic
📁 Helpers       - Helpers/Validations
```

## 🌐 Português
**Uma agenda telefônica em console com operações CRUD usando Entity Framework e SQL Server.**

### Funcionalidades
- Adicionar/Editar/Excluir contatos
- Validação de e-mail e telefone
- Banco de dados SQL Server
- Arquitetura limpa com Repository Pattern
- Interface em console

### Pré-requisitos
- .NET 6+ SDK
- SQL Server (LocalDB incluso no Visual Studio)
- Entity Framework Core Tools

### Instalação
```bash
git clone [url-do-seu-repositorio]
cd PhoneBookApp
dotnet restore
dotnet ef database update
dotnet run
```

### Estrutura
```
📁 Models       - Entidades do domínio
📁 Data         - Contexto do banco
📁 Repository   - Acesso a dados
📁 Services     - Lógica de negócio
📁 Helpers       - Validações/Helpers
```
