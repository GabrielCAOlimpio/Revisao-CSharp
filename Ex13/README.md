# Gestão Financeira Minimal API

Uma API simples construída com ASP.NET Core Minimal API para gerenciar faturamentos e gastos financeiros. Permite operações CRUD (Criar, Ler, Atualizar, Excluir) para ambas as entidades, com validações robustas e documentação interativa via Scalar.

## Funcionalidades

- **Faturamentos**: Gerencie receitas ou faturamentos, incluindo título, valor, descrição e data.
- **Gastos**: Gerencie despesas, com as mesmas propriedades.
- Validações incluem:
  - Títulos obrigatórios (máx. 100 caracteres).
  - Valores obrigatórios e positivos (parseados como decimal com cultura invariante para suportar ponto decimal).
  - Descrições opcionais (máx. 500 caracteres).
  - Datas obrigatórias, não futuras, no formato "yyyy-MM-dd".
- Tratamento de erros com códigos HTTP apropriados (400 Bad Request, 404 Not Found, 500 Internal Server Error).

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para construção da API Minimal.
- **Entity Framework Core**: ORM para acesso ao banco de dados SQL Server.
- **SQL Server**: Banco de dados relacional.
- **Scalar**: Para documentação interativa da API (disponível em `/scalar/v1`).
- **C#**: Linguagem de programação.

## Estrutura do Projeto

```
Ex13/
├── Program.cs                 # Configuração da API e endpoints
├── appsettings.json           # Configurações (conexão DB, etc.)
├── Data/
│   └── AppDbContext.cs        # Contexto do Entity Framework
├── DTOs/
│   ├── Faturamento/
│   │   ├── FaturamentoRequestDTO.cs   # DTO para requests de faturamento
│   │   └── FaturamentoResponseDTO.cs  # DTO para responses
│   └── Gastos/
│       ├── GastosRequestDTO.cs        # DTO para requests de gastos
│       └── GastosResponseDTO.cs       # DTO para responses
├── Interfaces/
│   ├── Repositories/
│   │   ├── IFaturamentoRepository.cs  # Interface para repositório de faturamento
│   │   └── IGastosRepository.cs       # Interface para repositório de gastos
│   └── Services/
│       ├── IFaturamentoService.cs     # Interface para serviço de faturamento
│       └── IGastosService.cs          # Interface para serviço de gastos
├── Models/
│   ├── Faturamento.cs         # Modelo de domínio para faturamento
│   └── Gastos.cs              # Modelo de domínio para gastos
├── Repositories/
│   ├── Faturamento/
│   │   └── FaturamentoRepository.cs   # Implementação do repositório de faturamento
│   └── Gastos/
│       └── GastosRepository.cs        # Implementação do repositório de gastos
├── Services/
│   ├── Faturamento/
│   │   └── FaturamentoService.cs      # Lógica de negócio para faturamento
│   └── Gastos/
│       └── GastosService.cs           # Lógica de negócio para gastos
└── Migrations/               # Migrações do EF Core
```

## Endpoints da API

### Faturamentos

- **GET /faturamentos**: Lista todos os faturamentos.
- **POST /faturamento**: Cria um novo faturamento.
  - Body: `FaturamentoRequestDTO` (JSON).
- **PUT /faturamento/{id}**: Edita um faturamento existente (GUID como string).
  - Body: `FaturamentoRequestDTO`.
- **DELETE /faturamento/{id}**: Exclui um faturamento.

### Gastos

- **GET /gastos**: Lista todos os gastos.
- **POST /gastos**: Cria um novo gasto.
  - Body: `GastosRequestDTO` (JSON).
- **PUT /gastos/{id}**: Edita um gasto existente (GUID como string).
  - Body: `GastosRequestDTO`.
- **DELETE /gastos/{id}**: Exclui um gasto.

### Outros

- **GET /**: Redireciona para a documentação Scalar.

## Como Executar

1. **Pré-requisitos**:
   - .NET 8+ instalado.
   - SQL Server local ou remoto configurado.

2. **Configuração**:
   - Atualize `appsettings.json` com a string de conexão do banco:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=SEU_SERVIDOR;Database=GestaoFinanceira;Trusted_Connection=True;TrustServerCertificate=True;"
       }
     }
     ```

3. **Executar Migrações**:
   - No terminal: `dotnet ef database update` (certifique-se de que o EF Core CLI esteja instalado).

4. **Rodar a API**:
   - `dotnet run`.
   - Acesse `https://localhost:5001` (ou a porta configurada).
   - Documentação: `https://localhost:5001/scalar/v1`.

5. **Testar**:
   - Use ferramentas como Postman, curl ou a documentação Scalar para testar os endpoints.

## Validações e Regras de Negócio

- IDs são GUIDs gerados automaticamente.
- Valores são strings no request (ex.: "40.5") e parseados para decimal usando cultura invariante.
- Datas são strings no formato "yyyy-MM-dd"; se vazia, assume a data atual (apenas para criação).
- Exceções são tratadas com mensagens claras e códigos HTTP adequados.
- Modelos de domínio incluem validações no construtor e métodos de alteração.

## Contribuição

Este é um projeto simples para aprendizado. Sinta-se à vontade para melhorar validações, adicionar autenticação ou expandir funcionalidades.