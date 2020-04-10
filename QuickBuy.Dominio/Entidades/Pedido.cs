using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        /// <summary>
        /// tem que haver pelo menos um ou varios itens pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedido{ get; set; }

        public override void Validate()//dessa forma eu defino as mensagens de validação para validar cada entidade antes do envio.
        {
            LimparMensagensValidacao();
            if (!ItensPedido.Any())
                AdicionarMensagem("Pedido não pode ser validado sem itens de pedido.");
            if (string.IsNullOrEmpty(Cep))
                AdicionarMensagem("Campo Cep deve estar devidamente preenchido para envio.");            
        }
    }
}
