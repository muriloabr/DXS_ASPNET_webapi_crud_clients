# DXS | ASPNET : WebApi > Crud de Clientes
<img src="https://dataxstudios.com.br/assets/images/logo_DXS_400_190.png" alt="dxs" width="100"/> 

Aplicação e estudo dos conceitos avançados de programação de WebApi em ASPNET

- EntityFrameworkCore, Annotations, DataAnnotations;
- MvC, Threading, Routes, DbContext, Migrations;
- Estruturas, conceitos e funções;
- ✨Atualizações da linguagem .NET6 + comentários.

## Pacotes instalados:  
``dotnet tool install --global dotnet-ef``  
``dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9``  
``dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9``  
``dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.1``  

## Requer:
_Serviço de MySql rodando._

## Comandos utilizados para preparar a aplicação:  
_//mapeando DataContext e criando a 'PrimeiraMigration'_  
``dotnet ef migrations add PrimeiraMigration``  
_//Se não houver banco com mesmo nome configurado ele o cria, espelhando todas as mudanças do DataContext setado nas migrations neste banco de dados, inclusive toda a estrutura e criando uma tabela de histórico de migrations aplicadas_  
``dotnet ef database update``  

## Rodando a aplicação:  
``dotnet run``  

### Tela de resultado final, interagindo com a WebApi:<br>![imagem da aplicação](https://dataxstudios.com.br/assets/images/github/aspnet_webapi_crud_clients_1.PNG)
Fique por dentro deste repositório com atualizações sempre que possível!  
[ASPNET] [DOTNET] [MYSQL] [CSHARP] #aspnet #mysql #dotnet #csharp #webapi
