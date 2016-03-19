using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//criamos o proxy. proxy é uma referencia para o serviço, o mediador, intemediador do serviço
//aplicacao -> proxy -> serviço

using LGroup.RequestResponse.Client.ProxyCliente;

namespace LGroup.RequestResponse.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listar
            //abrimos um canal de comunicacao com o serviço
            //inicializamos o serviço(palavra client)
            using (var servico = new ClienteServiceClient())
            {
                //Chamamos o comando lista
                var resposta = servico.Listar(new RequestClienteDTO());
                dataGridView1.DataSource = resposta.Clientes;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cadastrar
            using (var servico = new ClienteServiceClient())
            {
                var pedido = new RequestClienteDTO();
                pedido.Cliente = new ClienteDTO
                {
                    Nome = "AAA",
                    Email = "aaaa@ig.com.br"
                };

                var resposta = servico.Cadastrar(pedido);
            }
        }
    }
}
