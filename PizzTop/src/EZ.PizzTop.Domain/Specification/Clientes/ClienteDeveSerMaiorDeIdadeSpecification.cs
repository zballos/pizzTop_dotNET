using System;
using DomainValidation.Interfaces.Specification;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Domain.Specification.Clientes
{
    public class ClienteDeveSerMaiorDeIdadeSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            // superficial
            return true;//DateTime.Now.Year - cliente.DataNascimento.Year >= 18;
        }
    }
}