# API RESTful com .NET e C#
O objetivo deste projeto é aplicar os conhecimentos, criando uma API RESTful com os melhores padrões de desenvolvimento, segurança e escalabilidade utilizando .NET e C#.

## Tecnologias Utilizadas
- ASP.NET Core 6: Framework utilizado para o desenvolvimento da API.
- C#: Linguagem de programação utilizada para a implementação da lógica de negócios.
- JWT (JSON Web Tokens): Para autenticação e controle de acesso.
- Entity Framework Core: Para acesso e modelagem de banco de dados.
- Fluent Validation: Para validação de dados de entrada.
- MediatR (CQRS): Para implementar a arquitetura CQRS, separando comandos e consultas.
- AutoFac: Framework de Injeção de Dependências.
- SQL Server: Banco de dados utilizado para persistência de dados.
 
## Funcionalidades
- Criação de APIs RESTful
Conceitos básicos: Entendimento do padrão REST, criação de controladores e mapeamento de rotas.
Verbos HTTP: Implementação de métodos para gerenciar requisições HTTP (GET, POST, PUT, DELETE).
Gerenciamento de erros: Tratamento de exceções e envio de códigos de status apropriados.

- Autenticação e Autorização
JWT (JSON Web Tokens): Implementação de autenticação via tokens JWT para garantir a identidade dos usuários.
Controle de Acesso: Uso de roles e permissões para garantir o acesso adequado às rotas da API.

- Boas Práticas de Desenvolvimento e Segurança
Injeção de dependências: Melhoria na modularidade e testabilidade utilizando injeção de dependências.
Clean Architecture: Aplicação da arquitetura limpa para garantir a separação de responsabilidades e manutenibilidade do código.
Segurança: Implementação de medidas para proteger a API contra vulnerabilidades comuns.

- Acesso a Banco de Dados
Entity Framework Core: Utilização para mapeamento de entidades, consultas complexas e migrações de banco de dados.
SQL Server: Banco de dados utilizado para persistência de dados.

- CQRS (Command Query Responsibility Segregation)
MediatR: Implementação da biblioteca MediatR para separar comandos e consultas, melhorando a performance e escalabilidade da API.

- Validação de Dados
Fluent Validation: Implementação de regras de validação personalizadas para garantir dados corretos na entrada da API.
