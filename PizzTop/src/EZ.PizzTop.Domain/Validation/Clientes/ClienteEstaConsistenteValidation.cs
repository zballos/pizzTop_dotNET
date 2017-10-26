using DomainValidation.Validation;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Specification.Clientes;

namespace EZ.PizzTop.Domain.Validation.Clientes
{
    public class ClienteEstaConsistenteValidation : Validator<Cliente>
    {
        public ClienteEstaConsistenteValidation()
        {
            var clienteCPF = new ClienteDevePossuirCpfValidoSpecification();
            var clienteEmail = new ClienteDevePossuirEmailValidoSpecification();
            //var clienteMaiorIdade = new ClienteDeveSerMaiorDeIdadeSpecification();

            base.Add("clienteCPF", new Rule<Cliente>(clienteCPF, "Cliente informou um CPF inválido."));
            base.Add("clienteEmail", new Rule<Cliente>(clienteEmail, "Cliente informou um Email inválido."));
            //base.Add("clienteMaiorIdade", new Rule<Cliente>(clienteMaiorIdade, "Cliente não tem maioridade para cadastro."));
        }
    }
}