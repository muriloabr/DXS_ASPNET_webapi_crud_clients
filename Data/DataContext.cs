using DXS_ASPNET_webapi_crud_clients.Models;
using Microsoft.EntityFrameworkCore;

namespace DXS_ASPNET_webapi_crud_clients.Data{
    public class DataContext: DbContext {  //nome da classe escolhido assim DataContext por ser uma notação usual para mexer com DbContext 
        public DataContext(DbContextOptions<DataContext> options): base(options){
            /*
                Esta implementação é por extender o DbContext. Voce pode fazer depois fazer Override do DbContext.OnConfiguring(DbContextOptionsBuilder)
                para configurar o banco de dados que sera usado nesse contexto. Mas preferirimos configurar externamente em outra classe para fazer o uso
                de DbContextOptionsBuilder<TContext> (ou DbContextOptionsBuilder) para criar uma instacia externa de DbContextOptions<TContext>
                (ou DbContextOptions) e passar por este construtor que repassa para o construtor base de DbContext (bae(options)).
            */
        }
        //ABAIXO DEVEM SER COLOCADOS TODOS OS MODELS QUE UTILIZARÃO O BANCO DE DADOS
        public DbSet<Cliente> cliente { get; set; }
    }
}
