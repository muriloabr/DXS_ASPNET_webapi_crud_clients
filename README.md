# DXS | ASPNET : WebApi > Crud de Clientes
<img src="https://dataxstudios.com.br/assets/images/logo_DXS_400_190.png" alt="dxs" width="100"/> 

Aplicação e estudo dos conceitos avançados de programação de WebApi em ASPNET

- EntityFrameworkCore, Annotations, DataAnnotations;
- MvC, Threading, Routes, DbContext, Migrations;
- Estruturas, conceitos e funções;
- ✨Atualizações da linguagem .NET6 + comentários.

## Pacotes instalados:
dotnet tool install --global dotnet-ef<br>
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9<br>
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9<br>
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.1

## Requer:
Serviço de MySql rodando.

## Comandos utilizados para preparar a aplicação:
_//mapeando DataContext e criando a 'PrimeiraMigration'_<br>
dotnet ef migrations add PrimeiraMigration<br>
_//Se não houver banco com mesmo nome configurado ele o cria, <br>
espelha todas as mudanças do DataContext neste banco de dados,<br>
setando toda estrutura e criando uma tabela de historico de migrations_
dotnet ef database update

## Rodando a aplicação:
dotnet run

### Tela de resultado final, interagindo com a WebApi:<br>![imagem da aplicação](https://dataxstudios.com.br/assets/images/github/aspnet_webapi_crud_clients_1.PNG)
Fique por dentro deste repositório com atualizações sempre que possível!<br>[ASPNET] [DOTNET] [MYSQL] #aspnet #webapi
