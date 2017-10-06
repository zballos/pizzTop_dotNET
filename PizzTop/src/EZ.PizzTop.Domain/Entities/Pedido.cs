using System;
using System.Collections.Generic;

namespace EZ.PizzTop.Domain.Entities
{
    public class Pedido
    {
        public Pedido()
        {
            PedidoId = Guid.NewGuid();
            Produtos = new List<Produto>();
        }

        public Guid PedidoId { get; set; }
        public Guid ClienteId { get; set; }
        public double ValorTotal { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}