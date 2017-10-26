using DomainValidation.Interfaces.Specification;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Interfaces.Repository;

namespace EZ.PizzTop.Domain.Specification.Clientes
{
    public class ClienteDevePossuirCpfUnicoSpecification : ISpecification<Cliente>
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteDevePossuirCpfUnicoSpecification(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool IsSatisfiedBy(Cliente cliente)
        {
            return _clienteRepository.ObterPorCPF(cliente.CPF) == null;
        }
    }
}