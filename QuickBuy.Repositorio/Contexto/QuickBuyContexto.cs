using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
    //aqui foi criada uma classe que herda do DBContext, dessa forma podemos agr começar a trabalhar com o DBSet
    //O dbset para ser utilizado depende do dbcontext.
    //esse projeto contexto precisa ser referenciado em um projeto executavel, neste caso essa classe vai ser referenciada no nosso projeto web, onde tbm está localizado o projeto de angular.
    //este projeto pra ser referenciado, a mesma  foi adicionada na classe startup, que é a classe que configura a aplicação netcore.
    public class QuickBuyContexto : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; } //nesse caso é bom definir o nome no plural pq o nome que for utilizado aqui será o mesmo que vai para o banco de dados na definição das tabelas.
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; } //dessa forma é feita a configuração basica do dbset.

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }
    }
}
