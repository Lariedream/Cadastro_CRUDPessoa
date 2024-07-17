Cadastro de Pessoas

## Descrição
Meu projeto utiliza o banco de dados PostgreSQL e é desenvolvido em C# utilizando Windows Forms.

## Requisitos
- Visual Studio 2019 ou superior
- PostgreSQL 12 ou superior
- Docker e Docker Compose (para configuração simplificada do banco de dados)

## Dependências
Para executar este projeto, você precisa ter as seguintes dependências instaladas:

- Npgsql: Biblioteca para acesso ao banco de dados PostgreSQL em C#.
- Dapper: Micro ORM para facilitar a interação com o banco de dados.

## Configuração do Banco de Dados

Para facilitar a configuração e execução do banco de dados PostgreSQL, você pode usar Docker. Siga os passos abaixo:

### 1. Criar e Configurar o Banco de Dados

No diretório raiz do projeto, há um arquivo `docker-compose.yml` que define o serviço do banco de dados PostgreSQL. 
Para iniciar o banco de dados, execute o seguinte comando:
docker-compose up -d

## Instalação
Para usar este projeto, siga estas etapas:

1. Clone o repositório.
2. Instale as dependências.
3. Configure as credenciais do banco de dados no arquivo `DbConexao` caso nao use o docker.

## Uso
Para iniciar o projeto, execute o aplicativo no Visual Studio. Aqui estão algumas funcionalidades principais:

- Cadastro de pessoas.
- Editar e remover cadastros existentes.
- Visualizar lista de cadastros.
