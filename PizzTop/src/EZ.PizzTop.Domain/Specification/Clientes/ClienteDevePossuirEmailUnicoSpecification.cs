using DomainValidation.Interfaces.Specification;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Interfaces.Repository;

namespace EZ.PizzTop.Domain.Specification.Clientes
{
    public class ClienteDevePossuirEmailUnicoSpecification : ISpecification<Cliente>
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteDevePossuirEmailUnicoSpecification(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool IsSatisfiedBy(Cliente cliente)
        {
            return _clienteRepository.ObterPorEmail(cliente.Email) == null;
        }
    }
}