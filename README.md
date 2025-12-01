📱 API de Gestão de Veículos

Bem-vindo à API de Gestão de Veículos!
Esta API permite autenticação segura via JWT e oferece um conjunto completo de operações CRUD para gerenciar veículos de forma simples e eficiente.

🔐 Autenticação

Para acessar os endpoints protegidos, você deve realizar a autenticação e obter um token JWT válido.

Login

Endpoint: POST /login

Descrição: Realiza login com email e senha, retornando um token JWT para autenticação.

Parâmetros da requisição:

{
  "email": "string",
  "senha": "string"
}


Resposta (exemplo):

{
  "token": "seu_token_jwt_aqui"
}

🚗 Endpoints para Veículos

Todos os endpoints a seguir exigem o token JWT no cabeçalho Authorization no formato Bearer {token}.

1. Listar veículos (paginado)

Método: GET

Endpoint: /veiculos

Descrição: Retorna uma lista paginada de veículos cadastrados.

Exemplo de uso:

GET /veiculos
Authorization: Bearer {token}

2. Obter um veículo específico

Método: GET

Endpoint: /veiculos/{id}

Parâmetro: id — Identificador do veículo

Descrição: Retorna detalhes do veículo identificado pelo ID.

3. Criar um veículo

Método: POST

Endpoint: /veiculos

Descrição: Cadastra um novo veículo com as informações fornecidas.

Corpo da requisição: JSON com dados do veículo.

4. Atualizar um veículo

Método: PUT

Endpoint: /veiculos/{id}

Parâmetro: id — Identificador do veículo

Descrição: Atualiza os dados do veículo indicado.

5. Deletar um veículo

Método: DELETE

Endpoint: /veiculos/{id}

Parâmetro: id — Identificador do veículo

Descrição: Remove o veículo identificado pelo ID.

👨‍💼 Endpoints para Administração
Criar/Atualizar Administrador

Método: POST

Endpoint: /administrador/

Descrição: Cadastra ou atualiza um perfil de administrador/editor.

Corpo da requisição: JSON com perfil e dados do administrador.

💡 Fluxo de Uso

Autentique-se enviando seu email e senha para POST /login.

Receba o token JWT na resposta.

Inclua o token no cabeçalho das requisições seguintes para acessar os endpoints de veículos:

Authorization: Bearer {token}


Use os endpoints de veículos para listar, criar, atualizar ou deletar veículos.

Para gerenciar administradores, utilize o endpoint /administrador/.

📋 Exemplo de Login
{
  "email": "administrador@teste.com",
  "senha": "123456"
}

⚙️ Observações Técnicas

Todos os endpoints relacionados a veículos exigem autenticação via token JWT.

As respostas seguem o padrão RESTful.

A listagem de veículos é paginada para melhor desempenho.

Perfis de usuário são diferenciados entre administrador e editor.

