using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.RequestResonse.ValueObject;

//subimos pra memoria as Enuns(secundario)
//no JAVA, há quem faça DTO, Model e chame de VO

namespace LGroup.RequestResponse.DataTransferObject.Delivery
{
    //Classe de Saida do Serviço(Resposts)
    //Entra Request - Volta Response
    public sealed class ResponseClienteDTO
    {
        public IEnumerable<ClienteDTO> Clientes { get; set; }

        //campos de rastreamento
        public DateTime DataExecucao { get; set; }
        public TimeSpan TempoExecucao { get; set; }
        public String Mensagem { get; set; }
        //Dados Secundario
        public TipoResposta TipoMensagem { get; set; }
    }
}
