using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
/*CUSTOMS IMPORTS*/
using Microsoft.EntityFrameworkCore;
using DXS_ASPNET_webapi_crud_clients.Data;

namespace DXS_ASPNET_webapi_crud_clients
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //codigo customizado abaixos
            string stringDeConexao = Configuration.GetConnectionString("conexaoMySQL"); //faz a conexao com o banco de dados atraves da variavel criada no appsettings.json
            services.AddDbContext<DataContext>( //Envio a classe data DataContext importado da pasta Data que tem todos os models dentro para gerar o banco de dados igual futuramente
                opt => opt.UseMySql(stringDeConexao, ServerVersion.AutoDetect(stringDeConexao)) //seta o uso do Mysql da string de conexão configurada
            );
            //codigo original abaixo
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DXS_ASPNET_webapi_crud_clients", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DXS_ASPNET_webapi_crud_clients v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
