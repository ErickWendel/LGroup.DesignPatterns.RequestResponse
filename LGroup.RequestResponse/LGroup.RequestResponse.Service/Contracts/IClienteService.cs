using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criamos um Serviço com WCF
//Windows Communcation Foundation - 2005
//Podemos criar serviços que podem ser acessados por 4 protocolos. HTTP, TCP, MSMQ ou Named Pipes(UDP)
using System.ServiceModel;
using LGroup.RequestResponse.DataTransferObject;
using LGroup.RequestResponse.DataTransferObject.Delivery;

//Com o Request-Response, padronizamos as entradas e saidas
//Sempre entra a mesma classe (Request)
//Sempre volta a mesma classe (Response)
//O ClienteDTO fica sempre encapsulado(Dentro) das classes de delivery
namespace LGroup.RequestResponse.Service.Contracts
{
    //Transformamos a nossa Iinterface em um Servico, para acessarmos de algum protocolo

    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        ResponseClienteDTO Listar(RequestClienteDTO request_);

        [OperationContract]
        ResponseClienteDTO Cadastrar(RequestClienteDTO request_);
    }
}
