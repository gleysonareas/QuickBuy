﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarMensagem("Não indentificamos referencia ao produto selecionado.");
            if (Quantidade == 0)
                AdicionarMensagem("Quantidade não foi informada.");
        }
    }
}
