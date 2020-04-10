using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade //Dessa maneira eu especifico nas outras classes que a minha class entidade é a classe Pai.
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; } //Obs.: Nome e sobre nome aqui foram configurados com o snipet, atraves do atributo prop que cria de forma altomatizada uma propriedade.
        public string SobreNome { get; set; }
        /// <summary>
        /// um usuario pode ter nenhum ou mtos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("O campo nome necessita ser preenchido.");
        }
    }
}
//Apenas para duvidas posteriores, o projeto foi iniciado por aqui com a criação das pastas Entidades e Contratos, dentro da classe Dominio.
//apenas para aprendizado nessa classe de dominio é criada e modelada as propriedades as quais vão ser utilizadas no sistema.