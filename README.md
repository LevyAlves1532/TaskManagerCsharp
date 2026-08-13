# TaskManager

API REST em C# (.NET 8) criada como desafio do curso de formação em C# da Rocketseat. O objetivo deste projeto é demonstrar uma arquitetura em camadas (Communication, Application e API), com separação entre camada de comunicação (DTOs/enums) e camada de regras de negócio (use cases), validações básicas e respostas padronizadas.

## Estrutura do projeto

- TaskManager.API — Camada de comunicação HTTP (Controllers, Program). Expondo endpoints REST e Swagger em ambiente de desenvolvimento.
- TaskManager.Application — Camada de regras de negócio (use cases, entidades, validações e exceções customizadas).
- TaskManager.Communication — DTOs (requests/responses) e enums usados pela API e pela camada de aplicação.

## Requisitos

- .NET 8 SDK
- Visual Studio 2022/2026 ou VS Code (opcional)

## Como executar

1. Clonar o repositório:

   git clone https://github.com/LevyAlves1532/TaskManagerCsharp.git
   cd TaskManager

2. Build e execução via CLI:

   dotnet build
   dotnet run --project TaskManager.API/TaskManager.API.csproj

   A API será iniciada em https://localhost:5001 (padrão Kestrel) ou na porta informada pelo launchSettings.

3. Ou, abra a solução TaskManager.slnx no Visual Studio e execute o projeto TaskManager.API.

4. Em ambiente de desenvolvimento o Swagger UI estará disponível em /swagger para testar os endpoints.

## Endpoints

Base: /api/task

- POST /api/task — Criar tarefa
- GET /api/task — Listar todas as tarefas
- GET /api/task/{id} — Obter tarefa por id
- PUT /api/task/{id} — Atualizar tarefa por id
- DELETE /api/task/{id} — Remover tarefa por id

## Modelos (Request / Response)

Request (RequestTaskJson):
{
  "name": "Nome da tarefa",
  "description": "Descrição opcional",
  "priority": 1,      // 0 = High, 1 = Medium, 2 = Low
  "dueDate": "2026-12-31T23:59:59",
  "status": 0         // 0 = Pending, 1 = InProgress, 2 = Completed
}

Response de sucesso (exemplo de criação):
{
  "id": "guid",
  "name": "Nome da tarefa",
  "dueDate": "2026-12-31T23:59:59",
  "status": 1
}

Response de erros (padronizado):
{
  "errors": [
	"Mensagem de erro"
  ]
}

## Validações implementadas

- name: obrigatório, trimado, máximo 100 caracteres
- dueDate: deve ser maior que a data atual
- priority e status: devem ser valores válidos dos enums
- Tratamento de NotFound nas operações que recebem id

## Observações

- A implementação atual dos use cases (GetAll, GetById, Update, Delete) fornece dados/fallbacks estáticos ou placeholders para demonstrar a separação de camadas. Para produção, é esperado conectar uma camada de persistência (ex.: repositórios, banco de dados) e ajustar os use cases para operar sobre dados reais.

- O projeto serve como exercício para praticar arquitetura em camadas, padrões de resposta e validações de entrada.

## Testes manuais

- Usar Swagger UI (/swagger) ou ferramentas como curl / Postman / HTTPie para testar os endpoints.

Exemplo curl (criar tarefa):

curl -k -X POST https://localhost:5001/api/task \
  -H "Content-Type: application/json" \
  -d '{"name":"Nova tarefa","description":"...","priority":1,"dueDate":"2026-12-31T23:59:59","status":0}'

## Licença

Repositório pessoal criado como desafio do curso da Rocketseat.
