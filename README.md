# DXS_ASPNET_webapi_crud_clients

Pacotes instalados:
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.1

Requer:
Serviço de MySql rodando com o bd script incluso aqui.

Comandos utilizados para preparar a aplicação:
dotnet ef migrations add PrimeiraMigration //mapeando DataContext e criando a 'PrimeiraMigration'
dotnet ef database update //Se não houver banco com mesmo nome configurado ele o cria, 
espelha todas as mudanças do DataContext neste banco de dados,
setando toda estrutura e criando uma tabela de historico de migrations

Rodando aplicação:
dotnet run