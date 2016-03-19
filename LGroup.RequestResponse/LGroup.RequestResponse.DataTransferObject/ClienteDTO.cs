using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Padrão DTO(Data Transfer Object) - Martin Fowler(2010)
//A ideia é, criar classes que armazenam dados a serem transmitidos, repassados de 1 dll para outra.
//Só podemos chamar de Model quando for algum Padrão Visual(MVC, MVP e MVVM)
//Se não tiver padrão visual, o nome correto, o nome coerente é DTO
//Um DTo não pode ter regras de negocio, validações complexas.
//A ideia é somente armazenar dados, e transmitir entre as camadas ou serviços

namespace LGroup.RequestResponse.DataTransferObject
{
   public sealed class ClienteDTO
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }


    }
}
