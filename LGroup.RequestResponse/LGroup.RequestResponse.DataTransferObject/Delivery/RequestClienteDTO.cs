using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Quando criamos serviços, temos diversos padrões de integração, construção de seviço
//o mais conhecido é o padrão Request-Response
//Tambem conhecido como Request-Reply
//Não é um padrão GOF, foi documentado pelo Martin Fowler no livro, EAI - Enterpise Architeture Integration
//Todos os dados que enviamos pro serviço SEMPRE devem ir em uma mesma classe, e voltar em uma mesma classe.
//Todas as informações vão dentro da mesma classe, e em uma unica chamada.
//Enviamos tudo um unica vez, dentro de uma classe Request. Devolução dos dados dentro de uma classe chamada Response.

namespace LGroup.RequestResponse.DataTransferObject.Delivery
{
    //Classe de Entrada do Serviço
    public sealed class RequestClienteDTO
    {
        public ClienteDTO Cliente { get; set; }
    }
}
