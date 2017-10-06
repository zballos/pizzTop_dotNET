using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Domain.Interfaces.Services
{
    public interface IClienteService : IDisposable
    {
        Cliente Adicionar(Cliente cliente);

        Cliente ObterPorId(Guid id);

        IEnumerable<Cliente> ObterTodos();

        void Atualizar(Cliente cliente);

        void Remover(Guid id);

        Cliente ObterPorCPF(string cpf);

        Cliente ObterPorTelefone(string telefone);

        //Cliente ObterPorEmail(string email);
    }
}
