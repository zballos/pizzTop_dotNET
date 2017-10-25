using System;
using System.Collections.Generic;
using EZ.PizzTop.Application.ViewModels;

namespace EZ.PizzTop.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        ClienteViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);

        ClienteViewModel ObterPorId(Guid id);

        IEnumerable<ClienteViewModel> ObterTodos();

        void Atualizar(ClienteViewModel clienteViewModel);

        void Remover(Guid id);

        ClienteViewModel ObterPorCPF(string cpf);

        ClienteViewModel ObterPorTelefone(string telefone);

        //ClienteViewModel ObterPorEmail(string email);
    }
}