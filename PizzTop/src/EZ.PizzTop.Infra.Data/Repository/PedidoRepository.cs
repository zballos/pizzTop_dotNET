using System;
using System.Collections.Generic;
using System.Linq;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Interfaces.Repository;

namespace EZ.PizzTop.Infra.Data.Repository
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public IEnumerable<Pedido> ObterPedidosPeloValorTotal(double valor)
        {
            return Buscar(p => p.ValorTotal == valor).ToList();
        }

        public IEnumerable<Pedido> ObterPedidosPorCliente(Guid clienteId)
        {
            return Buscar(p => p.ClienteId == clienteId).ToList();
        }
    }
}