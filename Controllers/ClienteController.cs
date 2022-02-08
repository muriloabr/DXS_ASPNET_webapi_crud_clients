using System.Threading.Tasks;
//A classe DataContext inlcuida dentro deste namespace DXS_ASPNET_webapi_crud_clients.Data
//que possibilida comunicação com o banco de dados atraves dos models criados, graças ao EntityFrameworkCore
using DXS_ASPNET_webapi_crud_clients.Data;
//MVC Responsavel pelas rotas
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DXS_ASPNET_webapi_crud_clients.Controllers{
    //Notations que indicam que o ClienteController é responsavel pelas rotas
    [Controller]
    [Route("[controller]")]
    public class ClienteController{
        //Notation que indica que o método faz parte da rota, HttpGet permite exibir o metodo passado por parametro
        [HttpGet("verDado")]
        public string verDado(){
            return "Veja este dado importante!";
        }
    }
}