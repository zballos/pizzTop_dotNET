﻿using System;
using System.Collections.Generic;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Domain.Interfaces.Repository
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        //double CalculaTotalPedido();
        IEnumerable<Pedido> ObterPedidosPorCliente(Guid clienteId);

        IEnumerable<Pedido> ObterPedidosPeloValorTotal(double valor);
        //Pedido ObterPorProduto(Guid guid);
    }
}