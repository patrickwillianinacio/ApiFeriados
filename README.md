API de Criação de Feriados Nacionais
Descrição
Esta API permite a criação, listagem e gerenciamento de feriados nacionais. A API é construída em C# e integra-se com a API PublicHoliday para facilitar a automação e o gerenciamento de feriados nacionais em aplicações diversas.

Funcionalidades
Listar Feriados Nacionais: Retorna uma lista de todos os feriados nacionais para um determinado ano.
Criar Feriado Nacional: Permite adicionar novos feriados nacionais ao banco de dados.
Consultar Feriado por Data: Verifica se uma data específica é um feriado nacional.
Deletar Feriado: Remove feriados nacionais do sistema.

Tecnologias Utilizadas
Linguagem: C#
Framework: ASP.NET Core
API Externa: PublicHoliday API
Banco de Dados: SQL Server (ou outro, se aplicável)
Configuração do Ambiente
Pré-requisitos:

.NET SDK (versão recomendada: 7.0 ou superior)
SQL Server (ou outro banco de dados de sua escolha)
Chave de API para a PublicHoliday API
Clonando o Repositório:

bash
Copiar código
git clone https://github.com/seu-usuario/sua-api-feriados.git
cd sua-api-feriados
Configuração do Banco de Dados:

Atualize a string de conexão no arquivo appsettings.json para apontar para seu banco de dados SQL Server.
Execute as migrações para criar as tabelas necessárias:
bash
Copiar código
dotnet ef database update
Configuração da API PublicHoliday:

No arquivo appsettings.json, adicione sua chave de API para a PublicHoliday API:
json

Copiar código

"PublicHolidayAPI": {
    "ApiKey": "sua-chave-api"
}

Executando a Aplicação
Desenvolvimento:

Execute o projeto localmente:
bash
Copiar código
dotnet run
Acesse a API em https://localhost:5001 (ou a porta configurada).
Produção:

Publique o projeto para produção:
bash
Copiar código
dotnet publish --configuration Release
Endpoints Principais
GET /api/feriados/{ano}: Retorna os feriados nacionais para o ano especificado.
POST /api/feriados: Cria um novo feriado nacional.
GET /api/feriados/data/{data}: Verifica se a data especificada é um feriado nacional.
DELETE /api/feriados/{id}: Deleta o feriado nacional pelo seu ID.
Contribuição
Fork o repositório e crie um branch com sua feature: git checkout -b minha-feature
Envie um pull request.
