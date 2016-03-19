using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//subimos a namespace para habilitar o cronometro
using System.Diagnostics;

using LGroup.RequestResonse.ValueObject;
using System.ServiceModel;
using LGroup.RequestResponse.DataTransferObject;
using LGroup.RequestResponse.DataTransferObject.Delivery;

namespace LGroup.RequestResponse.Service.Implementation
{
    public sealed class ClienteService : Contracts.IClienteService
    {
        //criamos um objeto de resposta
        //sempre volta uma resposta
        private readonly ResponseClienteDTO _resposta = new ResponseClienteDTO();
        private readonly Stopwatch _cronometro = new Stopwatch();

        public ResponseClienteDTO Listar(RequestClienteDTO request_)
        {
            //LIGAMOS O CRONOMETRO
            _cronometro.Start();

            //Fingi que foi no banco e deu select
            _resposta.DataExecucao = DateTime.Now;
            _resposta.Mensagem = "Clientes listados com sucesse";
            _resposta.TipoMensagem = TipoResposta.Sucesso;

            _resposta.Clientes = new List<ClienteDTO>{
                new ClienteDTO{
                    Codigo = 1,
                    Nome="Andre",
                    Email="abc@ig.com.br",
                    Telefone = "1111111"
                }
            };

            //desligamos o cronometro
            _cronometro.Stop();

            _resposta.TempoExecucao = _cronometro.Elapsed;

            return _resposta;
        }

        public ResponseClienteDTO Cadastrar(RequestClienteDTO request_)
        {
            //LIGAMOS O CRONOMETRO
            _cronometro.Start();

            _resposta.DataExecucao = DateTime.Now;
            _resposta.Mensagem = "Clientes listados com sucesse";
            _resposta.TipoMensagem = TipoResposta.Sucesso;

            if (request_.Cliente == null)
            {
                _resposta.Mensagem = "Informe o cliente";
                _resposta.TipoMensagem = TipoResposta.Aviso;
            }

            //desligamos o cronometro
            _cronometro.Stop();

            _resposta.TempoExecucao = _cronometro.Elapsed;

            return _resposta;
        }
    }
}


