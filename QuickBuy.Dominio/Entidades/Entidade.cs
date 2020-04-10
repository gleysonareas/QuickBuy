using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade //Essa vai ser a minha class pai.
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
        public abstract void Validate(); //sempre que eu defino uma propriedade como abstract eu forço as classes filhas a seguirem o que for definido pela classe pai.
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }//As entidades só vão ser consideradas uma instancia validada se não houver uma Mensagem de validação.
        }
        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarMensagem(string mensagem) 
        {
            mensagemValidacao.Add(mensagem);
        }
    }
}
