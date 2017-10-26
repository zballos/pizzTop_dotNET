using DomainValidation.Validation;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Interfaces.Repository;
using EZ.PizzTop.Domain.Specification.Clientes;

namespace EZ.PizzTop.Domain.Validation.Clientes
{
    public class ClienteAptoParaInclusaoValidation : Validator<Cliente>
    {
        public ClienteAptoParaInclusaoValidation(IClienteRepository clienteRepository)
        {
            var cpfDuplicado = new ClienteDevePossuirCpfUnicoSpecification(clienteRepository);
            var emailDuplicado = new ClienteDevePossuirEmailUnicoSpecification(clienteRepository);
            var clienteEndereco = new ClienteDevePossuirUmEnderecoSpecification();

            base.Add("clienteCPF", new Rule<Cliente>(cpfDuplicado, "CPF já cadastrado! Esqueceu sua senha?"));
            base.Add("clienteEmail", new Rule<Cliente>(emailDuplicado, "Email já cadastrado! Esqueceu sua senha?"));
            base.Add("clienteEndereco", new Rule<Cliente>(clienteEndereco, "Cliente não informou endereço."));
        }
    }
}