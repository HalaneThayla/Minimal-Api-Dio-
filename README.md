## DIO - Trilha .NET - API com Autenticação JWT e CRUD de Veículos

www.dio.me

# Desafio de projeto

Neste desafio, utilizei os conhecimentos adquiridos no módulo de API da trilha .NET da DIO para desenvolver uma aplicação completa com autenticação JWT e operações CRUD para gerenciamento de veículos.

Contexto

Construí um sistema de gerenciamento de veículos, no qual é possível cadastrar, consultar, atualizar e excluir informações de forma segura.
Antes de acessar os dados, o usuário deve realizar login para obter um token JWT, garantindo que somente clientes autenticados tenham acesso aos recursos protegidos.

Implementei todos os verbos HTTP necessários (GET, POST, PUT, DELETE), seguindo boas práticas para construção de APIs REST.

# Fluxo da Aplicação

A aplicação segue duas etapas principais:

🔐 Autenticação do Usuário

O cliente envia email e senha

A aplicação valida as credenciais

Um token JWT é gerado

O token é enviado ao cliente, que deverá utilizá-lo nas próximas requisições

🚗 Gerenciamento de Veículos (CRUD)

Com o token válido, o usuário pode acessar os endpoints protegidos, que permitem:

Listar veículos (com paginação)

Consultar um veículo específico

Cadastrar um novo veículo

Atualizar um veículo existente

Remover um veículo

Toda requisição deve enviar o token no cabeçalho (Authorization: Bearer <token>).

Endpoints
🔑 Autenticação
Verbo	Endpoint	Parâmetro	Body
POST	/login	N/A	email, senha
POST	/administrador/criar	N/A	dados do admin
🚗 Veículos
Verbo	Endpoint	Parâmetro	Body
GET	/veiculos	N/A	N/A
GET	/veiculos/{id}	id	N/A
POST	/veiculos	N/A	Schema Veículo
PUT	/veiculos/{id}	id	Schema Veículo
DELETE	/veiculos/{id}	id	N/A
Schema (Model) de Veículo
{
  "id": 0,
  "marca": "string",
  "modelo": "string",
  "ano": 2024,
  "cor": "string",
  "valor": 0.0
}

## Solução

Neste desafio, utilizei os conceitos de API REST, autenticação JWT e Entity Framework para construir um sistema completo de gerenciamento de veículos.

Desenvolvi os endpoints protegidos por token, garantindo que apenas usuários autenticados possam acessar os dados. Também implementei todas as operações de CRUD para manipulação dos registros no banco de dados.

O fluxo de autenticação foi configurado para gerar e validar tokens JWT, aplicando boas práticas de segurança.
As migrations foram geradas para estruturar o banco de dados conforme os modelos criados.

Como resultado, obtive uma aplicação funcional, segura e organizada, seguindo todas as orientações e boas práticas ensinadas no módulo da DIO.