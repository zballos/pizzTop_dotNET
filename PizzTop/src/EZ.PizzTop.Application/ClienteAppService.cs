using System;
using System.Collections.Generic;
using AutoMapper;
using EZ.PizzTop.Application.Interface;
using EZ.PizzTop.Application.ViewModels;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Interfaces.Services;

namespace EZ.PizzTop.Application
{
    public class ClienteAppService : AppService, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public ClienteViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            cliente.Enderecos.Add(endereco);

            BeginTransaction();

            var clienteReturn = _clienteService.Adicionar(cliente);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(clienteReturn);

            if (!clienteReturn._validationResult.IsValid)
            {
                return clienteViewModel;
            }

            Commit();
            return clienteViewModel;
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);

            _clienteService.Atualizar(cliente);
        }

        public ClienteViewModel ObterPorCPF(string cpf)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorCPF(cpf));
        }

        public ClienteViewModel ObterPorTelefone(string telefone)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorTelefone(telefone));
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorId(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _clienteService.Remover(id);
        }

        public void Dispose()
        {
            _clienteService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}