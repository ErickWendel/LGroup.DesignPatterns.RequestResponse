using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Serviços sao COMPONENTES DE INTEGRAÇÃO
//sao usados para fazer integrações de 
//EMPRESAS (Serasa x LGroup)
//SISTEMAS (Juridico x RH)
//TECNOLOGIAS E LINGUAGENS (PHP x JAVA)
//So criar serviços para estes tres cenarios.
//A Microsoft tem 3 tecnologias pra criação, construção de Serviçoes (Não falar Web Service)
//2001 a 2005 = WebService(*.asmx)
//2006 a 2012 = WCF (*.svc) (HTTP, TCP, MSMQ, NAMED PIPE)
//TCP = FORMATO BINARIO
//MSMQ = Fila de Mensagens(Offline, priorização de cargo)
//NAMED PIPE = Chamadas entre aplicações ma mesma maquina, via UDP
//2012 até agora = Asp.Net Web API(somente via HTTP)

//Vamos criar 1 serviço com WCF e pra não rodar no IIS faremos um Self Hosting(Montaremos o nosso proprio Servidor)
//pra subir e executar o serviço
//SOA - Arquitetura Orientada a Serviço
//Tudo é acessado via Serviço (Regras, Acesso a Dados, Log)

//MICRO SERVICES
//Desmembrar o serviço
//CADA SERVICO
//tem 1 banco de dados
//tem 1 dll de acesso a dados
//tem 1 dll de armazenamento de dados
//tem 1 dll de negocio

using System.ServiceModel;
using LGroup.RequestResponse.Service.Contracts;
using LGroup.RequestResponse.Service.Implementation;

//para habilitar a maneira de saber o existe dentro do serviço(metodos), importamos este namespace
using System.ServiceModel.Description;

namespace LGroup.RequestResponse.Server
{
    class Program
    {
        //pra não usar o IIS
        //IIS -> Pesado, faz muito mais do que precisamos
        //Fora que, pode ser que alguma maquina nao tenha IIS, nós montamos o nosso proprio servidor web(Serviços)
        //Self Hosting(Nosso proprio IIS)
        static void Main(string[] args)
        {
            //Configurando o servidor, serviço

            //definimos a url, protocolo e porta
            var url = new Uri("http://localhost:12345/Cliente");

            //começamos a montar o Servidor autonomo(stand alone), propri IIS
            //1 parametro - é a classe de Serviço
            //2 parametro - é por onde ela vai ser acessada(porta, ip = url)
            //quando criamos um servico em wcf(1 classe = 1 interface)
            var servidor = new ServiceHost(typeof(ClienteService), url);

            //configuramos o binding, como o serviço vai ser acessado
            //1 parametro - Interface do Servico
            //2 parametro - Binding(protocolo e forma de acesso)
            //3 parametro - url (como ja foi definida uma url default, nao precisa informar)
            servidor.AddServiceEndpoint(typeof(IClienteService), new WSHttpBinding(), url);

            //as aplicacoes que forem acessar o serviço, precisam saber quais comandos existem dentro do serviço
            //neste caso, Cadastrar e Listar
            //Liberamos o WSDL para que seja possivel visualizar quais são
            servidor.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
            
            //ligamos o servidor.
            servidor.Open();

            Console.ReadKey();
        }
    }
}
