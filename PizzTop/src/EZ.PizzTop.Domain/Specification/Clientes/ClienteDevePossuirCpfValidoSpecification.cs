using DomainValidation.Interfaces.Specification;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Validation.Documentos;

namespace EZ.PizzTop.Domain.Specification.Clientes
{
    public class ClienteDevePossuirCpfValidoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return CPFValidation.Validar(cliente.CPF);
        }
    }
}