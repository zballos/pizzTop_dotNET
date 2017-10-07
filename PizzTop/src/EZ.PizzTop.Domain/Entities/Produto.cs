using System;
using System.Collections.Generic;

namespace EZ.PizzTop.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            ProdutoId = Guid.NewGuid();
        }

        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public Guid TipoProdutoId { get; set; }
        public virtual TipoProduto TipoProduto { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}