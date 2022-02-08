using System.ComponentModel.DataAnnotations; //serve para especificar uso de chave primaria, campos que podem ser nulo, key que gera a chave primaria, etc

namespace DXS_ASPNET_webapi_crud_clients.Models{
    public class Cliente{
        [Key] //caracteristica de chave primaria no Id
        public int Id { get; set; }
        public int Nome { get; set; }

        public int Cidade { get; set; }
        public int Idade { get; set; }
    }
}