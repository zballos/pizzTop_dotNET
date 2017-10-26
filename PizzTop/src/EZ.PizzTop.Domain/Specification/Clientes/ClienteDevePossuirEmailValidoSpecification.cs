using DomainValidation.Interfaces.Specification;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Validation.Email;

namespace EZ.PizzTop.Domain.Specification.Clientes
{
    public class ClienteDevePossuirEmailValidoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return EmailValidation.Validate(cliente.Email);
        }
    }
}