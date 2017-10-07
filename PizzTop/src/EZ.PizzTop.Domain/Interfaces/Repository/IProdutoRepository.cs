using System;
using System.Collections.Generic;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Domain.Interfaces.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> ObterProdutosPorTipoProduto(Guid produtoId);
    }
}