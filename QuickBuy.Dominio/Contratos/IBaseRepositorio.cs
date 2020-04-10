using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    //toda interface no que diz respeito ao nome é uma boa pratica principalmente pra intendimento do código sempre começar com a letra i no inicio do nome da interface.
    //no que diz respeito ao padrão repositorio a classe dominio não tem conhecimento do banco de dados. quem tem esse acesso é a classe de repositório.
    //a classe de repositório não só interagi com o dbContest, como tbm faz interação com a class de dominio atraves da interface a qual vamos começar a implementar nesse instante.
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class //essa interface ela herda de uma outra interface, e tbm explico para o visual studio q o TEntity é uma class
    {
        //nessa camada será definido o nome dos metódos que serão utilizados pela camada de repositório
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
