using System.Threading.Tasks;
//A classe DataContext inlcuida dentro deste namespace DXS_ASPNET_webapi_crud_clients.Data
//que possibilida comunicação com o banco de dados atraves dos models criados, graças ao EntityFrameworkCore
using DXS_ASPNET_webapi_crud_clients.Data;
//MVC Responsavel pelas rotas
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//Estamos utilizando os models nesta classe de controller para prover servicos com eles durante a codificação
using DXS_ASPNET_webapi_crud_clients.Models;

namespace DXS_ASPNET_webapi_crud_clients.Controllers{  
    //Notations que indicam que o ClienteController é responsavel pelas rotas
    [Controller]
    [Route("[controller]")]
    public class ClienteController: ControllerBase{ //herdando ControllerBase
        private DataContext dc;

        public ClienteController(DataContext  context){
            this.dc = context; ;//Receber o contexto para acesso ao banco de dados
        }

        //metodo suporta ler o metodo do HTTP, no caso POST, quando chamado /acao
        [HttpPost("acao")]
        //metodo asincrono que retorna um ActionResult que é um objeto qualquer
        public async Task<ActionResult> cadastrar([FromBody] Cliente novoCliente){ //graças a herança do ControllerBase, temos como identificar de onde captaremos os dados para cadastro 
            try{
                this.dc.cliente.Add(novoCliente);
                await this.dc.SaveChangesAsync(); //trava o processo esperando o resultado de salvar no banco de dados do dc DataContext
                return Created("IMPLEMENTAR A URL DE OBJETO INSERIDO SENDO LIDO DO BD PARA CONFIRMAR", novoCliente); //retorna o status 201 de Created, e json com dados inseridos!
            }catch(DbUpdateException e){
                return BadRequest("Recebemos algum dado inválido: "+e.Message+" : "+(novoCliente));
            }catch(System.Exception e){
                //retorna o status 400 de BadRequest e mensagem de erro escrita!
                return BadRequest("Faltou algum argumento: "+e.Message+" : "+(novoCliente));
            }
        }

        //metodo suporta ler o metodo do HTTP, no caso Get, quando chamado /acao
        [HttpGet("acao")]
        //metodo asincrono que retorna um ActionResult que é um objeto qualquer
        public async Task<ActionResult> listar(){
            var dados = await this.dc.cliente.ToListAsync();
            return Ok(dados); //retorna o status 200 de Ok, e json com dados listados!
        }
        
         //metodo suporta ler o metodo do HTTP, no caso Get, quando chamado /acao e o codigo_cliente é o novo parametro que ele vai ler tbm
        [HttpGet("acao/{codigo_cliente}")]
        //metodo normal que recebe o primeiro parametro recebido pela rota na url
        public Cliente filtrar(int codigo_cliente){
            Cliente clienteLocalizado = this.dc.cliente.Find(codigo_cliente);
            return clienteLocalizado;
        }

        //metodo suporta ler o metodo do HTTP, no caso Put, quando chamado /acao
        [HttpPut("acao")]
        //metodo asincrono que retorna um ActionResult que é um objeto qualquer
        public async Task<ActionResult> editar([FromBody] Cliente cliente){
            this.dc.cliente.Update(cliente);
            await this.dc.SaveChangesAsync();
            return Ok(cliente);//retorna o status 200 de Ok, e json com dados listados!
        }

        //metodo suporta ler o metodo do HTTP, no caso DELETE, quando chamado /acao e o codigo_cliente é o novo parametro que ele vai ler tbm
        [HttpDelete("acao/{codigo_cliente}")]
        //metodo normal que recebe o primeiro parametro recebido pela rota na url
        public async Task<ActionResult> remover(int codigo_cliente){
            Cliente clienteLocalizado = filtrar(codigo_cliente); //seleciono o usario por completo para que seja possivel a exclusão dele
            if(clienteLocalizado == null){
                return NotFound(); //retorna o status 400 de notFound!
            } else {
                this.dc.cliente.Remove(clienteLocalizado); //removendo
                await this.dc.SaveChangesAsync();
                return Ok();
            }
        }

        
        [HttpGet("verMensagem")]
        public string verDado(){
            return "Veja este dado importante!";
        }
    }
}