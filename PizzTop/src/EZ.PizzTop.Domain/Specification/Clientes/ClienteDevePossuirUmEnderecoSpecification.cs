using System.Linq;
using DomainValidation.Interfaces.Specification;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Domain.Specification.Clientes
{
    public class ClienteDevePossuirUmEnderecoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return cliente.Enderecos != null && cliente.Enderecos.Any();
        }
    }
}