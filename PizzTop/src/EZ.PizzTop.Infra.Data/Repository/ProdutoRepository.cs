using System;
using System.Collections.Generic;
using System.Linq;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Interfaces.Repository;

namespace EZ.PizzTop.Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> ObterProdutosPorTipoProduto(Guid tipoProdutoId)
        {
            return Buscar(p => p.TipoProdutoId == tipoProdutoId).ToList();
        }
    }
}