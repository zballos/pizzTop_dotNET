using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCPF(string cpf);

        //Cliente ObterPorEmail(string email);

        Cliente ObterPorTelefone(string telefone);
    }
}
